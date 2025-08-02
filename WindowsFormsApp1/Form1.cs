using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Mat inimg = new Mat();
        Mat outimg=new Mat();
        Mat v = new Mat();
        int a = 10;
        int b = 20;
        int res = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            addition();             
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void addition()
        {
            res = a + b;
          
        }
    }
}
