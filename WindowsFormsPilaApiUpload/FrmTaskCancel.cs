using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//https://geeks.ms/jorge/2017/09/22/usando-cancellationtoken-en-c/


namespace WindowsFormsPilaApiUpload
{
    public partial class FrmTaskCancel : Form
    {
        public  int counter = 0;

        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        //CancellationToken cancellationToken = cancellationTokenSource.Token;
        public FrmTaskCancel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Started");
            //Console.WriteLine();

            //CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;

            //Task task = Task.Run(() =>
            //{
            // while (!cancellationToken.IsCancellationRequested)
            // {
            // counter++;

            // Console.Write($"{counter}|");
            // Thread.Sleep(500);
            // }
            //}, cancellationToken);

            Task task = Task.Run(() => Process(cancellationToken));

            //Console.WriteLine("Press enter to stop the task");
            //Console.ReadLine();
            ////cancellationTokenSource.Cancel();
            //Console.WriteLine($"Task executed {counter} times");

            //Console.WriteLine();
            //Console.WriteLine("Press any key to close");
            //Console.ReadKey();
        }


        private void Process(CancellationToken cancellationToken)
        {
            while (true)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    return;
                }

                counter++;

                //Console.Write($"{counter}|");
                //label1.Text = counter+"";
                Thread.Sleep(500);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();
            label1.Text = counter + "";
        }
    }
}
