using System;
using System.IO;
using System.Windows.Forms;

namespace BIT706_A3_OliverBerry
{
    public partial class ManageCustomersForm : ParentForm
    {
        public ManageCustomersForm()
        {
            InitializeComponent();
            DisplayAll();
        }

        // Display all customers
        private void DisplayAll()
        {
            lstAllCst.Items.Clear();
            foreach (Customer c in Ctrl.GetAllCustomers())
            {
                lstAllCst.Items.Add(c);
            }
            try
            {
                lstAllCst.SelectedIndex = 0;
            }
            catch (Exception) 
            {
                lbCstDetails.Text = "No customer data";
            }
        }

        // Find Button
        private void BtnFind_Click(object sender, EventArgs e)
        { 
            {
                int input;
                try
                {
                    input = Int32.Parse(tbFind.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid ID format!");
                    return;
                }

                if (input > 0) 
                {
                    try
                    {
                        Customer c = Ctrl.FindCustomerByID(input);
                        SetListBox(c);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
                else MessageBox.Show("Invalid ID format!");
            }
        }

        // Add Button
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.Show();
        }

        // Edit Button
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (lstAllCst.SelectedItem is null)
            {
                MessageBox.Show("No available selection");
            }
            else
            {
                try
                {
                    Customer c = Ctrl.FindCustomerByID(((Customer)lstAllCst.SelectedItem).ID);
                    {
                        this.Visible = false;
                        EditCustomerForm editCustomerForm = new EditCustomerForm(c);
                        editCustomerForm.Show();
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        // Delete Button
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (Ctrl.DeleteCustomer((Customer)lstAllCst.SelectedItem))
            {
                MessageBox.Show("Customer has been deleted");
                DisplayAll();
            }
            else MessageBox.Show("No available selection");
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }

        // set new list box value
        private bool SetListBox(Customer c)
        {
            for (int i = 0; i < (lstAllCst.Items.Count); i++)
            {
                if (c.ID == ((Customer)lstAllCst.Items[i]).ID)
                {
                    lstAllCst.SelectedIndex = i;
                    return true;
                }
            }
            // else something went wrong
            using StreamWriter w = File.AppendText("log.txt");
            w.WriteLine("Cannot set list box selection");
            return false;
        }
    }
}
