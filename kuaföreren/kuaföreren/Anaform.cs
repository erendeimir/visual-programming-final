﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kuaföreren
{
    public partial class Anaform : Form
    {
        public Anaform()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void Anaform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Giriş grs = new Giriş();
                grs.Show();
                this.Hide();
        }

        private void Anaform_Load(object sender, EventArgs e)
        {

        }
    }
}
