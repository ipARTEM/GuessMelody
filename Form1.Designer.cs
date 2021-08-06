
namespace GuessMelody
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BPlay = new System.Windows.Forms.Button();
            this.BParams = new System.Windows.Forms.Button();
            this.BExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BPlay
            // 
            this.BPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BPlay.Location = new System.Drawing.Point(139, 93);
            this.BPlay.Name = "BPlay";
            this.BPlay.Size = new System.Drawing.Size(495, 66);
            this.BPlay.TabIndex = 0;
            this.BPlay.Text = "Игра";
            this.BPlay.UseVisualStyleBackColor = true;
            // 
            // BParams
            // 
            this.BParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BParams.Location = new System.Drawing.Point(139, 181);
            this.BParams.Name = "BParams";
            this.BParams.Size = new System.Drawing.Size(495, 66);
            this.BParams.TabIndex = 1;
            this.BParams.Text = "Настройки";
            this.BParams.UseVisualStyleBackColor = true;
            // 
            // BExit
            // 
            this.BExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BExit.Location = new System.Drawing.Point(139, 269);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(495, 66);
            this.BExit.TabIndex = 2;
            this.BExit.Text = "Выход";
            this.BExit.UseVisualStyleBackColor = true;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.BParams);
            this.Controls.Add(this.BPlay);
            this.Name = "FormMain";
            this.Text = "Угадай мелодию";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BPlay;
        private System.Windows.Forms.Button BParams;
        private System.Windows.Forms.Button BExit;
    }
}

