using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trader
{
    public partial class AutoTrade2 : Form
    {

        protected virtual void OnClosed(EventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                AutoTrade win1 = new AutoTrade();
                win1.Close();
            }
        }


        public AutoTrade2()
        {
            InitializeComponent();
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void Head_Click(object sender, EventArgs e)
        {

        }

        private void AutoTrade2_Load(object sender, EventArgs e)
        {
        }

        public void login_Click(object sender, EventArgs e)
        {

        }
    }
}
