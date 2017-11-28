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
using Ej2.DAL.EntityFramework;
using Ej2.IO;

namespace Ej2_Interfaz
{
    public partial class AdmClient : Form
    {
        Bank iBank = new Bank();

        public AdmClient(int pClientId)
        {
            InitializeComponent();

            l_Id.Text = pClientId.ToString();   //Muestra en el label el id del cliente.

            ActualizarComboBox();       //Carga el combo box con las cuentas del cliente.
        }

        private void AdmClient_Load(object sender, EventArgs e)
        {
            
        }

        //Agrega una cuenta.
        private void bAddAccount_Click(object sender, EventArgs e)
        {
            Bank iBank = new Bank();
            AccountManagerDbContext context = new AccountManagerDbContext();
            try
            {
                iBank.AddAccount(Int32.Parse(l_Id.Text), tbName.Text, Int32.Parse(tbOverdraftLimit.Text));

                ActualizarComboBox();
            }
            catch(Exception exc)
            {
                MessageBox.Show("Verifique que ingreso correctamente los datos.", exc.Message);
            }
        }

        //Carga el combo box con las cuentas del cliente.
        private void ActualizarComboBox()
        {
            cbAccounts.Items.Clear();

            foreach (var item in iBank.GetClientAccounts(Int32.Parse(l_Id.Text)))
            {
                cbAccounts.Items.Add(item.Name);
            }
        }

        //Confirma que la cuenta seleccionada es la deseada
        private void bConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                //Abre ventana de administracion de una cuenta pasando como parametro la id del cliente e id de la cuenta.
                int idAccount = iBank.GetAccountIdByNameAndIdClient(Int32.Parse(l_Id.Text), cbAccounts.Text);
                AdmAccount ventana = new AdmAccount(Int32.Parse(l_Id.Text), idAccount);
                ventana.Show();
            }
            catch(Exception exc)
            {
                MessageBox.Show("Verifique que selecciono correctamente la cuenta.", exc.Message);
            }
        }

        //Muestra en una dataGridView informacion sobre las cuentas de ese cliente.
        private void bInfoCuentas_Click(object sender, EventArgs e)
        {
            try
            { 
                IEnumerable<AccountDTO> listAccounts = iBank.GetClientAccounts(Int32.Parse(l_Id.Text));

                dgvCuentas.DataSource = listAccounts;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error al buscar informacion sobre las cuentas", exc.Message);
            }
        }
    }
}
