﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vothanhtrong2121110273;


namespace vothanhtrong2121110273_buoi1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 objForm1 = new Form1();
            objForm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 objForm2 = new Form2();
            objForm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 objForm3 = new Form3();
            objForm3.ShowDialog();
        }
    }
}
