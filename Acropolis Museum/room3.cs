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
    public partial class room3 : Form
    {
        int pg = 0;
        public room3()
        {
            InitializeComponent();
        }

        private void room3_Load(object sender, EventArgs e)
        {
            
            BackgroundImage = Properties.Resources.room1_background;

            label1.Text = Properties.Resources.room3;
            label1.FlatStyle = FlatStyle.Flat;
            label1.BackColor = Color.Transparent;

            label2.FlatStyle = FlatStyle.Flat;
            label2.BackColor = Color.Transparent;

            label3.FlatStyle = FlatStyle.Flat;
            label3.BackColor = Color.Transparent;


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

            button4.FlatStyle = FlatStyle.Flat;
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;

        }
        SoundPlayer sp = new SoundPlayer(Properties.Resources.room3_sound);
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

        private void button3_Click(object sender, EventArgs e)      //next page
        {
            
            pg++;
            if (pg > 3)
                pg = 0;
            changes(pg);
        }

        private void button4_Click(object sender, EventArgs e)      //prev page
        {
            pg--;
            if (pg < 0)
                pg = 3;
            changes(pg);
        }

        private void changes(int page)
        {
            switch(page)
            {
                case 0:
                    button1.Visible = true;
                    label2.Visible = false;
                    label3.Visible = false;
                    label1.Text = label1.Text = Properties.Resources.room3;
                    pictureBox1.Visible = false;
                    setFalse();
                    break;
                case 1:
                    label3.Visible = false;
                    label2.Visible = true;
                    button1.Visible = false;
                    label2.Text = "Τα οικοδομήματα";
                    label1.Text = Properties.Resources.room3_1_text;
                    setTrue();
                    pictureBox2.Image = Properties.Resources.room3_1_1;
                    pictureBox3.Image = Properties.Resources.room3_1_2;
                    pictureBox4.Image = Properties.Resources.room3_1_3;
                    pictureBox5.Image = Properties.Resources.room3_1_4;
                    pictureBox6.Image = Properties.Resources.room3_1_5;
                    pictureBox7.Image = Properties.Resources.room3_1_6;
                    break;
                case 2:
                    label2.Text = "Τα αφιερώματα";
                    label3.Visible = false;
                    label2.Visible = true;
                    button1.Visible = false;
                    label1.Text = Properties.Resources.room3_2_text;
                    setTrue();
                    pictureBox2.Image = Properties.Resources.room3_2_1;
                    pictureBox3.Image = Properties.Resources.room3_2_2;
                    pictureBox4.Image = Properties.Resources.room3_2_3;
                    pictureBox5.Image = Properties.Resources.room3_2_4;
                    pictureBox6.Image = Properties.Resources.room3_2_5;
                    pictureBox7.Image = Properties.Resources.room3_2_6;
                    break;
                case 3:
                    label3.Visible = false;
                    label2.Visible = true;
                    button1.Visible = false;
                    label2.Text = "Τα αφιερώματα της πρώιμης Κλασικής εποχής (480-450 π.Χ.)";
                    label1.Text = Properties.Resources.room3_3_text;
                    setTrue();
                    pictureBox2.Image = Properties.Resources.room3_3_1;
                    pictureBox3.Image = Properties.Resources.room3_3_2;
                    pictureBox4.Image = Properties.Resources.room3_3_3;
                    pictureBox5.Image = Properties.Resources.room3_3_4;
                    pictureBox6.Image = Properties.Resources.room3_3_5;
                    pictureBox7.Image = Properties.Resources.room3_3_6;
                    break;
            }
        }

        private void setFalse()
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
        }

        private void setTrue()
        {
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label3.Visible = false;
            setTrue();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            switch (pg)
            {
                case 1:
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.room3_1_1;
                    label3.Text = Properties.Resources.room3_1_1_text;
                    label3.Visible = true;
                    setFalse();
                    break;
                case 2:
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.room3_2_1;
                    label3.Text = Properties.Resources.room3_2_1_text;
                    label3.Visible = true;
                    setFalse();
                    break;
                case 3:
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.room3_3_1;
                    label3.Text = Properties.Resources.room3_3_1_text;
                    label3.Visible = true;
                    setFalse();
                    break;
            }
        }

        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            switch (pg)
            {
                case 1:
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.room3_1_2;
                    label3.Text = Properties.Resources.room3_1_2_text;
                    label3.Visible = true;
                    setFalse();
                    break;
                case 2:
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.room3_2_2;
                    label3.Text = Properties.Resources.room3_2_2_text;
                    label3.Visible = true;
                    setFalse();
                    break;
                case 3:
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.room3_3_2;
                    label3.Text = Properties.Resources.room3_3_2_text;
                    label3.Visible = true;
                    setFalse();
                    break;
            }   
    }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            switch (pg)
            {

                case 1:
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.room3_1_3;
                    label3.Text = Properties.Resources.room3_1_3_text;
                    label3.Visible = true;
                    setFalse();
                    break;
                case 2:
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.room3_2_3;
                    label3.Text = Properties.Resources.room3_2_3_text;
                    label3.Visible = true;
                    setFalse();
                    break;
                case 3:
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.room3_3_3;
                    label3.Text = Properties.Resources.room3_3_3_text;
                    label3.Visible = true;
                    setFalse();
                    break;
            }
    }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            switch(pg)
            {
                case 1:
                pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources.room3_1_4;
                label3.Text = Properties.Resources.room3_1_4_text;
                label3.Visible = true;
                setFalse();
                break;
                case 2:
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.room3_2_4;
                    label3.Text = Properties.Resources.room3_2_4_text;
                    label3.Visible = true;
                    setFalse();
                    break;
                case 3:
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.room3_3_4;
                    label3.Text = Properties.Resources.room3_3_4_text;
                    label3.Visible = true;
                    setFalse();
                    break;
            }

    }

    private void pictureBox7_Click(object sender, EventArgs e)
        {
            switch(pg)
            {
                case 1:
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.room3_1_6;
                    label3.Text = Properties.Resources.room3_1_6_text;
                    label3.Visible = true;
                    setFalse();
                    break;
                case 2:
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.room3_2_6;
                    label3.Text = Properties.Resources.room3_2_6_text;
                    label3.Visible = true;
                    setFalse();
                    break;
                case 3:
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.room3_3_6;
                    label3.Text = Properties.Resources.room3_3_6_text;
                    label3.Visible = true;
                    setFalse();
                    break;
            }
    }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            switch(pg)
            {
                case 1:
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.room3_1_5;
                    label3.Text = Properties.Resources.room3_1_5_text;
                    label3.Visible = true;
                    setFalse();
                    break;
                case 2:
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.room3_2_5;
                    label3.Text = Properties.Resources.room3_2_5_text;
                    label3.Visible = true;
                    setFalse();
                    break;
                case 3:
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.room3_3_5;
                    label3.Text = Properties.Resources.room3_3_5_text;
                    label3.Visible = true;
                    setFalse();
                    break;
            }
        }
    }
}
