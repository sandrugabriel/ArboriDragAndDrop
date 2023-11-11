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

        private System.Windows.Forms.Label label1;

        public PnlCard(Form1 form1,string data1) {

            this.form = form1;
            this.data = data1;

            //PnlCard
            this.ClientSize = new System.Drawing.Size(184, 77);
            this.Name = "PnlCard";

            this.label1 = new System.Windows.Forms.Label();

            this.Controls.Add(this.label1);

            // label1
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = data;

            this.Click += new EventHandler(all_Click);
            this.label1.Click += new EventHandler(all_Click);
        }

        private void all_Click(object sender, System.EventArgs e)
        {




        }

    }
}
