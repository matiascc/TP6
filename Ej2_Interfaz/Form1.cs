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
            
            List<DocumentType> docList = iBank.ListTypeDocument();
            foreach (var item in docList)
            {
                cbDocType.Items.Add(item);
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdmClient ventana = new AdmClient(Int32.Parse(tbIdForSearch.Text));
            ventana.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccountManagerDbContext context = new AccountManagerDbContext();

            iBank.AddClient(context, tbDocNum.Text, cbDocType.Text, 
                tbFName.Text, tbLName.Text);

            int aux = iBank.SearchIdClientByNumDoc(context, tbDocNum.Text);
            if (aux == 0)
            {
                MessageBox.Show("No se encontro el cliente");
            }

            tbIdForSearch.Text = aux.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AccountManagerDbContext context = new AccountManagerDbContext();

            int aux = iBank.SearchIdClientByNumDoc(context, textBox1.Text);
            if (aux == 0)
            {
                MessageBox.Show("No se encontro el cliente");
            }

            tbIdForSearch.Text = aux.ToString();

        }
    }
}
