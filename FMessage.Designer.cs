
namespace GuessMelody
{
    partial class FMessage
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
            this.LMessage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LTimer = new System.Windows.Forms.Label();
            this.LShowAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LMessage
            // 
            this.LMessage.AutoSize = true;
            this.LMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LMessage.Location = new System.Drawing.Point(97, 11);
            this.LMessage.Name = "LMessage";
            this.LMessage.Size = new System.Drawing.Size(0, 55);
            this.LMessage.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Да";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(212, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "Нет";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LTimer
            // 
            this.LTimer.AutoSize = true;
            this.LTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LTimer.Location = new System.Drawing.Point(167, 130);
            this.LTimer.Name = "LTimer";
            this.LTimer.Size = new System.Drawing.Size(31, 33);
            this.LTimer.TabIndex = 3;
            this.LTimer.Text = "0";
            // 
            // LShowAnswer
            // 
            this.LShowAnswer.AutoSize = true;
            this.LShowAnswer.Location = new System.Drawing.Point(61, 254);
            this.LShowAnswer.Name = "LShowAnswer";
            this.LShowAnswer.Size = new System.Drawing.Size(87, 13);
            this.LShowAnswer.TabIndex = 4;
            this.LShowAnswer.Text = "Показать ответ";
            this.LShowAnswer.Click += new System.EventHandler(this.LShowAnswer_Click);
            // 
            // FMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 382);
            this.Controls.Add(this.LShowAnswer);
            this.Controls.Add(this.LTimer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LMessage);
            this.Name = "FMessage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FMessage_FormClosed);
            this.Load += new System.EventHandler(this.FMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label LMessage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LTimer;
        private System.Windows.Forms.Label LShowAnswer;
    }
}