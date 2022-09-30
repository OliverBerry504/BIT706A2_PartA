using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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
            return false;
        }

        private void Btn_find_Click(object sender, EventArgs e)
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

        private void Btn_add_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.Show();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            if (lst_all_cust.SelectedItem is null)
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

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                CustCtrl.DeleteCustomer((Customer)lst_all_cust.SelectedItem);
                MessageBox.Show("Customer has been deleted");
                DisplayAll();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
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

        private void Btn_main_menu_Click(object sender, EventArgs e)
        {
            WriteData();
            this.Visible = false;
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }

        public void WriteData()
        {
            IFormatter formatter = new BinaryFormatter();

            Stream stream = new FileStream("objects.bin", FileMode.Create,
            FileAccess.Write, FileShare.None);

            formatter.Serialize(stream, AccCtrl.AllAccounts);
            formatter.Serialize(stream, CustCtrl.AllCustomers);
            formatter.Serialize(stream, CustIdData.GetInstance());
            formatter.Serialize(stream, AccIdData.GetInstance());

            stream.Close();
        }
    }
}
