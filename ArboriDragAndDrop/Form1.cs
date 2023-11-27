using ArboriDragAndDrop.View.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArboriDragAndDrop
{
    public partial class Form1 : Form
    {
        public int ct = 0;

        public Form1()
        {
            InitializeComponent();

            this.Controls.Add(new PnlDinamicCards(this));

        }

        public void removePnl(string pnl)
        {

            Control control = null;

            foreach (Control c in this.Controls)
            {

                if (c.Name.Equals(pnl))
                {
                    control = c;
                }

            }

            this.Controls.Remove(control);

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
