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
    public partial class gameroom : Form
    {
        bool allowClick = false;
        PictureBox firstguess;
        Random rnd = new Random();
        Timer clickTimer = new Timer();
        int time = 0;
        int moves = 0;
        int counter = 8;
        Timer timer = new Timer
        {
            Interval = 1000
        };

        public gameroom()
        {
            InitializeComponent();
        }

        private PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }

        private static IEnumerable<Image> images
        {
            get
            {
                return new Image[]
                {
                Properties.Resources.img1,
                Properties.Resources.img2,
                Properties.Resources.img3,
                Properties.Resources.img4,
                Properties.Resources.img5,
                Properties.Resources.img6,
                Properties.Resources.img7,
                Properties.Resources.img8
                };
            }
            
        }

        private void startGameTimer()
        {
            timer.Start();
            timer.Tick += delegate
            {
                time++;
               
                var ssTime = TimeSpan.FromSeconds(time);
                if(time < 10)
                    label1.Text = "Χρόνος: 00:0" + time.ToString();
                else
                    label1.Text = "Χρόνος: 00:" + time.ToString();
            };
        }
      

        

        private void HideImages()
        {
            foreach(var pic in pictureBoxes)
            {
                if(pic.Enabled == true)
                     pic.Image = Properties.Resources.mystery;
            }
        }

        private PictureBox getFreeSlot()
        {
            int num;

            do
            {
                num = rnd.Next(0, pictureBoxes.Count());

            }
            while (pictureBoxes[num].Tag != null);
            return pictureBoxes[num];
        }

        private void setRandomImages()
        {
            foreach(var image in images)
            {
                getFreeSlot().Tag = image;
                getFreeSlot().Tag = image;
            }

        }

      private void CLICKTIMER_TICK(object sender, EventArgs e)
        {
            HideImages();

            allowClick = true;
            clickTimer.Stop();
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

        private void gameroom_Load(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button2.FlatStyle = FlatStyle.Flat;
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;

            label1.FlatStyle = FlatStyle.Flat;
            label1.BackColor = Color.Transparent;

            label2.FlatStyle = FlatStyle.Flat;
            label2.BackColor = Color.Transparent;

            button3.FlatStyle = FlatStyle.Flat;
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button4.FlatStyle = FlatStyle.Flat;
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;

            this.BackgroundImage = Properties.Resources.images;

            
        }

        private void clickImage(object sender, EventArgs e)
        {
            if (!allowClick) return;

            var pic = (PictureBox)sender;

            if(firstguess == null)
            {
                firstguess = pic;
                
                pic.Image = (Image)pic.Tag;
                return;

            }
            pic.Image = (Image)pic.Tag;

            if(pic.Image == firstguess.Image && pic != firstguess)
            {
                pic.Enabled = firstguess.Enabled = false;
                {
                    firstguess = pic;
                    counter--;
                    if(counter == 0)
                    {
                        timer.Stop();
                        button3.Visible = true;
                    }
                }
                
            }
            else
            {
                allowClick = false;
                clickTimer.Start();

            }

            firstguess = null;
            moves++;
            label2.Text = "Κινήσεις: " + moves;
        }

        private void startGame(object sender, EventArgs e)
        {
            
            allowClick = true;
            setRandomImages();
            HideImages();
            startGameTimer();
            clickTimer.Interval = 1000;
            clickTimer.Tick += CLICKTIMER_TICK;

            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Tag = null;
                pic.Enabled = true;
                
            }

            HideImages();
            setRandomImages();
            time = 0;
            counter = 8;
            moves = 0;
            label2.Text = "Κινήσεις: " + moves;
            timer.Start();
            button3.Visible = false;

        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ό σκοπός είναι να βρεις το ταίρι για κάθε κάρτα που θα σηκώνεις.Αν η δεύτερη κάρτα που σηκώσεις " +
                "είναι διαφορετική από την πρώτη θα κρύβονται και οι 2. Εναλλακτικά θα παραμένουν ανοικτές.Το παιχνίδι τελειώνει " +
                "όταν βρεις τα ζεύγη όλων των καρτών");
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Yellow;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Black;
        }
    }


}
