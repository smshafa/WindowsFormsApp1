﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Car car = new Car("H", 4);
            MessageBox.Show(car.Name + car.NumDoor);

        }
    }
}
