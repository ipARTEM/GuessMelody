
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
            this.BOK.Location = new System.Drawing.Point(397, 393);
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
            this.BCancel.Location = new System.Drawing.Point(560, 393);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(138, 32);
            this.BCancel.TabIndex = 5;
            this.BCancel.Text = "Отмена";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // FParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BOK);
            this.Controls.Add(this.CBAllDirectory);
            this.Controls.Add(this.BClearList);
            this.Controls.Add(this.BSelectFolder);
            this.Controls.Add(this.listBox1);
            this.Name = "FParam";
            this.Text = "Настройки";
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
    }
}