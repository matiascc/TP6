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
using Ej2.DAL.EntityFramework;

namespace Ej2_Interfaz
{
    public partial class AdmAccount : Form
    {
        public AdmAccount(int idClient, int idAccount)
        {
            InitializeComponent();

            l_IdClient.Text = idClient.ToString();       //Muestra en el label el id del cliente.
            l_IdAccount.Text = idAccount.ToString();        //Muestra en el label el id de la cuenta.

        }

        //Agrega un movimiento a la cuenta
        private void bAddMov_Click(object sender, EventArgs e)
        {
            Bank iBank = new Bank();

            AccountManagerDbContext context = new AccountManagerDbContext();
            try
            {
                iBank.AddMovement(Int32.Parse(l_IdAccount.Text), tbDescription.Text, Int32.Parse(tbAmount.Text));
            }
            catch (Exception exc)
            {
                MessageBox.Show("Verifique que ingreso correctamente los datos.", exc.Message);
            }
        }

        //Muestra en una dataGridView los ultimos movimientos de la cuenta.
        private void bShowLastMov_Click(object sender, EventArgs e)
        {
            Bank iBank = new Bank();

            try
            {
                IEnumerable<AccountMovementDTO> listMov = iBank.GetAccountMovements(Int32.Parse(l_IdAccount.Text));

                dataGridView1.DataSource = listMov;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error al desplegar los ultimos movimientos", exc.Message);
            }
        }
    }
}
