using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class Content : Form
    {
        public Content()
        {
            InitializeComponent();

            //btnClose.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void Content_Load(object sender, EventArgs e)
        {
      

        }

        private void BtcClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
            
        }



    }
}
