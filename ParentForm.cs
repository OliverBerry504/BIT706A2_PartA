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
    }
}
