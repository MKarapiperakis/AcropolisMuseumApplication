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
    public partial class Help : Form
    {
        
        public Help()
        {
            
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            label3.Text = Properties.Resources.Εισαγωγικό_σημείωμα;
            label1.Image = Properties.Resources._123;
            label2.Image = Properties.Resources._123;
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
    }
}
