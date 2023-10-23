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

namespace FrmBasicThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("- Thread Start -");

            Thread ThreadA = new Thread(MyThreadClass.Thread1);
            Thread ThreadB = new Thread(MyThreadClass.Thread2);
            Thread ThreadC = new Thread(MyThreadClass.Thread1);
            Thread ThreadD = new Thread(MyThreadClass.Thread2);

            ThreadA.Priority = ThreadPriority.Highest;
            ThreadA.Name = "Thread A Process";
            ThreadB.Priority = ThreadPriority.Normal;
            ThreadB.Name = "Thread B Process";
            ThreadC.Priority = ThreadPriority.AboveNormal;
            ThreadC.Name = "Thread C Process";
            ThreadD.Priority = ThreadPriority.BelowNormal;
            ThreadD.Name = "Thread D Process";

            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            ThreadD.Start();

            ThreadA.Join();
            ThreadB.Join();
            ThreadC.Join();
            ThreadD.Join();

            Console.WriteLine("- End Thread -");
            label1.Text = "- End Thread -";
        }
    }
}