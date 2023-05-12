namespace client_UI
{
    partial class Vote
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer_title = new System.Windows.Forms.Label();
            this.textTimer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(408, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "test1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(408, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "test2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(408, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "test3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(4, 371);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(408, 51);
            this.button5.TabIndex = 3;
            this.button5.Text = "test5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(4, 299);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(408, 51);
            this.button4.TabIndex = 4;
            this.button4.Text = "test4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer_title
            // 
            this.timer_title.AutoSize = true;
            this.timer_title.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_title.Location = new System.Drawing.Point(334, 32);
            this.timer_title.Name = "timer_title";
            this.timer_title.Size = new System.Drawing.Size(58, 21);
            this.timer_title.TabIndex = 6;
            this.timer_title.Text = "타이머";
            this.timer_title.Click += new System.EventHandler(this.label1_Click);
            // 
            // textTimer
            // 
            this.textTimer.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textTimer.Location = new System.Drawing.Point(305, 56);
            this.textTimer.Name = "textTimer";
            this.textTimer.ReadOnly = true;
            this.textTimer.Size = new System.Drawing.Size(107, 29);
            this.textTimer.TabIndex = 18;
            // 
            // Vote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 448);
            this.Controls.Add(this.textTimer);
            this.Controls.Add(this.timer_title);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Vote";
            this.Text = "Vote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label timer_title;
        private System.Windows.Forms.TextBox textTimer;
    }
}