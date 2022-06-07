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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string path1 = @"C:\Automatismos-Aplicaciones\EditionVersions\EditionRunningBranchMail\oferta\test.pdf";
            webBrowser1.Navigate(path1);
        }
    }
}
