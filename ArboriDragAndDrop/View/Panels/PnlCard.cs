using ArboriDragAndDrop.Arbori;
using ArboriDragAndDrop.Arbori.interfaces;
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms.BunifuButton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArboriDragAndDrop.View.Panels
{
    public class PnlCard : Panel
    {

        Form1 form;
        string data;

       // public BunifuButton btnText;
        BunifuElipse eliThis;
        public TextBox txtText;
        BunifuElipse eliTxt;

        public PnlCard(Form1 form1,string data1) {

            this.form = form1;
            this.data = data1;

            //PnlCard
            this.Size = new System.Drawing.Size(184, 77);
            this.Name = data;
            this.BackColor = System.Drawing.Color.FromArgb(15, 20, 35);
            this.AllowDrop = true;
            this.ForeColor = System.Drawing.Color.White;
            this.MouseDown += this_MouseDown;
            this.DoubleClick += txtText_DoubleClick;

           // this.btnText = new BunifuButton();
            this.eliThis = new BunifuElipse();
            this.txtText = new TextBox();
            this.eliTxt = new BunifuElipse();

            eliTxt.TargetControl = txtText;
            eliTxt.ElipseRadius = 25;

            eliThis.TargetControl = this;
            eliThis.ElipseRadius = 25;

            this.Controls.Add(this.txtText);
            //  this.Controls.Add(this.btnText);

            //txtText
            this.txtText.AllowDrop = true;
            this.txtText.Location = new System.Drawing.Point(2, 9);
            this.txtText.Size = new System.Drawing.Size(181, 59);
            this.txtText.BorderStyle = BorderStyle.None;
            this.txtText.Font = new System.Drawing.Font("Century Gothic", 12);
            this.txtText.Multiline = true;
            this.txtText.ForeColor = System.Drawing.Color.White;
            this.txtText.BackColor = System.Drawing.Color.FromArgb(15, 20, 34);
            this.txtText.Text = data;
            this.txtText.ReadOnly = true;
            this.txtText.Tag = this;
            this.txtText.Dock = DockStyle.Fill;
            this.txtText.MouseDown += this_MouseDown;
            this.txtText.DoubleClick += txtText_DoubleClick;
            this.txtText.TextAlign = HorizontalAlignment.Center;

        }
/*
            // btnText
            this.btnText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnText.Location = new System.Drawing.Point(2, 9);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(181, 59);
            this.btnText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnText.Text = data;
            this.btnText.Dock = DockStyle.Fill;
            this.btnText.AllowDrop = true;*/

        public override string ToString()
        {
            return txtText.Text;
        }

        private void this_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox txt = sender as TextBox;

            this.DoDragDrop(txt, DragDropEffects.Move);

        }

        private void txtText_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("ad");
            this.txtText.ReadOnly = false;

        }

    }
}
