using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsPilaApiUpload.Tab1;

namespace WindowsFormsPilaApiUpload
{
    public partial class FrmRibbon : Form
    {
        public Tab1_1 tab11 = new Tab1_1();
        public Tab1_2 tab12 = new Tab1_2();
        public FrmRibbon()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void FrmRibbon_Load(object sender, EventArgs e)
        {
            ribbon1.ActiveTab.Value = "ribbonTab3";
            
        }

        private void ribbonPanel1_Click(object sender, EventArgs e)
        {
            //IsMdiContainer = true;
            tab11.MdiParent = this;
            tab11.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tab11.Dock = DockStyle.Fill;
            


            tab11.Show();
            
            tab11.Activate();
        }

        private void ribbonPanel3_Click(object sender, EventArgs e)
        {
            tab12.MdiParent = this;
            tab12.Show();
           
            tab12.Activate();
        }

        private void ribbonPanel5_Click(object sender, EventArgs e)
        {
            //ribbonPanel5.Visible = false;
            //ribbonPanel2.Visible = false;
            //ribbonPanel4.Visible = false;
            //ribbonTab1.Visible = false;
            //ribbonTab2.Visible = false;
            //ribbonTab3.Visible = false;
            //ribbon1.SendToBack();
            ribbon1.Hide();
        }
    }
}
