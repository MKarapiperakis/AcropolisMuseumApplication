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
    public partial class Form1 : Form
    {
        public int i = 1;
        public int j = 1;
        public int k = 1;
        public Boolean flag = true;
        public Form1()
        {
            
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.Icon = Properties.Resources.ico1;
            this.Icon = Properties.Resources.ico2;
           

            BackgroundImage = Properties.Resources._1;

            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;         
        }


        private void βοήθειαToolStripMenuItem_Click(object sender, EventArgs e)     //help
        {
            Help h = new Help();
            h.Show();
        }
        private void έξοδοςToolStripMenuItem_Click_1(object sender, EventArgs e)    //exit
        {
            this.Close();
        }
        

     
        private void εκκίνησηToolStripMenuItem_Click(object sender, EventArgs e)    //start
        {
            menuStrip1.Visible = false;
            timer1.Enabled = false;
           

            this.BackgroundImage = Properties.Resources.images;



            
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            button1.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;


            label1.FlatStyle = FlatStyle.Flat;
            label1.BackColor = Color.Transparent;

            label2.FlatStyle = FlatStyle.Flat;
            label2.BackColor = Color.Transparent;

            label3.FlatStyle = FlatStyle.Flat;
            label3.BackColor = Color.Transparent;

            label4.FlatStyle = FlatStyle.Flat;
            label4.BackColor = Color.Transparent;


            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button3.FlatStyle = FlatStyle.Flat;
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button4.FlatStyle = FlatStyle.Flat;
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button5.FlatStyle = FlatStyle.Flat;
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button5.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button7.FlatStyle = FlatStyle.Flat;
            button7.BackColor = Color.Transparent;
            button7.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button7.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button8.FlatStyle = FlatStyle.Flat;
            button8.BackColor = Color.Transparent;
            button8.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button8.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button9.FlatStyle = FlatStyle.Flat;
            button9.BackColor = Color.Transparent;
            button9.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button9.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button10.FlatStyle = FlatStyle.Flat;
            button10.BackColor = Color.Crimson;
            button10.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button10.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button11.FlatStyle = FlatStyle.Flat;
            button11.BackColor = Color.Crimson;
            button11.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button11.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button12.FlatStyle = FlatStyle.Flat;
            button12.BackColor = Color.Crimson;
            button12.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button12.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button13.FlatStyle = FlatStyle.Flat;
            button13.BackColor = Color.Crimson;
            button13.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button13.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button14.FlatStyle = FlatStyle.Flat;
            button14.BackColor = Color.Crimson;
            button14.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button14.FlatAppearance.MouseOverBackColor = Color.Transparent;

            pictureBox1.Visible = true;

            label2.Text = Properties.Resources.String1;
            pictureBox1.Image = Properties.Resources.αιθουσα1_1;
        }

       

        private void timer1_Tick(object sender, EventArgs e)        //background gia to arxiko menu
        {
            i++;
            switch (i)
            {
                case 1:
                    BackgroundImage = Properties.Resources._1;
                    break;
                case 2:
                    BackgroundImage = Properties.Resources._2;
                    break;
                case 3:
                    BackgroundImage = Properties.Resources._3;
                    break;
                case 4:
                    BackgroundImage = Properties.Resources._4;
                    break;
                case 5:
                    BackgroundImage = Properties.Resources._5;
                    break;
                case 6:
                    BackgroundImage = Properties.Resources._6;
                    break;
                case 7:
                    BackgroundImage = Properties.Resources._7;
                    break;
                case 8:
                    BackgroundImage = Properties.Resources._8;
                    break;
                case 9:
                    BackgroundImage = Properties.Resources._9;
                    break;
                case 10:
                    BackgroundImage = Properties.Resources._10;
                    break;
                case 11:
                    BackgroundImage = Properties.Resources._11;
                    break;
            }
            if (i == 11)
                i = 0;
        }

        private void button3_Click(object sender, EventArgs e)      //προηγούμενη εικόνα
        {
            switch (k)
            {
                case 1:
                    j--;
                    if (j < 1)
                         j = 3;
                     break;
                case 3:
                    j--;
                    if (j < 1)
                        j = 3;
                    break;
                case 4:
                    j--;
                    if (j < 1)
                        j = 3;
                    break;
            }
            show();
        }

        private void button4_Click(object sender, EventArgs e)      //επόμενη εικόνα
        {
            switch (k)
            {
                case 1:
                    j++;
                    if (j > 3)
                        j = 1;
                    break;
                case 3:
                    j++;
                    if (j > 3)
                        j = 1;
                    break;
                case 4:
                    j++;
                    if (j > 3)
                        j = 1;
                    break;
                case 5:
                    j++;
                    if (j > 3)
                        j = 1;
                    break;
            }
            show();
        }

        public void show()
        {
            if (k == 1)
            {
                
                switch (j)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.αιθουσα1_1;
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.αιθουσα1_2;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.αιθουσα1_3;
                        break;

                }
                label3.Text = "εικόνα " + j;
            }
            if(k == 3)
            {
                
                switch (j)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.αιθ2_1;
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.αιθ2_2;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.αιθ2_3;
                        break;

                }
                label3.Text = "εικόνα " + j;
            }
            if (k == 4)
            {
                
                switch (j)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.pic_room3_1;
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.pic_room3_2;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.pic_room3_3;
                        break;

                }
                label3.Text = "εικόνα " + j;
            }
            if (k == 5)
            {
                
                switch (j)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.pic_room4_1;
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.pic_room4_2;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.pic_room4_3;
                        break;

                }
                label3.Text = "εικόνα " + j;
            }


        }

        private void button5_Click(object sender, EventArgs e)      //Show More Button
        {
            switch(k)
            {
                case 1:
                     room1 rm = new room1();
                     rm.Show();
                    break;
                case 3:
                    room2 rm2 = new room2();
                    rm2.Show();
                    break;
                case 4:
                    room3 rm3 = new room3();
                    rm3.Show();
                    break;
                case 5:
                    room4 rm4 = new room4();
                    rm4.Show();
                    break;
            }
    }

        

        private void button7_Click(object sender, EventArgs e)      //return to main menu button
        {
            menuStrip1.Visible = true;
            k = 1;
            j = 1;
            label3.Text = "εικόνα " + j;
            label4.Text = "σελίδα " + k;

            timer1.Enabled = true;

            // button2.Visible = true;
            // button6.Visible = true;


            button1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            pictureBox1.Visible = false;

            BackgroundImage = Properties.Resources._1;
        }

        private void button8_Click(object sender, EventArgs e)      //next page button
        {
            
            k++;
            if (k == 2)
            {
                j = 1;
                button1.Visible = false;
                label3.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button10.Visible = true;
                button11.Visible = true;
                button12.Visible = true;
                button13.Visible = true;
                button14.Visible = true;
                label2.Text = "Δημοφιλή Εκθέματα";
                pictureBox1.Image = Properties.Resources.map2;
               
            }
            else if(k==3)
            {
                j = 1;
                button1.Visible = true;
                pictureBox1.Image = Properties.Resources.αιθ2_1;
                label3.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button10.Visible = false;
                button11.Visible = false;
                button12.Visible = false;
                button13.Visible = false;
                button14.Visible = false;
                label2.Text = Properties.Resources.String2;
                
            }
            else if(k==4)
            {
                j = 1;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                button1.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                button9.Visible = true;

                label2.Text = Properties.Resources.String3;
                pictureBox1.Image = Properties.Resources.pic_room3_1;
            }
            else if (k == 5)
            {
                j = 1;
                button1.Visible = true;
                pictureBox1.Image = Properties.Resources.pic_room4_1;
                label3.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button10.Visible = false;
                button11.Visible = false;
                button12.Visible = false;
                button13.Visible = false;
                button14.Visible = false;
                label2.Text = Properties.Resources.String4;

            }
           
            else if(k>5)
            {
                k = 1;
                j = 1;
                //button1.Visible = false;
                //button2.Visible = false;
                //button6.Visible = false;
                menuStrip1.Visible = false;
                this.BackgroundImage = Properties.Resources.images;




                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                button9.Visible = true;

                pictureBox1.Visible = true;

                label2.Text = Properties.Resources.String1;
                pictureBox1.Image = Properties.Resources.αιθουσα1_1;
            }


            label3.Text = "εικόνα " + j;
            label4.Text = "σελίδα " + k;
        }

        private void button9_Click(object sender, EventArgs e)          //prev page button
        {
            k--;
            if (k < 1)
            {
               
                button1.Visible = true;
                pictureBox1.Image = Properties.Resources.pic_room4_1;
                label3.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button10.Visible = false;
                button11.Visible = false;
                button12.Visible = false;
                button13.Visible = false;
                button14.Visible = false;
                label2.Text = Properties.Resources.String4;
                k = 5;
                j = 1;
            }
            if(k == 1)
            {
                button1.Visible = true;
                label3.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button10.Visible = false;
                button11.Visible = false;
                button12.Visible = false;
                button13.Visible = false;
                button14.Visible = false;
                label2.Text = Properties.Resources.String1;
                pictureBox1.Image = Properties.Resources.αιθουσα1_1;
                j = 1;
                
            }
            else if(k == 2)
            {
                j = 1;
                button1.Visible = false;
                label3.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button10.Visible = true;
                button11.Visible = true;
                button12.Visible = true;
                button13.Visible = true;
                button14.Visible = true;
                label2.Text = "Δημοφιλή Εκθέματα";
                pictureBox1.Image = Properties.Resources.map2;
            }
            else if( k == 3 )
            {
                j = 1;
                button1.Visible = true;
                pictureBox1.Image = Properties.Resources.αιθ2_1;
                label3.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button10.Visible = false;
                button11.Visible = false;
                button12.Visible = false;
                button13.Visible = false;
                button14.Visible = false;
                label2.Text = Properties.Resources.String2;
            }
            else if (k == 4)
            {
                j = 1;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                button1.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                button9.Visible = true;
                label2.Text = Properties.Resources.String3;
                pictureBox1.Image = Properties.Resources.pic_room3_1;
            }
           
            label3.Text = "εικόνα " + j;
            label4.Text = "σελίδα " + k;
        }

        

        private void button10_MouseHover(object sender, EventArgs e)        //antikeimeno 1
        {
            pictureBox2.Visible = true;
            pictureBox2.Image = Properties.Resources.rsz_object_1;
            button8.Visible = false;
            button9.Visible = false;
            label4.Visible = false;
            label1.Visible = true;
            label1.Text = Properties.Resources.object1;
        }

        private void button10_MouseLeave(object sender, EventArgs e)        //antikeimeno 1
        {
            pictureBox2.Visible = false;
            button8.Visible = true;
            button9.Visible = true;
            label4.Visible = true;
            label1.Visible = false;
        }

        private void button11_MouseHover(object sender, EventArgs e)        //antikeimeno 2
        {
            pictureBox2.Visible = true;
            pictureBox2.Image = Properties.Resources.rsz_object_2;
            button8.Visible = false;
            button9.Visible = false;
            label4.Visible = false;
            label1.Visible = true;
            label1.Text = Properties.Resources.object2;
        }

        private void button11_MouseLeave(object sender, EventArgs e)        //antikeimeno 2
        {
            pictureBox2.Visible = false;
            button8.Visible = true;
            button9.Visible = true;
            label4.Visible = true;
            label1.Visible = false;
        }

        private void button12_MouseHover(object sender, EventArgs e)        //antikeimeno 3
        {
            pictureBox2.Visible = true;
            pictureBox2.Image = Properties.Resources.rsz_object_3;
            button8.Visible = false;
            button9.Visible = false;
            label4.Visible = false;
            label1.Visible = true;
            label1.Text = Properties.Resources.object3;
        }

        private void button12_MouseLeave(object sender, EventArgs e)        //antikeimeno 3
        {
            pictureBox2.Visible = false;
            button8.Visible = true;
            button9.Visible = true;
            label4.Visible = true;
            label1.Visible = false;
        }

        private void button13_MouseHover(object sender, EventArgs e)        //antikeimeno 4
        {
            pictureBox2.Visible = true;
            pictureBox2.Image = Properties.Resources.rsz_object_4;
            button8.Visible = false;
            button9.Visible = false;
            label4.Visible = false;
            label1.Visible = true;
            label1.Text = Properties.Resources.object4;
        }

        private void button13_MouseLeave(object sender, EventArgs e)        //antikeimeno 4
        {
            pictureBox2.Visible = false;
            button8.Visible = true;
            button9.Visible = true;
            label4.Visible = true;
            label1.Visible = false;
        }

        private void button14_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.Image = Properties.Resources.rsz_object_5;
            button8.Visible = false;
            button9.Visible = false;
            label4.Visible = false;
            label1.Visible = true;
            label1.Text = Properties.Resources.object5;

        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            button8.Visible = true;
            button9.Visible = true;
            label4.Visible = true;
            label1.Visible = false;
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        map m = new map();
        private void button1_MouseHover(object sender, EventArgs e)
        {
            m.show_map(k);
            m.Show();
            this.Cursor = Cursors.WaitCursor;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            m.Hide();
        }

        private void παιχνίδιToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameroom gm = new gameroom();
            gm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
