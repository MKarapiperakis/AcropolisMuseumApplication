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
    public partial class room2_2 : Form
    {
        public room2_2()
        {
            InitializeComponent();
        }

        private void room2_2_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.room1_background;

            button2.FlatStyle = FlatStyle.Flat;
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;

            label1.Text = Properties.Resources.room2_2;
            label1.FlatStyle = FlatStyle.Flat;
            label1.BackColor = Color.Transparent;

            pictureBox1.Image = Properties.Resources.room2_2_1;
            pictureBox2.Image = Properties.Resources.room2_2_3;
            pictureBox3.Image = Properties.Resources.room2_2_2;

            radioButton1.BackColor = Color.Transparent;
            radioButton1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            radioButton1.FlatAppearance.MouseOverBackColor = Color.Transparent;

            radioButton2.BackColor = Color.Transparent;
            radioButton2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            radioButton2.FlatAppearance.MouseOverBackColor = Color.Transparent;

            radioButton3.BackColor = Color.Transparent;
            radioButton3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            radioButton3.FlatAppearance.MouseOverBackColor = Color.Transparent;

            radioButton2.Checked = true;
        }

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox4.Image = pictureBox1.Image;
            pictureBox1.Image = pictureBox3.Image;
            pictureBox3.Image = pictureBox4.Image;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox4.Image = pictureBox2.Image;
            pictureBox2.Image = pictureBox3.Image;
            pictureBox3.Image = pictureBox4.Image;
        }
    }
}
