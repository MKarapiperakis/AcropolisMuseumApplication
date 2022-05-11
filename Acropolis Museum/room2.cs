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
    public partial class room2 : Form
    {
        public room2()
        {
            InitializeComponent();
        }

        private void room2_Load(object sender, EventArgs e)
        {
           
            BackgroundImage = Properties.Resources.room1_background;
            label1.Text = Properties.Resources.room2;
            label1.FlatStyle = FlatStyle.Flat;
            label1.BackColor = Color.Transparent;

            label2.Text = "ΘΕΜΑΤΙΚΕΣ ΕΝΟΤΗΤΕΣ ΑΙΘΟΥΣΑΣ";
            label2.FlatStyle = FlatStyle.Flat;
            label2.BackColor = Color.Transparent;

            label3.Text = Properties.Resources.room2_θεμ_εν;
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

            
            radioButton1.BackColor = Color.Transparent;
            radioButton1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            radioButton1.FlatAppearance.MouseOverBackColor = Color.Transparent;

            radioButton2.BackColor = Color.Transparent;
            radioButton2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            radioButton2.FlatAppearance.MouseOverBackColor = Color.Transparent;

        }
        SoundPlayer sp = new SoundPlayer(Properties.Resources.room2_sound);

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void button2_MouseHover_1(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                room2_1 rm1 = new room2_1();
                rm1.Show();
            }
            else if (radioButton2.Checked == true)
            {
                room2_2 rm2 = new room2_2();
                rm2.Show();
            }
            else
                MessageBox.Show("Παρακαλώ επέλεξε θεματική ενότητα");
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
