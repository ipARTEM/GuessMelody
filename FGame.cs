using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace GuessMelody
{
    public partial class FGame : Form
    {
        Random random = new Random();

        int musicDuration=Victorina.musicDuration;

        bool[] players = new bool[2];

        public FGame()
        {
            InitializeComponent();
        }

        void MakeMusic()
        {
            if (Victorina.list.Count == 0) EndGame();
            else
            {
                musicDuration = Victorina.musicDuration;

                int n = random.Next(0, Victorina.list.Count);
                WMP.URL = Victorina.list[n];
                Victorina.answer = Path.GetFileNameWithoutExtension(WMP.URL);
                //WMP.Ctlcontrols.play();
                Victorina.list.RemoveAt(n);
                LMelodyCount.Text = Victorina.list.Count.ToString();
                players[0] = false;
                players[1] = false;
            }

        }

        private void BNext_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MakeMusic();

        }

        private void FGame_Load(object sender, EventArgs e)
        {
            LMelodyCount.Text = Victorina.list.Count.ToString();
            progressBar1.Value = 0;
            progressBar1.Maximum = 0;
            progressBar1.Maximum = Victorina.gameDuration;
            LMusicDuration.Text = musicDuration.ToString();

        }

        private void FGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }

        void EndGame()
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            musicDuration--;

            LMusicDuration.Text = musicDuration.ToString();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                EndGame();
                return;
            }
            if (musicDuration == 0) MakeMusic();

        }

        private void BPause_Click(object sender, EventArgs e)
        {
            GamePause();

        }

        private void BContinue_Click(object sender, EventArgs e)
        {
            GamePlay();
        }

        void GamePause()
        {
            timer1.Stop();
            WMP.Ctlcontrols.pause();
        }

        void GamePlay()
        {
            timer1.Start();
            WMP.Ctlcontrols.play();

        }

        private void FGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (!timer1.Enabled) return;
            if (players[0]==false&& e.KeyData==Keys.A)
            {
                GamePause();

                FMessage fm = new FMessage();
                fm.LMessage.Text = "Игрок 1";
                SoundPlayer soundPlayer = new SoundPlayer("Resources\\1.wav");
                soundPlayer.PlaySync();
                players[0] = true;
                if (fm.ShowDialog()==DialogResult.Yes)
                {
                    LCounter1.Text = Convert.ToString(Convert.ToInt32(LCounter1.Text) + 1);
                    MakeMusic();

                }
                GamePlay();
            }

            if (players[1]==false&& e.KeyData == Keys.L)
            {
                GamePause();
                FMessage fm = new FMessage();
                fm.LMessage.Text = "Игрок 2";
                SoundPlayer soundPlayer = new SoundPlayer("Resources\\2.wav");
                soundPlayer.PlaySync();
                players[1] = true;
                if (fm.ShowDialog() == DialogResult.Yes)
                {
                    LCounter2.Text = Convert.ToString(Convert.ToInt32(LCounter2.Text) + 1);
                    MakeMusic();

                }
                GamePlay();
            }
        }

        private void WMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Victorina.randomStart)
                if (WMP.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                {
                    WMP.Ctlcontrols.currentPosition = random.Next(0, (int)WMP.currentMedia.duration - 20);

                }

        }

        private void FGame_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void LCounter1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
                (sender as Label).Text = Convert.ToString(Convert.ToInt32((sender as Label).Text) + 1);

            if (e.Button == MouseButtons.Right)
                (sender as Label).Text = Convert.ToString(Convert.ToInt32((sender as Label).Text) -1);

        }
    }
}
