using Ej2.DAL.EntityFramework;
using Ej2.IO;
using Ej2.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Ej2
{
    //Clase Fachada
    public class Bank
    {
        // Obtiene las cuentas de un cliente
        public IEnumerable<AccountDTO> GetClientAccounts(int pClientId)
        {
            List<AccountDTO> mAccounts = new List<AccountDTO>();

            using (var bUnitOfWork = new UnitOfWork(new AccountManagerDbContext()))
            {
                // Se obtiene el usuario
                var mClient = bUnitOfWork.ClientRepository.Get(pClientId);

                // Se iteran por cada cuenta del usuario
                foreach (var bAccount in mClient.Accounts)
                {
                    // Se genera el objecto DTO en base al objeto de Dominio
                    mAccounts.Add(new AccountDTO
                    {
                        Balance = bAccount.GetBalance(),
                        Id = bAccount.Id,
                        Name = bAccount.Name,
                        OverDraftLimit = bAccount.OverdraftLimit
                    });
                }

                bUnitOfWork.Complete();
            }

            // Se devuelven las cuentas
            return mAccounts;
        }

        // Obtiene los movimientos de la cuenta
        public IEnumerable<AccountMovementDTO> GetAccountMovements(int pAccountId)
        {
            List<AccountMovementDTO> mAccountMovements = new List<AccountMovementDTO>();

            using (var bUnitOfWork = new UnitOfWork(new AccountManagerDbContext()))
            {
                // Se obtiene la cuenta
                var mAccount = bUnitOfWork.AccountRepository.Get(pAccountId);

                // Se iteran por cada movimiento de la cuenta
                foreach (var bAccount in mAccount.Movements)
                {
                    // Se genera el objecto DTO en base al objeto de Dominio
                    mAccountMovements.Add(new AccountMovementDTO
                    {
                        Amount = bAccount.Amount,
                        Id = bAccount.Id,
                        Date = bAccount.Date,
                        Description = bAccount.Description
                    });
                }

                bUnitOfWork.Complete();
            }

            // Se devuelven los movimentos de cuentas
            return mAccountMovements;
        }

        //Agrega un nuevo cliente
        public void AddClient(AccountManagerDbContext pContext, String pDocument,
            String pDocumentType, String pName, String pSurname)
        {
            DocumentType iDocT;
            //Verifica que tipo de documento de identidad selecciono.
            if (pDocumentType == "CUIL")
            {
                iDocT = DocumentType.CUIL;
            }
            else if (pDocumentType == "DNI")
            {
                iDocT = DocumentType.DNI;
            }
            else if (pDocumentType == "LC")
            {
                iDocT = DocumentType.LC;
            }
            else
            {
                iDocT = DocumentType.LE;
            }

            using (var bUnitOfWork = new UnitOfWork(new AccountManagerDbContext()))
            {
                Client iCliente = new Client
                {
                    Document = new Document
                    {
                        Type = iDocT,
                        Number = pDocument
                    },
                    FirstName = pName,
                    LastName = pSurname,

                    Accounts = new List<Account> { }

                };

                bUnitOfWork.ClientRepository.Add(iCliente);

                bUnitOfWork.Complete();
            }
            
        }

        //Agrega una cuenta
        public void AddAccount(int pIdClient, String pName, int pOverdraftLimit)
        {
            using (var bUnitOfWork = new UnitOfWork(new AccountManagerDbContext()))
            {
                var mClient = bUnitOfWork.ClientRepository.Get(pIdClient);

                mClient.Accounts.Add(new Account
                {
                    Name = pName,
                    OverdraftLimit = pOverdraftLimit,
                    Movements = new List<AccountMovement> { }
                });

                bUnitOfWork.Complete();
            }

        }
        
        //Agrega un movimiento
        public void AddMovement(int pIdAccount, String pDescription, int pAmount)
        {
            using (var bUnitOfWork = new UnitOfWork(new AccountManagerDbContext()))
            {
                var mAccount = bUnitOfWork.AccountRepository.Get(pIdAccount);

                mAccount.Movements.Add(
                    new AccountMovement
                    {
                        Date = DateTime.Now,
                        Description = pDescription,
                        Amount = pAmount
                    });

                bUnitOfWork.Complete();
            }
        }

        //Obtiene las cuentas con deuda
        public IEnumerable<AccountDTO> GetAccountsWithDebt(AccountManagerDbContext pContext)
        {
            List<AccountDTO> mAccountWithDebt = new List<AccountDTO>();

            using (var bUnitOfWork = new UnitOfWork(new AccountManagerDbContext()))
            {
                //Verifica cada cuenta de cada cliente
                foreach (Client bClient in pContext.Clients)    
                {
                    foreach (Account bAccount in bClient.Accounts)
                    {

                        if ((bAccount.GetBalance()) < (bAccount.OverdraftLimit * -1))       //Si el balance es menor al negativo del limite de descubierto
                        {
                            mAccountWithDebt.Add(new AccountDTO
                            {
                                Id = bAccount.Id,
                                Name = bAccount.Name,
                                OverDraftLimit = bAccount.OverdraftLimit,
                                Balance = bAccount.GetBalance()
                            });
                        }
                    }
                }

                bUnitOfWork.Complete();
            }
            
            return mAccountWithDebt;
        }

        //Devuelve los tipos de documentos en una lista
        public List<DocumentType> ListTypeDocument()
        {
            List<DocumentType> TypeDoc = new List<DocumentType>();

            foreach (DocumentType item in Enum.GetValues(typeof(DocumentType)))
            {
                TypeDoc.Add(item);
            }

            return TypeDoc;
        }

        //Busca el id del cliente por numero de documento
        public int SearchIdClientByNumDoc (AccountManagerDbContext pContext, String pNumDoc)
        {
            int idClient = 0;

            using (var bUnitOfWork = new UnitOfWork(new AccountManagerDbContext()))
            {
                //foreach (var bClient in bUnitOfWork.ClientRepository.GetAll())
                foreach (Client bClient in pContext.Clients)
                {
                    //if (bClient.Document.Equals(pNumDoc))
                    if (bClient.Document.Number.Equals(pNumDoc))
                    {
                        idClient = bClient.Id;
                        return idClient;
                    }
                }

            }
            return idClient;
        }

        //Busca una cuenta por nombre de la cuenta y cliente. Devuelve el id de la cuenta.
        public int GetAccountIdByNameAndIdClient(int IdClient, String pName)
        {
            IEnumerable<AccountDTO> AccountsList = GetClientAccounts(IdClient);
            
            foreach (var item in AccountsList)
            {
                if (item.Name == pName)
                {
                    return item.Id;
                }
            }
            return 0;
        }
    }
}
