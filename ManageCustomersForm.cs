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
            lst_all_cust.Items.Clear();
            foreach (Customer c in CustCtrl.AllCustomers)
            {
                lst_all_cust.Items.Add(c);
            }
            try
            {
                lst_all_cust.SelectedIndex = 0;
            }
            catch (Exception) 
            {
                lb_cust_details.Text = "No customer data";
            }
        }

        // Find Button
        private void BtnFind_Click(object sender, EventArgs e)
        { 
            {
                int input;
                try
                {
                    input = Int32.Parse(tb_find.Text);
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
                        Customer c = CustCtrl.FindCustomerByID(input);
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
            if (lst_all_cust.SelectedItem is null)  // repeated again for manage accounts form
            {
                MessageBox.Show("No available selection");
            }
            else
            {
                try
                {
                    this.Visible = false;
                    EditCustomerForm editCustomerForm = new EditCustomerForm((Customer)lst_all_cust.SelectedItem);
                    editCustomerForm.Show();
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
            if (CustCtrl.DeleteCustomer((Customer)lst_all_cust.SelectedItem))
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
            for (int i = 0; i < (lst_all_cust.Items.Count); i++)
            {
                if (CustCtrl.GetCustomerID(c) == CustCtrl.GetCustomerID(((Customer)lst_all_cust.Items[i])))
                {
                    lst_all_cust.SelectedIndex = i;
                    return true;
                }
            }
            // else something went wrong
            using StreamWriter w = File.AppendText("log.txt");
            w.WriteLine("Cannot set list box selection");
            return false;
        }

        private void Btn_mng_accs_Click(object sender, EventArgs e)
        {
                try
                {
                    Customer c = (Customer)lst_all_cust.SelectedItem;
                    if (c != null)
                    {
                        this.Visible = false;
                        ManageAccountsForm form = new ManageAccountsForm(c);
                        form.Show();
                    }
                    else
                    {
                    MessageBox.Show("No available selection");
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

        }
    }
}
