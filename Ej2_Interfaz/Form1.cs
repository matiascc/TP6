using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ej2;
using Ej2.IO;
using Ej2.Domain;
using Ej2.DAL.EntityFramework;

namespace Ej2_Interfaz
{
    public partial class Form1 : Form
    {
        Bank iBank = new Bank();

        public Form1()
        {
            InitializeComponent();
            
            //Carga los tipos de documentos en un ComboBox
            List<DocumentType> docList = iBank.ListTypeDocument();          
            foreach (var item in docList)
            {
                cbDocType.Items.Add(item);
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //Respuesta al boton de busqueda de cliente por id
        private void bSearchClientId_Click(object sender, EventArgs e)
        {
            try
            {   
                //Abre ventana de administracion del cliente pasando como parametro la id del cliente.
                AdmClient ventana = new AdmClient(Int32.Parse(tbIdForSearch.Text));
                ventana.Show();
            }
            catch(Exception exc)
            {
                MessageBox.Show("Verifique que ingreso correctamente el Id.", exc.Message);
            }
        }

        //Agrega un cliente nuevo
        private void bAddClient_Click(object sender, EventArgs e)
        {
            AccountManagerDbContext context = new AccountManagerDbContext();
            try
            { 
                iBank.AddClient(context, tbDocNum.Text, cbDocType.Text, 
                    tbFName.Text, tbLName.Text);

                int aux = iBank.SearchIdClientByNumDoc(context, tbDocNum.Text);
                
                tbIdForSearch.Text = aux.ToString();        //Muestra en el campo de id cual es la id asignada al nuevo cliente
            }
            catch(Exception exc)
            {
                MessageBox.Show("Verifique que ingreso correctamente los datos.", exc.Message);
            }
        }

        //Busca un cliente por num de documento
        private void bSearchClientNumDoc_Click(object sender, EventArgs e)
        {
            AccountManagerDbContext context = new AccountManagerDbContext();

            try
            { 
                int idClient = iBank.SearchIdClientByNumDoc(context, textBox1.Text);
                //Si el metodo devuelve 0, es porque no se encontro.
                if (idClient == 0)
                {
                    MessageBox.Show("No se encontro el cliente");
                }
                else
                { 
                    AdmClient ventana = new AdmClient(idClient);
                    ventana.Show();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Verifique que ingreso correctamente el Numero de Doc.", exc.Message);
            }
        }

        //Muestra en una dataGridView las cuentas con deuda
        private void bAccountsDebt_Click(object sender, EventArgs e)
        {
            AccountManagerDbContext context = new AccountManagerDbContext();
            try
            {
                IEnumerable<AccountDTO> AccDebt = iBank.GetAccountsWithDebt(context);

                dgvAccountsDebt.DataSource = AccDebt;
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error al buscar cuentas con deuda.", exc.Message);
            }
        }
    }
}
