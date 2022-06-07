using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPilaApiUpload
{
    public partial class FrmNoChild : Form
    {
        //add a delegate
        public delegate void CloseHandler(object sender);
        //add an event of the delegate type
        public event CloseHandler CloseForm;

        public FrmNoChild()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            //form1.closeForm();
            CloseForm(this);
        }
    }
}
