using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeversMarket_1
{
    public partial class PrincipalMenu : Form
    {
        public PrincipalMenu()
        {
            InitializeComponent();
        }

        private void BtProduc_Click(object sender, EventArgs e)
        {
          ProducForm producForm = new ProducForm();
          this.Hide();
          producForm.Show();

        }
    }
}
