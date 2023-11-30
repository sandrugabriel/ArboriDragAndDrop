using ArboriDragAndDrop.Users.Models;
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

        public Form1()
        {
            InitializeComponent();
/*            User user = new User("1|gabi|gabi@email.com|gabi1234");

             this.Controls.Add(new PnlSlideTileBar(this,user));
             this.Controls.Add(new PnlHome(this,user));
*/
           this.Controls.Add(new PnlLogin(this));
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

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.close.Location = new System.Drawing.Point(this.Size.Width - 73, 0);
            this.mini.Location = new System.Drawing.Point(this.close.Location.X - 73, 0);
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
