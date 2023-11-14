using ArboriDragAndDrop.Arbori;
using ArboriDragAndDrop.Arbori.interfaces;
using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArboriDragAndDrop.View.Panels
{
    public class PnlCard : Panel
    {

        Form1 form;
        string data;

        public System.Windows.Forms.Button btnText;
        BunifuElipse eliThis;


        public PnlCard(Form1 form1,string data1) {

            this.form = form1;
            this.data = data1;

            //PnlCard
            this.Size = new System.Drawing.Size(184, 77);
            this.Name = "PnlCard";
            this.BackColor = System.Drawing.Color.DimGray;

            this.btnText = new System.Windows.Forms.Button();
            this.eliThis = new BunifuElipse();

            eliThis.TargetControl = this;
            eliThis.ElipseRadius = 25;

            this.Controls.Add(this.btnText);

            // btnText
            this.btnText.AutoEllipsis = true;
            this.btnText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnText.Location = new System.Drawing.Point(2, 9);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(181, 59);
            this.btnText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnText.Text = data;
            this.btnText.FlatStyle = FlatStyle.Flat;
            this.btnText.FlatAppearance.BorderSize = 0;
            this.btnText.Dock = DockStyle.Fill;
            this.btnText.Tag = this;

        }

        public override string ToString()
        {
            return btnText.Text;
        }

    

    }
}
