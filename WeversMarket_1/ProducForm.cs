using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
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
    public partial class ProducForm : Form
    {
        private void BtBack_Click(object sender, EventArgs e)
        {
            PrincipalMenu principalMenu = new PrincipalMenu();
            this.Hide();
            principalMenu.Show();
        }
    }
}
