
namespace GuessMelody
{
    partial class FGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGame));
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LCounter1 = new System.Windows.Forms.Label();
            this.LCounter2 = new System.Windows.Forms.Label();
            this.BPause = new System.Windows.Forms.Button();
            this.BContinue = new System.Windows.Forms.Button();
            this.LMelodyCount = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LMusicDuration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(185, 425);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(28, 25);
            this.WMP.TabIndex = 0;
            this.WMP.Visible = false;
            this.WMP.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.WMP_OpenStateChange);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(122, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Следующая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Игрок 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(574, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Игрок 2";
            // 
            // LCounter1
            // 
            this.LCounter1.AutoSize = true;
            this.LCounter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LCounter1.Location = new System.Drawing.Point(69, 68);
            this.LCounter1.Name = "LCounter1";
            this.LCounter1.Size = new System.Drawing.Size(29, 31);
            this.LCounter1.TabIndex = 4;
            this.LCounter1.Text = "0";
            this.LCounter1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LCounter1_MouseClick);
            // 
            // LCounter2
            // 
            this.LCounter2.AutoSize = true;
            this.LCounter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LCounter2.Location = new System.Drawing.Point(617, 68);
            this.LCounter2.Name = "LCounter2";
            this.LCounter2.Size = new System.Drawing.Size(29, 31);
            this.LCounter2.TabIndex = 5;
            this.LCounter2.Text = "0";
            this.LCounter2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LCounter1_MouseClick);
            // 
            // BPause
            // 
            this.BPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BPause.Location = new System.Drawing.Point(283, 323);
            this.BPause.Name = "BPause";
            this.BPause.Size = new System.Drawing.Size(141, 57);
            this.BPause.TabIndex = 6;
            this.BPause.Text = "Пауза";
            this.BPause.UseVisualStyleBackColor = true;
            this.BPause.Click += new System.EventHandler(this.BPause_Click);
            // 
            // BContinue
            // 
            this.BContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BContinue.Location = new System.Drawing.Point(451, 323);
            this.BContinue.Name = "BContinue";
            this.BContinue.Size = new System.Drawing.Size(141, 57);
            this.BContinue.TabIndex = 7;
            this.BContinue.Text = "Продолжить";
            this.BContinue.UseVisualStyleBackColor = true;
            this.BContinue.Click += new System.EventHandler(this.BContinue_Click);
            // 
            // LMelodyCount
            // 
            this.LMelodyCount.AutoSize = true;
            this.LMelodyCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LMelodyCount.Location = new System.Drawing.Point(317, 159);
            this.LMelodyCount.Name = "LMelodyCount";
            this.LMelodyCount.Size = new System.Drawing.Size(64, 24);
            this.LMelodyCount.TabIndex = 8;
            this.LMelodyCount.Text = "Старт";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 272);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LMusicDuration
            // 
            this.LMusicDuration.AutoSize = true;
            this.LMusicDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LMusicDuration.Location = new System.Drawing.Point(321, 68);
            this.LMusicDuration.Name = "LMusicDuration";
            this.LMusicDuration.Size = new System.Drawing.Size(20, 24);
            this.LMusicDuration.TabIndex = 10;
            this.LMusicDuration.Text = "0";
            // 
            // FGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LMusicDuration);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.LMelodyCount);
            this.Controls.Add(this.BContinue);
            this.Controls.Add(this.BPause);
            this.Controls.Add(this.LCounter2);
            this.Controls.Add(this.LCounter1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WMP);
            this.KeyPreview = true;
            this.Name = "FGame";
            this.Text = "Игра";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FGame_FormClosed);
            this.Load += new System.EventHandler(this.FGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FGame_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FGame_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LCounter1;
        private System.Windows.Forms.Label LCounter2;
        private System.Windows.Forms.Button BPause;
        private System.Windows.Forms.Button BContinue;
        private System.Windows.Forms.Label LMelodyCount;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LMusicDuration;
    }
}