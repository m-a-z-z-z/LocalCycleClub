﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalCycleClub
{
    public partial class Form1 : Form
    {
        Member member;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAddActivities_Click(object sender, EventArgs e)
        {
            ActivitiesForm info = new ActivitiesForm();
            info.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
