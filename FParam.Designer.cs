
namespace GuessMelody
{
    partial class FParam
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BSelectFolder = new System.Windows.Forms.Button();
            this.BClearList = new System.Windows.Forms.Button();
            this.CBAllDirectory = new System.Windows.Forms.CheckBox();
            this.BOK = new System.Windows.Forms.Button();
            this.BCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBGameDuration = new System.Windows.Forms.ComboBox();
            this.CBMusicDuration = new System.Windows.Forms.ComboBox();
            this.CBRandomStart = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(-1, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(802, 225);
            this.listBox1.TabIndex = 0;
            // 
            // BSelectFolder
            // 
            this.BSelectFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BSelectFolder.Location = new System.Drawing.Point(10, 244);
            this.BSelectFolder.Name = "BSelectFolder";
            this.BSelectFolder.Size = new System.Drawing.Size(158, 38);
            this.BSelectFolder.TabIndex = 1;
            this.BSelectFolder.Text = "Выбрать папку";
            this.BSelectFolder.UseVisualStyleBackColor = true;
            this.BSelectFolder.Click += new System.EventHandler(this.BSelectFolder_Click);
            // 
            // BClearList
            // 
            this.BClearList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BClearList.Location = new System.Drawing.Point(218, 244);
            this.BClearList.Name = "BClearList";
            this.BClearList.Size = new System.Drawing.Size(130, 38);
            this.BClearList.TabIndex = 2;
            this.BClearList.Text = "Очистить список";
            this.BClearList.UseVisualStyleBackColor = true;
            // 
            // CBAllDirectory
            // 
            this.CBAllDirectory.AutoSize = true;
            this.CBAllDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBAllDirectory.Location = new System.Drawing.Point(560, 244);
            this.CBAllDirectory.Name = "CBAllDirectory";
            this.CBAllDirectory.Size = new System.Drawing.Size(190, 28);
            this.CBAllDirectory.TabIndex = 3;
            this.CBAllDirectory.Text = "Вложенные папки";
            this.CBAllDirectory.UseVisualStyleBackColor = true;
            // 
            // BOK
            // 
            this.BOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BOK.Location = new System.Drawing.Point(499, 393);
            this.BOK.Name = "BOK";
            this.BOK.Size = new System.Drawing.Size(118, 33);
            this.BOK.TabIndex = 4;
            this.BOK.Text = "ОК";
            this.BOK.UseVisualStyleBackColor = true;
            this.BOK.Click += new System.EventHandler(this.BOK_Click);
            // 
            // BCancel
            // 
            this.BCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BCancel.Location = new System.Drawing.Point(650, 393);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(138, 32);
            this.BCancel.TabIndex = 5;
            this.BCancel.Text = "Отмена";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CBRandomStart);
            this.groupBox1.Controls.Add(this.CBMusicDuration);
            this.groupBox1.Controls.Add(this.CBGameDuration);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 140);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки игры";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Продолжительность игры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Время на ответ";
            // 
            // CBGameDuration
            // 
            this.CBGameDuration.FormattingEnabled = true;
            this.CBGameDuration.Items.AddRange(new object[] {
            "30",
            "45",
            "60",
            "75",
            "90",
            "105",
            "120"});
            this.CBGameDuration.Location = new System.Drawing.Point(179, 29);
            this.CBGameDuration.Name = "CBGameDuration";
            this.CBGameDuration.Size = new System.Drawing.Size(49, 21);
            this.CBGameDuration.TabIndex = 2;
            this.CBGameDuration.Text = "30";
            // 
            // CBMusicDuration
            // 
            this.CBMusicDuration.FormattingEnabled = true;
            this.CBMusicDuration.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35"});
            this.CBMusicDuration.Location = new System.Drawing.Point(179, 63);
            this.CBMusicDuration.Name = "CBMusicDuration";
            this.CBMusicDuration.Size = new System.Drawing.Size(49, 21);
            this.CBMusicDuration.TabIndex = 3;
            this.CBMusicDuration.Text = "25";
            // 
            // CBRandomStart
            // 
            this.CBRandomStart.AutoSize = true;
            this.CBRandomStart.Location = new System.Drawing.Point(19, 95);
            this.CBRandomStart.Name = "CBRandomStart";
            this.CBRandomStart.Size = new System.Drawing.Size(133, 17);
            this.CBRandomStart.TabIndex = 4;
            this.CBRandomStart.Text = "Со случайного места";
            this.CBRandomStart.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Игрок 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Игрок 2";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(354, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(42, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "A";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(425, 45);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(42, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.Text = "L";
            // 
            // FParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BOK);
            this.Controls.Add(this.CBAllDirectory);
            this.Controls.Add(this.BClearList);
            this.Controls.Add(this.BSelectFolder);
            this.Controls.Add(this.listBox1);
            this.Name = "FParam";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.FParam_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BSelectFolder;
        private System.Windows.Forms.Button BClearList;
        private System.Windows.Forms.CheckBox CBAllDirectory;
        private System.Windows.Forms.Button BOK;
        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBMusicDuration;
        private System.Windows.Forms.ComboBox CBGameDuration;
        private System.Windows.Forms.CheckBox CBRandomStart;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}