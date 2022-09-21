using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BIT706_A3_OliverBerry
{
    public partial class MenuForm : ParentForm
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void Btn_mng_cst_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ManageCustomersForm form = new ManageCustomersForm();
            form.Show();
            form.Tag = this;
            form.Location = this.Location;
        }

        private void Btn_mng_accs_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ManageAccountsForm form = new ManageAccountsForm();
            form.Show();
            form.Tag = this;
            form.Location = this.Location;
        }
    }
}
