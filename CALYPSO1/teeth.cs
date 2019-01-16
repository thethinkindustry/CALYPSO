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
    public partial class teeth : Form
    {
        public teeth()
        {
            InitializeComponent();
            this.TopMost = true;
            this.BringToFront();

         
        }
        public void onClickList(PictureBox rb)
        {
            if (rb.BackColor == Color.DarkSlateGray)
            {
                rb.BackColor = Color.White;
            }
            else
            {
                rb.BackColor = Color.DarkSlateGray;
            }
        }
        private void teeth_Load(object sender, EventArgs e)
        {
             
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
