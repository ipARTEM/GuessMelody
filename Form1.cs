using System;
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
    public partial class FormMain : Form
    {
        FParam fParam = new FParam();
        FGame fGame = new FGame();

        public FormMain()
        {
            InitializeComponent();
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void BParams_Click(object sender, EventArgs e)
        {

              fParam.ShowDialog();
        }

        private void BPlay_Click(object sender, EventArgs e)
        {
            fGame.ShowDialog();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Victorina.ReadParam();
            Victorina.ReadMisic();

        }
    }
}
