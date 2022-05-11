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
    public partial class room1 : Form
    {
        public Boolean flag = true;
        public room1()
        {
            InitializeComponent();
        }

        private void room1_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.room1_background;
            label1.Text = Properties.Resources.room1;
            label1.FlatStyle = FlatStyle.Flat;
            label1.BackColor = Color.Transparent;
            


            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button2.FlatStyle = FlatStyle.Flat;
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;




        }
        SoundPlayer sp = new SoundPlayer(Properties.Resources.room1_sound);

       

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

      

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        private void button2_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
    }
}
