using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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
            ReadData();
            this.Visible = false;
            ManageCustomersForm form = new ManageCustomersForm();
            form.Show();
        }

        public void ReadData()
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("Objects.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                AccCtrl.AllAccounts = (List<Account>)formatter.Deserialize(stream);
                CustCtrl.AllCustomers = (List<Customer>)formatter.Deserialize(stream);
                CustIdData.SetInstance((CustIdData)formatter.Deserialize(stream));
                AccIdData.SetInstance((AccIdData)formatter.Deserialize(stream));

                stream.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading data..");
            }
        }
    }
}
