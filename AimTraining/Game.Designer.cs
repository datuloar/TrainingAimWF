namespace AimTraining
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.UserScoreLabel = new System.Windows.Forms.Label();
            this.Mode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // UserScoreLabel
            // 
            this.UserScoreLabel.AutoSize = true;
            this.UserScoreLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.UserScoreLabel.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserScoreLabel.Location = new System.Drawing.Point(813, 23);
            this.UserScoreLabel.Name = "UserScoreLabel";
            this.UserScoreLabel.Size = new System.Drawing.Size(21, 23);
            this.UserScoreLabel.TabIndex = 0;
            this.UserScoreLabel.Text = "0";
            // 
            // Mode
            // 
            this.Mode.AutoSize = true;
            this.Mode.BackColor = System.Drawing.Color.FloralWhite;
            this.Mode.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mode.Location = new System.Drawing.Point(12, 23);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(114, 23);
            this.Mode.TabIndex = 1;
            this.Mode.Text = "Easy Level";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.BackgroundImage = global::AimTraining.Resource.Background;
            this.ClientSize = new System.Drawing.Size(934, 576);
            this.Controls.Add(this.Mode);
            this.Controls.Add(this.UserScoreLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Training Aim";
            this.TopMost = true;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label UserScoreLabel;
        private System.Windows.Forms.Label Mode;
    }
}

