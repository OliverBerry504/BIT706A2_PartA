using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BIT706_A2_OliverBerry_PartA
{
    public partial class MenuForm : Form1
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void Btn_mng_cst_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ManageForm manageForm = new ManageForm();
            manageForm.Show();
            manageForm.Tag = this;
            manageForm.Location = this.Location;
        }
    }
}
