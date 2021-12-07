namespace Air_Hockey
{
    partial class Form1
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.p2Label = new System.Windows.Forms.Label();
            this.p1Label = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // p2Label
            // 
            this.p2Label.BackColor = System.Drawing.Color.Transparent;
            this.p2Label.Font = new System.Drawing.Font("Consolas", 12F);
            this.p2Label.ForeColor = System.Drawing.Color.White;
            this.p2Label.Location = new System.Drawing.Point(2, 259);
            this.p2Label.Name = "p2Label";
            this.p2Label.Size = new System.Drawing.Size(84, 25);
            this.p2Label.TabIndex = 4;
            this.p2Label.Text = "0";
            this.p2Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // p1Label
            // 
            this.p1Label.BackColor = System.Drawing.Color.Transparent;
            this.p1Label.Font = new System.Drawing.Font("Consolas", 12F);
            this.p1Label.ForeColor = System.Drawing.Color.White;
            this.p1Label.Location = new System.Drawing.Point(2, 222);
            this.p1Label.Name = "p1Label";
            this.p1Label.Size = new System.Drawing.Size(84, 25);
            this.p1Label.TabIndex = 5;
            this.p1Label.Text = "0";
            this.p1Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // winLabel
            // 
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Font = new System.Drawing.Font("Consolas", 12F);
            this.winLabel.ForeColor = System.Drawing.Color.White;
            this.winLabel.Location = new System.Drawing.Point(238, 222);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(219, 30);
            this.winLabel.TabIndex = 6;
            this.winLabel.Text = "win";
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.winLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(702, 635);
            this.Controls.Add(this.p2Label);
            this.Controls.Add(this.p1Label);
            this.Controls.Add(this.winLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label p2Label;
        private System.Windows.Forms.Label p1Label;
        private System.Windows.Forms.Label winLabel;
    }
}

