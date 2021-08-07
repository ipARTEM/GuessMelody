using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GuessMelody
{
    public partial class FParam : Form
    {
        public FParam()
        {
            InitializeComponent();
        }

        private void BOK_Click(object sender, EventArgs e)
        {
            Victorina.allDirectories = CBAllDirectory.Checked;
            Victorina.gameDuration = Convert.ToInt32(CBGameDuration.Text);
            Victorina.musicDuration = Convert.ToInt32(CBMusicDuration.Text);
            Victorina.randomStart = CBRandomStart.Checked;
            Victorina.WriteParam();
            this.Hide();

        }

       

        private void BSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                string[] music_list = Directory.GetFiles(fbd.SelectedPath, "*.mp3",CBAllDirectory.Checked?SearchOption.AllDirectories:SearchOption.TopDirectoryOnly);
                Victorina.lastFolder = fbd.SelectedPath;
                listBox1.Items.Clear();
                listBox1.Items.AddRange(music_list);
                Victorina.list.Clear();
                Victorina.list.AddRange(music_list);
            }

        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            Set();
            
            this.Hide();
        }

        void Set()
        {
            CBAllDirectory.Checked = Victorina.allDirectories;
            CBGameDuration.Text = Victorina.gameDuration.ToString();
            CBMusicDuration.Text = Victorina.musicDuration.ToString();
            CBRandomStart.Checked = Victorina.randomStart;

        }

        private void FParam_Load(object sender, EventArgs e)
        {
            Set();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(Victorina.list.ToArray());

        }
    }
}
