using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BIT706_A3_OliverBerry
{
    public partial class SelectAccountForm : ParentForm
    {
        private Customer selected;

        internal Customer Selected { get => selected; set => selected = value; }

        public SelectAccountForm()
        {
            InitializeComponent();
        }

        internal SelectAccountForm(Customer c) : this()
        {
            Selected = c;
        }

        private void Btn_create_Click(object sender, EventArgs e)
        {
            if (rb_Everyday.Checked)
            {
                AccCtrl.CreateAccEveryday(Selected);
                MessageBox.Show("Everyday Account created");
            }
            else if (rb_Investment.Checked)
            {
                AccCtrl.CreateAccInvestment(Selected);
                MessageBox.Show("Investment Account created");
            }
            else if (rb_Omni.Checked)
            {
                AccCtrl.CreateAccOmni(Selected);
                MessageBox.Show("Omni Account created");
            }

            this.Visible = false;
            ManageAccountsForm form = new ManageAccountsForm(selected);
            form.Show();
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
