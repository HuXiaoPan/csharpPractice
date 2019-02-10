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

namespace Threads
{
    delegate void threadEventHandle();
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            threadEventHandle testEvent1 = new threadEventHandle(test1);
            ThreadStart ts = new ThreadStart(testEvent1);
            Thread t1 = new Thread(ts);
            t1.Start();
        }

        private void test1 ()
        {
            for (int i = 0; i < 100000; i++)
            {
                this.labelT1.Text = "张飞" + i;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            threadEventHandle testEvent1 = new threadEventHandle(test2);
            ThreadStart ts = new ThreadStart(testEvent1);
            Thread t2 = new Thread(ts);
            t2.Start();
        }

        private void test2()
        {
            for (int i = 0; i < 100000; i++)
            {
                this.labelT2.Text = "关羽" + i*2;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            threadEventHandle testEvent1 = new threadEventHandle(test3);
            ThreadStart ts = new ThreadStart(test3);
            Thread t3 = new Thread(ts);
            t3.Start();
        }

        private void test3()
        {
            for (int i = 0; i < 100000; i++)
            {
                this.labelT3.Text = "赵云" + i *3;
            }
        }
    }
}
