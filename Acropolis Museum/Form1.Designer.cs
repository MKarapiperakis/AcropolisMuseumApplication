
namespace Acropolis_Museum
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.επιλογέςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.εκκίνησηToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.βοήθειαToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.παιχνίδιToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.έξοδοςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(303, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 67);
            this.label2.TabIndex = 5;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Visible = false;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button3.ForeColor = System.Drawing.Color.Gold;
            this.button3.Location = new System.Drawing.Point(115, 709);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 53);
            this.button3.TabIndex = 6;
            this.button3.Text = "<<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Gold;
            this.button4.Location = new System.Drawing.Point(298, 709);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 53);
            this.button4.TabIndex = 7;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(205, 709);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 53);
            this.label3.TabIndex = 8;
            this.label3.Text = "εικόνα 1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.Gold;
            this.button5.Location = new System.Drawing.Point(550, 179);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(420, 101);
            this.button5.TabIndex = 9;
            this.button5.Text = "Διάβασε Περισσότερα";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.SkyBlue;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button7.ForeColor = System.Drawing.Color.Gold;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(95, 88);
            this.button7.TabIndex = 11;
            this.button7.Text = "🔙";
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button7.MouseLeave += new System.EventHandler(this.button7_MouseLeave);
            this.button7.MouseHover += new System.EventHandler(this.button7_MouseHover);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold);
            this.button8.ForeColor = System.Drawing.Color.Gold;
            this.button8.Location = new System.Drawing.Point(804, 120);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(84, 53);
            this.button8.TabIndex = 12;
            this.button8.Text = ">>";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button9.ForeColor = System.Drawing.Color.Gold;
            this.button9.Location = new System.Drawing.Point(618, 120);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(84, 53);
            this.button9.TabIndex = 13;
            this.button9.Text = "<<";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(708, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 53);
            this.label4.TabIndex = 14;
            this.label4.Text = "σελίδα 1";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Black;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.Location = new System.Drawing.Point(190, 507);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(18, 15);
            this.button10.TabIndex = 15;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.MouseLeave += new System.EventHandler(this.button10_MouseLeave);
            this.button10.MouseHover += new System.EventHandler(this.button10_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(502, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(468, 585);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(12, 557);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 237);
            this.label1.TabIndex = 17;
            this.label1.Visible = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Black;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.Location = new System.Drawing.Point(277, 382);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(18, 15);
            this.button11.TabIndex = 18;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Visible = false;
            this.button11.MouseLeave += new System.EventHandler(this.button11_MouseLeave);
            this.button11.MouseHover += new System.EventHandler(this.button11_MouseHover);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Black;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.Location = new System.Drawing.Point(229, 488);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(18, 15);
            this.button12.TabIndex = 19;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Visible = false;
            this.button12.MouseLeave += new System.EventHandler(this.button12_MouseLeave);
            this.button12.MouseHover += new System.EventHandler(this.button12_MouseHover);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Black;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.Location = new System.Drawing.Point(246, 433);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(18, 15);
            this.button13.TabIndex = 20;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Visible = false;
            this.button13.MouseLeave += new System.EventHandler(this.button13_MouseLeave);
            this.button13.MouseHover += new System.EventHandler(this.button13_MouseHover);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Black;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.Location = new System.Drawing.Point(264, 469);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(18, 15);
            this.button14.TabIndex = 21;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Visible = false;
            this.button14.MouseLeave += new System.EventHandler(this.button14_MouseLeave);
            this.button14.MouseHover += new System.EventHandler(this.button14_MouseHover);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.επιλογέςToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // επιλογέςToolStripMenuItem
            // 
            this.επιλογέςToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.εκκίνησηToolStripMenuItem,
            this.βοήθειαToolStripMenuItem,
            this.παιχνίδιToolStripMenuItem,
            this.έξοδοςToolStripMenuItem});
            this.επιλογέςToolStripMenuItem.Name = "επιλογέςToolStripMenuItem";
            this.επιλογέςToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.επιλογέςToolStripMenuItem.Text = "Αρχικό Μενού ";
            this.επιλογέςToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // εκκίνησηToolStripMenuItem
            // 
            this.εκκίνησηToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.εκκίνησηToolStripMenuItem.Name = "εκκίνησηToolStripMenuItem";
            this.εκκίνησηToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.εκκίνησηToolStripMenuItem.Text = "Εκκίνηση";
            this.εκκίνησηToolStripMenuItem.Click += new System.EventHandler(this.εκκίνησηToolStripMenuItem_Click);
            // 
            // βοήθειαToolStripMenuItem
            // 
            this.βοήθειαToolStripMenuItem.Name = "βοήθειαToolStripMenuItem";
            this.βοήθειαToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.βοήθειαToolStripMenuItem.Text = "Βοήθεια";
            this.βοήθειαToolStripMenuItem.Click += new System.EventHandler(this.βοήθειαToolStripMenuItem_Click);
            // 
            // παιχνίδιToolStripMenuItem
            // 
            this.παιχνίδιToolStripMenuItem.Name = "παιχνίδιToolStripMenuItem";
            this.παιχνίδιToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.παιχνίδιToolStripMenuItem.Text = "Παιχνίδι";
            this.παιχνίδιToolStripMenuItem.Click += new System.EventHandler(this.παιχνίδιToolStripMenuItem_Click);
            // 
            // έξοδοςToolStripMenuItem
            // 
            this.έξοδοςToolStripMenuItem.Name = "έξοδοςToolStripMenuItem";
            this.έξοδοςToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.έξοδοςToolStripMenuItem.Text = "Έξοδος";
            this.έξοδοςToolStripMenuItem.Click += new System.EventHandler(this.έξοδοςToolStripMenuItem_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 585);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "Acropolis Musem";
            this.notifyIcon1.Visible = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.ForeColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(839, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 55);
            this.button1.TabIndex = 23;
            this.button1.Text = "Χάρτης";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(982, 803);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 850);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 850);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acropolis Museum";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button10;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem επιλογέςToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem εκκίνησηToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem βοήθειαToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem παιχνίδιToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem έξοδοςToolStripMenuItem;
    }
}

