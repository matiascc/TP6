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

namespace Ej2_Interfaz
{
    public partial class AdmClient : Form
    {
        public AdmClient(int pClientId)
        {
            InitializeComponent();

            Bank iBank = new Bank();

            foreach (var item in iBank.GetClientAccounts(pClientId))
            {
                cbAccounts.Items.Add(item);
            }
        }

        private void AdmClient_Load(object sender, EventArgs e)
        {
            
        }
    }
}
