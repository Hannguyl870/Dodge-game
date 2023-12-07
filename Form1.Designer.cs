namespace dodge_game
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
            this.Balltimer = new System.Windows.Forms.Timer(this.components);
            this.scorelable = new System.Windows.Forms.Label();
            this.Winlable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Balltimer
            // 
            this.Balltimer.Enabled = true;
            this.Balltimer.Interval = 20;
            this.Balltimer.Tick += new System.EventHandler(this.Balltimer_Tick);
            // 
            // scorelable
            // 
            this.scorelable.BackColor = System.Drawing.Color.Transparent;
            this.scorelable.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelable.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.scorelable.Location = new System.Drawing.Point(246, 16);
            this.scorelable.Name = "scorelable";
            this.scorelable.Size = new System.Drawing.Size(100, 23);
            this.scorelable.TabIndex = 0;
            this.scorelable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Winlable
            // 
            this.Winlable.BackColor = System.Drawing.Color.Transparent;
            this.Winlable.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Winlable.Location = new System.Drawing.Point(192, 149);
            this.Winlable.Name = "Winlable";
            this.Winlable.Size = new System.Drawing.Size(193, 69);
            this.Winlable.TabIndex = 1;
            this.Winlable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.Winlable);
            this.Controls.Add(this.scorelable);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Balltimer;
        private System.Windows.Forms.Label scorelable;
        private System.Windows.Forms.Label Winlable;
    }
}

