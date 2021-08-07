﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMelody
{
    public partial class FGame : Form
    {
        Random random = new Random();
        public FGame()
        {
            InitializeComponent();
        }

        void MakeMusic()
        {

            int n = random.Next(0, Victorina.list.Count);
            WMP.URL = Victorina.list[n];
            //WMP.Ctlcontrols.play();
            Victorina.list.RemoveAt(n);

        }

        private void BNext_Click(object sender, EventArgs e)
        {
            MakeMusic();

        }

        private void FGame_Load(object sender, EventArgs e)
        {

        }

        private void FGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            WMP.Ctlcontrols.stop();
        }
    }
}
