using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuAnimatorNS;
using Bunifu.UI.WinForms.Extensions;
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
    public partial class MockupLogin : Form
    {
        public MockupLogin()
        {
            InitializeComponent();

           // MessageBox.Show(this.Size.Width.ToString() + " " + this.Size.Height.ToString());
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void max_Click(object sender, EventArgs e)
        {
        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pctVisible_Click(object sender, EventArgs e)
        {

        }

        private void pctHidden_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

        }

        private void linkForgot_Click(object sender, EventArgs e)
        {

        }
    }
}
