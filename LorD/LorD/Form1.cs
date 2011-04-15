using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace LorD
{

    public partial class Form1 : Form
    {

        private Thread trd;
        private bool bTrdRun;

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            bTrdRun = false;
            trd = new Thread(new ThreadStart(this.ThreadTask));
            trd.IsBackground = true;
            trd.Start();
        }

        public void ThreadTask()
        {
            while (true)
            {
                if (bTrdRun == true)
                {
                    DelegateTxtChg();
                    Thread.Sleep(100);
                }
            }
        }

        private delegate void MyDelegateTxtChg();

        public void DelegateTxtChg()
        {
            this.BeginInvoke(new MyDelegateTxtChg(TxtChg));
        }

        private void TxtChg()
        {
            /* Change the text */
            if (lbChg.Text == "正")
            {
                lbChg.Text = "反";
            }
            else
            {
                lbChg.Text = "正";
            }
        }

        private void bnStart_Click(object sender, EventArgs e)
        {
            if (bnStart.Text == "开始")
            {
                bnStart.Text = "停止";
                bTrdRun = true;
            }
            else if (bnStart.Text == "停止")
            {
                bnStart.Text = "开始";
                bTrdRun = false;
            }
            else
            {
                /*debug*/
                ;
            }

        }

    }
}