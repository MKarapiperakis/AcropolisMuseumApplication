using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Acropolis_Museum
{
    public partial class room2_1 : Form
    {
        public int i = 1;
        public room2_1()
        {
            InitializeComponent();
        }

        private void room2_1_Load(object sender, EventArgs e)
        {

            radioButton1.Checked = true;
            pictureBox1.Image = Properties.Resources.room2_1_1;
            
            pictureBox1.Visible = true;
            
            BackgroundImage = Properties.Resources.room1_background;
            label1.Text = Properties.Resources.room2_1;
            label1.FlatStyle = FlatStyle.Flat;
            label1.BackColor = Color.Transparent;

            label2.Text = Properties.Resources.room2_1;
            label2.FlatStyle = FlatStyle.Flat;
            label2.BackColor = Color.Transparent;

            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button2.FlatStyle = FlatStyle.Flat;
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button3.FlatStyle = FlatStyle.Flat;
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;

           
            radioButton1.BackColor = Color.Transparent;
            radioButton1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            radioButton1.FlatAppearance.MouseOverBackColor = Color.Transparent;

            radioButton2.BackColor = Color.Transparent;
            radioButton2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            radioButton2.FlatAppearance.MouseOverBackColor = Color.Transparent;
     
            radioButton3.BackColor = Color.Transparent;
            radioButton3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            radioButton3.FlatAppearance.MouseOverBackColor = Color.Transparent;
          
            radioButton4.BackColor = Color.Transparent;
            radioButton4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            radioButton4.FlatAppearance.MouseOverBackColor = Color.Transparent;
         
            radioButton5.BackColor = Color.Transparent;
            radioButton5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            radioButton5.FlatAppearance.MouseOverBackColor = Color.Transparent;

            radioButton6.BackColor = Color.Transparent;
            radioButton6.FlatAppearance.MouseDownBackColor = Color.Transparent;
            radioButton6.FlatAppearance.MouseOverBackColor = Color.Transparent;

        }

        SoundPlayer sp = new SoundPlayer(Properties.Resources.room2_1_sound);
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Gold;
            sp.Play();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.LightBlue;
            sp.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            i++;
            switch(i)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.room2_1_1;
                    radioButton1.Checked = true;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.room2_1_2;
                    radioButton2.Checked = true;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.room2_1_3;
                    radioButton3.Checked = true;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.room2_1_4;
                    radioButton4.Checked = true;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.room2_1_5;
                    radioButton5.Checked = true;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.room2_1_6;
                    radioButton6.Checked = true;
                    break;
                default:
                    pictureBox1.Image = Properties.Resources.room2_1_1;
                    radioButton1.Checked = true;
                    break;
            }
            if (i > 6)
                i = 1;
            
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Cursor = Cursors.AppStarting;
            label2.Visible = true;

            switch (i)
            {
                case 1:
                    label2.Text = Properties.Resources.room2_1_1_text;
                    break;
                case 2:
                    label2.Text = label2.Text = Properties.Resources.room2_1_2_text;
                    break;
                case 3:
                    label2.Text = label2.Text = Properties.Resources.room2_1_3_text;
                    break;
                case 4:
                    label2.Text = label2.Text = Properties.Resources.room2_1_4_text;
                    break;
                case 5:
                    label2.Text = label2.Text = Properties.Resources.room2_1_5_text;
                    break;
                case 6:
                    label2.Text = label2.Text = Properties.Resources.room2_1_6_text;
                    break;
                default:
                    label2.Text = label2.Text = Properties.Resources.room2_1_6_text;
                    break;
            }
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            this.Cursor = Cursors.Default;
            label2.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.room2_1_1;
            i = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.room2_1_2;
            i = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.room2_1_3;
            i = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.room2_1_4;
            i = 4;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.room2_1_5;
            i = 5;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.room2_1_6;
            i = 6;
        }
    }
}
