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
    public partial class map : Form
    {
        public int page;
        public map()
        {
            InitializeComponent();
            
        }
        public void show_map(int k)
        {
            page = k;
            BackgroundImage = Properties.Resources.room1_background;
            switch (page)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.map_room1;
                    label1.Text = "Ισόγειο";
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.map_room2;
                    label1.Text = "1ος όροφος";
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.map_room3;
                    label1.Text = "1ος όροφος";
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.map_room4;
                    label1.Text = "1ος όροφος";
                    break;
               
            }
        }
        private void map_Load(object sender, EventArgs e)
        {
            
            label1.FlatStyle = FlatStyle.Flat;
            label1.BackColor = Color.Transparent;
            

           
        }

       
    }
}
