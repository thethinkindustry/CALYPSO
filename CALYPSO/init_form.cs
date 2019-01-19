using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALYPSO
{
    public partial class init_form : Form
    {
        int counter;
        public init_form()
        {
            InitializeComponent();
            counter = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter>=40)
            {
                timer1.Stop();
                this.Close();
                Form1 frm1 = new Form1();
                frm1.Show();

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
