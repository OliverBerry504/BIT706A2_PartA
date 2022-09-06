﻿using System;using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BIT706_A2_OliverBerry_PartA
{
    public partial class EditCustomerForm : Form1
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (tbEdit.Text is null) 
            {
                // not completely necessary
                MessageBox.Show("Customer name left empty");
            }
            else if (Ctrl.EditCustomer(tbEdit.Text, Selected)) // success
            {
                MessageBox.Show("Customer has been edited");

                // return to 'Manage Customers' window
                this.Visible = false;
                ManageForm manageForm = new ManageForm();
                manageForm.Show();
            }
            else MessageBox.Show(Ctrl.ErrorMessage); // error
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ManageForm manageForm = new ManageForm();
            manageForm.Show();
        }
    }
}
