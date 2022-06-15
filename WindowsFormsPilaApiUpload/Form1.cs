using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsPilaApiUpload
{
    public partial class Form1 : Form
    {

        FrmOpen frm_2 = new FrmOpen();
        string file = @"C:\Users\igarmendia.LASER\Desktop\PilaTask\winrar4.rar";
        string filename = "winrar4.rar";
        string postURL = "http://intranetsrv/pilaapi/api/InsertJob";
        //string postURL = "http://localhost:52610/api/InsertJob";
        public Form1()
        {
            InitializeComponent();
            FrmNoChild frmNoChild = new FrmNoChild();
            frmNoChild.CloseForm += FrmNoChild_CloseForm;
            frmNoChild.Show();
            Screen[] sMonitores;
            sMonitores = Screen.AllScreens;
            int NumMonitoresFuncionando = sMonitores.Count();
            if (NumMonitoresFuncionando > 1)
            {
                //https://stackoverflow.com/questions/1363374/showing-a-windows-form-on-a-secondary-monitor
                //setting WindowStartUpLocation parameter as "manual" inside your SetFormLocation
                this.StartPosition = FormStartPosition.Manual; 
                this.Left = sMonitores[1].Bounds.Left;
                this.Top = sMonitores[1].Bounds.Top;
                //this.WindowState = FormWindowState.Maximized;
                frmNoChild.Left = sMonitores[1].Bounds.Left;
            }
            //frm_2.Show();
            frmNoChild.Show();
            
        }

        private void FrmNoChild_CloseForm(object sender)
        {
            closeForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //file = @"C:\Users\igarmendia.LASER\Desktop\PilaTask\winrar4.rar";
            //filename = @"C:\Users\igarmendia.LASER\Desktop\PilaTask\winrar4.rar";
            igoHttpClientDemo(file, filename);
        }


        public string igoHttpClientDemo(string file, string filename)
        {
            //string postURL = "http://intranetsrv/pilaapi/api/InsertJob";
            //string postURL = "http://localhost:52610/api/InsertJob";

            
            string emaitza = "";

            FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
            byte[] data = new byte[fs.Length];
            fs.Read(data, 0, data.Length);
            fs.Close();


            //HttpContent stringContent = new StringContent(postParameters);
            HttpContent stringContent1 = new StringContent("12333123");
            HttpContent stringContent2 = new StringContent("5");
            HttpContent stringContent3 = new StringContent("oferta");
            HttpContent stringContent4 = new StringContent("a-20309795");
            //HttpContent fileStreamContent = new StreamContent(fs);
            HttpContent bytesContent = new ByteArrayContent(data);
            using (var client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            {
                formData.Add(stringContent1, "productId");
                formData.Add(stringContent2, "jobType");
                formData.Add(stringContent3, "description");
                formData.Add(stringContent4, "cif");
                //formData.Add(fileStreamContent, file, filename);
                formData.Add(bytesContent, file, filename);
                var response = client.PostAsync(postURL, formData);
                response.Wait();

                var result = response.Result;
                //if (result.IsSuccessStatusCode)
                //{

                var readTask = result.Content.ReadAsStringAsync();
                readTask.Wait();

                emaitza = readTask.Result;


                //// Creating BlogSites object  
                //Erantzuna bsObj = new Erantzuna()
                //{
                //    error = "C-sharpcorner",
                //    emaitza = "Share Knowledge"
                //};
                //Erantzuna bsObj = JsonConvert.DeserializeObject<Erantzuna>(emaitza);


                //}
                //else
                //{
                //    Console.WriteLine(result.StatusCode);
                //}
            }





            //using (var klient = new HttpClient())
            //{
            //    var postTask = klient.PostAsync(postURL, content);
            //    postTask.Wait();

            //    var result = postTask.Result;
            //    if (result.IsSuccessStatusCode)
            //    {

            //        var readTask = result.Content.ReadAsStringAsync();
            //        readTask.Wait();

            //         emaitza = readTask.Result;


            //    }
            //    else
            //    {
            //        Console.WriteLine(result.StatusCode);
            //    }
            //}
            
            return emaitza;

        }


        public async Task<string> AsyncIgoHttpClientDemo(string file, string filename)
        {
            //string postURL = "http://intranetsrv/pilaapi/api/InsertJob";
            //string postURL = "http://localhost:52610/api/InsertJob";


            string emaitza = "";

            FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
            byte[] data = new byte[fs.Length];
            fs.Read(data, 0, data.Length);
            fs.Close();


            //HttpContent stringContent = new StringContent(postParameters);
            HttpContent stringContent1 = new StringContent("12333123");
            HttpContent stringContent2 = new StringContent("5");
            HttpContent stringContent3 = new StringContent("oferta");
            HttpContent stringContent4 = new StringContent("a-20309795");
            //HttpContent fileStreamContent = new StreamContent(fs);
            HttpContent bytesContent = new ByteArrayContent(data);
            //var response=null;
            using (var client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            {
                formData.Add(stringContent1, "productId");
                formData.Add(stringContent2, "jobType");
                formData.Add(stringContent3, "description");
                formData.Add(stringContent4, "cif");
                //formData.Add(fileStreamContent, file, filename);
                formData.Add(bytesContent, file, filename);
                var response = await client.PostAsync(postURL, formData);
                //response.Wait();

                //var result = response.Result;
                //if (result.IsSuccessStatusCode)
                //{

                //var readTask = await result.Content.ReadAsStringAsync();
                //readTask.Wait();

                //emaitza = readTask.Result;
                //var readTask = response.Content.ReadAsStringAsync();
                //readTask.Wait();
                //emaitza = readTask.Result;

                emaitza = await response.Content.ReadAsStringAsync();

                //// Creating BlogSites object  
                //Erantzuna bsObj = new Erantzuna()
                //{
                //    error = "C-sharpcorner",
                //    emaitza = "Share Knowledge"
                //};
                //Erantzuna bsObj = JsonConvert.DeserializeObject<Erantzuna>(emaitza);


                //}
                //else
                //{
                //    Console.WriteLine(result.StatusCode);
                //}
            }





            //using (var klient = new HttpClient())
            //{
            //    var postTask = klient.PostAsync(postURL, content);
            //    postTask.Wait();

            //    var result = postTask.Result;
            //    if (result.IsSuccessStatusCode)
            //    {

            //        var readTask = result.Content.ReadAsStringAsync();
            //        readTask.Wait();

            //         emaitza = readTask.Result;


            //    }
            //    else
            //    {
            //        Console.WriteLine(result.StatusCode);
            //    }
            //}

            return emaitza;

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                file = openFileDialog1.FileName;
                filename= file.Substring(file.LastIndexOf('\\') + 1);
                //string emaitzaIgotakoa = igoHttpClientDemo(file, filename);
                //label1.Text = emaitzaIgotakoa;
                string emaitza = "";
                try { 
                emaitza = await AsyncIgoHttpClientDemo(file, filename);
                }
                catch(Exception exx) { emaitza = exx.Message; }
                label1.Text = emaitza;


            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            Thread.Sleep(10000);
        }

        private async void btnAsync_Click(object sender, EventArgs e)
        {
            await denboraPasa();
            //string emaitza=await AsyncIgoHttpClientDemo(file, filename);
            //label1.Text = emaitza;
            label1.Text = "denboraPasa bulatu da";
        }

        private async Task  denboraPasa()
        {
            await Task.Delay(10000);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "await dagoen bitartean idazten jarraitu";
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            var bat = Looo1();
            var bi =  Looo2();
            //bat.Start();
            //bi.Start();
            await Task.WhenAll(bat, bi);
            label3.Text = "bukatu";


        }

        private async Task<int> Looo1()
        {
            await Task.Delay(5000);
            label4.Text = "loop1";
            return 1;
        }
        private async Task<int> Looo2()
        {
            await Task.Delay(5000);
            label5.Text = "loop2";
            return 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var taskaa = Taska1NoSync();
            taskaa.Start();
            //string done = await taskaa;
            //taska.Start();
            if (label6.Text == "jo")
                label6.Text = "jo jo";
            else
                label6.Text = "jo";
        }

        private Task Taska1NoSync()
        {
            //label6.Text = "joa barrun";
            //Thread.Sleep(10000);
            if (label7.Text == "barrun")
                label7.Text = "barrun barrun";
            else
                label7.Text = "barrun";
            
            return new Task(() =>
            {
                Thread.Sleep(10000);
                //if(label6.Text=="jo")
                //    label6.Text = "joa bukatua";
                //else if(label6.Text == "jo bukatua")
                    //label6.Text = "joa barrun";
            });

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //IsMdiContainer = true;
            //frm_2.Show();
            //frm_2.MdiParent = this;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //frm_2.Close();
            closeForm();
        }

        public void closeForm()
        {
            frm_2.Close();
            frm_2.closeform2();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //frm_2.Show();
            var task = openForm2();
            task.Start();
        }
        private Task openForm2()
        {
            return new Task(() =>
            {
                frm_2.Show();
            });
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string path1 = @"C:\Activa\EditionFiles\test.pdf";
            string path2 = @"C:\Activa\EditionFiles\testberria.pdf"; ;

            //FileStream inf = new FileStream(path1, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            //FileStream outf = new FileStream(path2, FileMode.Create);
            //int a;
            //while ((a = inf.ReadByte()) != -1)
            //{
            //    outf.WriteByte((byte)a);
            //}
            //inf.Close();
            //inf.Dispose();
            //outf.Close();
            //outf.Dispose();
            File.Copy(path1, path2);
        }

        private void button9_Click(object sender, EventArgs e)
        {

            //https://jefferytay.wordpress.com/2015/02/26/deleting-file-to-recycle-bin-using-c/
            string path = @"C:\Automatismos-Aplicaciones\EditionVersions\EditionRunningBranchMail\oferta\testBerria.pdf";
            //FileIO.FileSystem.DeleteDirectory(path,FileIO.UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
            Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(path, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var taskaa = bindFileInformation();
            taskaa.Start();
            taskaa.Wait();
            label8.Text = "ea noiz idazten duen. Wait jarririk bukaeraraino itxaroten du. Aplikazio guzia gelditurik.";
        }

        private Task bindFileInformation()
        {
            return new Task(() =>
            {
                Thread.Sleep(10000);
            });
        }
    }

    public class Erantzuna
    {
 

        public string error { get; set; }
        public string message { get; set; }
    }

}
