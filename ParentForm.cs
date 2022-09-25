using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace BIT706_A3_OliverBerry
{
    public partial class ParentForm : Form
    {
        private static CustController custCtrl = new CustController();
        private static AccController accCtrl = new AccController();
        internal CustController CustCtrl { get => custCtrl; set => custCtrl = value; }
        internal AccController AccCtrl { get => accCtrl; set => accCtrl = value; }
        public ParentForm()
        {
            InitializeComponent();
        }

        public void WriteData()
        {   
            //create a formatting object
            IFormatter formatter = new BinaryFormatter();

            //Create a new IO stream to write to the file Objects.bin
            Stream stream = new FileStream("objects.bin", FileMode.Create,
            FileAccess.Write, FileShare.None);

            //use the formatter to serialize the collection and send it to the filestream
            formatter.Serialize(stream, AccCtrl.AllAccounts);
            formatter.Serialize(stream, CustCtrl.AllCustomers);
            formatter.Serialize(stream, CustIdData.GetInstance());
            formatter.Serialize(stream, AccIdData.GetInstance());


            //close the file
            stream.Close();
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
                // do seomthing
            }
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            WriteData();
        }

        private void Btn_load_Click(object sender, EventArgs e)
        {
            ReadData();
            this.Visible = false;
            ManageCustomersForm form = new ManageCustomersForm();
            form.Show();
        }
    }
}
