using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIT706_A3_OliverBerry
{
    public partial class ParentForm : Form
    {
        private static Controller ctrl = new Controller();
        internal Controller Ctrl { get => ctrl; set => ctrl = value; }
        public ParentForm()
        {
            InitializeComponent();
        }
    }
}
