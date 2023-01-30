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

//https://medium.com/@t.masonbarneydev/iterating-asynchronously-how-to-use-async-await-with-foreach-in-c-d7e6d21f89fa

namespace WindowsFormsPilaApiUpload
{
    public partial class FormForeachAsync : Form
    {

        //string postURL = "http://intranetsrv/pilaapi/api/InsertJob";
        string postURL = "http://localhost:52610/api/InsertJob";
        string sPath = @"C:\Users\igarmendia\source\repos\WindowsFormsPilaApiUpload\cargarIntranet";
        public FormForeachAsync()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {


            string[] oFiles = Directory.GetFiles(sPath, "*");
            ////Get the path of specified file
            //file = openFileDialog1.FileName;
            //filename = file.Substring(file.LastIndexOf('\\') + 1);
            ////string emaitzaIgotakoa = igoHttpClientDemo(file, filename);
            ////label1.Text = emaitzaIgotakoa;
            //string emaitza = "";
            //try
            //{
            //    emaitza = await AsyncIgoHttpClientDemo(file, filename);
            //}
            //catch (Exception exx) { emaitza = exx.Message; }
            //label1.Text = emaitza;


            var progress = new Progress<string>(percent =>
            {
                textBox1.Text = percent + " subiendo";
            });



            string emaitza = "";
            
            List<Task<string>> listOfTasks = new List<Task<string>>();
            string[] emaitzak = new string[oFiles.Count()];
            try
            {
                //int i = 0;
                //foreach (var file in oFiles)
                //{
                //    string file1 = file;
                //    string filename = file.Substring(file.LastIndexOf('\\') + 1);
                //    listOfTasks.Add(AsyncIgoHttpClientDemo(file, filename, progress, i));
                //    Thread.Sleep(1000);


                //}
                //emaitzak=await Task.WhenAll<string>(listOfTasks);

                int i = 0;
                foreach (var file in oFiles)
                {

                    string file1 = file;
                    string filename = file.Substring(file.LastIndexOf('\\') + 1);
                    //listOfTasks.Add(AsyncIgoHttpClientDemo(file, filename));
                    emaitzak[i] = await AsyncIgoHttpClientDemo(file, filename, progress, i);
                    i++;
                }



            }
            catch (Exception exx) { emaitza = exx.Message; }

            label1.Text = emaitzak[0];
            label2.Text = emaitzak[1];
            label3.Text = emaitzak[2];
            label4.Text = emaitzak[3];
            label5.Text = emaitzak[4];
            label6.Text = emaitzak[5];

            textBox1.Text = "Done!";


        }


        public async Task<string> AsyncIgoHttpClientDemo(string file, string filename, IProgress<string> progress, int i)
        {
            //string postURL = "http://intranetsrv/pilaapi/api/InsertJob";
            //string postURL = "http://localhost:52610/api/InsertJob";


            if (progress != null)
            {
                progress.Report(filename);
            }



            string emaitza = "";

            FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
            byte[] data = new byte[fs.Length];
            fs.Read(data, 0, data.Length);
            fs.Close();



            FileStream fsa = new FileStream(@"C: \Users\igarmendia\source\repos\WindowsFormsPilaApiUpload\cargarIntranet\sync2.zip", FileMode.Open, FileAccess.Read);
            byte[] dataa = new byte[fsa.Length];
            fsa.Read(dataa, 0, dataa.Length);
            fsa.Close();



            //HttpContent stringContent = new StringContent(postParameters);
            HttpContent stringContent1 = new StringContent("12333123");
            HttpContent stringContent2 = new StringContent("5");
            HttpContent stringContent3 = new StringContent("oferta");
            HttpContent stringContent4 = new StringContent("a-20309795");
            //HttpContent fileStreamContent = new StreamContent(fs);
            HttpContent bytesContent = new ByteArrayContent(data);
            HttpContent bytesContenta = new ByteArrayContent(dataa);
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
                formData.Add(bytesContenta, "to_file", "to_filename");
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
            //if (label7.InvokeRequired)
            //{
                String name = emaitza;
                label7.Invoke(new MethodInvoker(delegate { label7.Text = name; }));
            //}
            return emaitza;

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string filePath= @"\\intranetsrv\datos\PilaApi\klientakinJeistia";
            string fileName = "klientakinJeistia.dxf";
            
            HttpResponseMessage response = await client.GetAsync("http://localhost:52610/Pila/GetBookForHRM/dxf");
            if (response.IsSuccessStatusCode)
            {
                var inputStream = await response.Content.ReadAsStreamAsync();

                string path = Path.Combine(filePath, fileName);
                using (FileStream outputFileStream = new FileStream(path, FileMode.Create))
                {
                    inputStream.CopyTo(outputFileStream);
                }
            }
            
        }
        //https://medium.com/@deep_blue_day/how-to-read-multipart-mime-data-from-httpresponsemessage-in-net-standard-9664904a7ca9
        private async void button3_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string filePath1 = @"\\intranetsrv\datos\PilaApi\klientakinJeistia";
            string fileName1 = "sample.pdf";

            string filePath2 = @"\\intranetsrv\datos\PilaApi\klientakinJeistia";
            string fileName2 = "sample.zip";


            HttpResponseMessage response = await client.GetAsync("http://localhost:52610/Pila/GetMulti");
            if (response.IsSuccessStatusCode)
            {
                var inputStream = await response.Content.ReadAsMultipartAsync();

                var streamContent0 = await inputStream.Contents[0].ReadAsStringAsync();
                var streamContent1 = await inputStream.Contents[1].ReadAsStreamAsync();
                var streamContent2 = await inputStream.Contents[2].ReadAsStreamAsync();

                string path1 = Path.Combine(filePath1, fileName1);
                using (FileStream outputFileStream = new FileStream(path1, FileMode.Create))
                {
                    streamContent1.CopyTo(outputFileStream);
                }

                string path2 = Path.Combine(filePath2, fileName2);
                using (FileStream outputFileStream = new FileStream(path2, FileMode.Create))
                {
                    streamContent2.CopyTo(outputFileStream);
                }



            }
        }
    }
}
