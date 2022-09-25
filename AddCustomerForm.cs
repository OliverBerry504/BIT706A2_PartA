using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BIT706_A3_OliverBerry
{
    public partial class AddCustomerForm : ParentForm
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (CustCtrl.CreateCustomer(tbAdd.Text))
            {
                MessageBox.Show("Customer has been added");

                // return to 'Manage Customers' window
                this.Visible = false;
                ManageCustomersForm manageForm = new ManageCustomersForm();
                manageForm.Show();
            }
            else
            {
                MessageBox.Show(CustCtrl.ErrorMessage);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ManageCustomersForm form = new ManageCustomersForm();
            form.Show();
        }
    }
}
