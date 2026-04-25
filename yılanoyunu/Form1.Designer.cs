namespace yılanoyunu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.puan = new System.Windows.Forms.Label();
            this.skor = new System.Windows.Forms.Label();
            this.tebriks = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 600);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // puan
            // 
            this.puan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.puan.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puan.ForeColor = System.Drawing.Color.White;
            this.puan.Location = new System.Drawing.Point(675, 55);
            this.puan.Name = "puan";
            this.puan.Size = new System.Drawing.Size(142, 59);
            this.puan.TabIndex = 1;
            this.puan.Text = "PUAN: ";
            this.puan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // skor
            // 
            this.skor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skor.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skor.ForeColor = System.Drawing.Color.White;
            this.skor.Location = new System.Drawing.Point(697, 114);
            this.skor.Name = "skor";
            this.skor.Size = new System.Drawing.Size(105, 59);
            this.skor.TabIndex = 2;
            this.skor.Text = "0";
            this.skor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.skor.Click += new System.EventHandler(this.skor_Click);
            // 
            // tebriks
            // 
            this.tebriks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tebriks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tebriks.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tebriks.ForeColor = System.Drawing.Color.Black;
            this.tebriks.Location = new System.Drawing.Point(628, 368);
            this.tebriks.Name = "tebriks";
            this.tebriks.Size = new System.Drawing.Size(253, 78);
            this.tebriks.TabIndex = 3;
            this.tebriks.Text = "TEBRİKLER :)";
            this.tebriks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tebriks.Click += new System.EventHandler(this.tebriks_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.start.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.start.ForeColor = System.Drawing.Color.Black;
            this.start.Location = new System.Drawing.Point(675, 472);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(148, 59);
            this.start.TabIndex = 5;
            this.start.Text = "START";
            this.start.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(893, 625);
            this.Controls.Add(this.start);
            this.Controls.Add(this.tebriks);
            this.Controls.Add(this.skor);
            this.Controls.Add(this.puan);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label puan;
        private System.Windows.Forms.Label skor;
        private System.Windows.Forms.Label tebriks;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Timer timer1;
    }
}

