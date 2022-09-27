using System;using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BIT706_A3_OliverBerry
{
    public partial class EditCustomerForm : ParentForm
    {
        private Customer selected;

        internal Customer Selected { get => selected; set => selected = value; }

        public EditCustomerForm()
        {
            InitializeComponent();
        }

        internal EditCustomerForm(Customer c) : this()
        {
            Selected = c;
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                CustCtrl.EditCustomer(tb_edit.Text, Selected);
                MessageBox.Show("Customer has been edited");

                // return to 'Manage Customers' window
                this.Visible = false;
                ManageCustomersForm form = new ManageCustomersForm();
                form.Show();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Btn_return_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ManageCustomersForm form = new ManageCustomersForm();
            form.Show();
        }
    }
}
