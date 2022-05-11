using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acropolis_Museum
{
    public partial class room4 : Form
    {
        public room4()
        {
            InitializeComponent();
        }

        private void room4_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;

            BackgroundImage = Properties.Resources.room1_background;
            button2.FlatStyle = FlatStyle.Flat;
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;

            label1.Text = Properties.Resources.room4;
            label1.FlatStyle = FlatStyle.Flat;
            label1.BackColor = Color.Transparent;

            label2.Text = Properties.Resources.room4_1_text;
            label2.FlatStyle = FlatStyle.Flat;
            label2.BackColor = Color.Transparent;

            label3.Text = "Tα Προπύλαια";
            label3.FlatStyle = FlatStyle.Flat;
            label3.BackColor = Color.Transparent;

            pictureBox1.Image = Properties.Resources.room4_1_1;

            radioButton1.BackColor = Color.Transparent;
            radioButton1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            radioButton1.FlatAppearance.MouseOverBackColor = Color.Transparent;

            radioButton2.BackColor = Color.Transparent;
            radioButton2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            radioButton2.FlatAppearance.MouseOverBackColor = Color.Transparent;

            radioButton3.BackColor = Color.Transparent;
            radioButton3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            radioButton3.FlatAppearance.MouseOverBackColor = Color.Transparent;
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
            pictureBox1.Image = Properties.Resources.room4_1_1;
            label2.Text = Properties.Resources.room4_1_text;
            label3.Text = "Tα Προπύλαια";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.room4_2_1;
            label2.Text = Properties.Resources.room4_2_text;
            label3.Text = "Ο ναός της Αθηνάς Νίκης";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.room4_3_1;
            label2.Text = Properties.Resources.room4_3_text;
            label3.Text = "Το Ερέχθειο";
        }
    }
}
