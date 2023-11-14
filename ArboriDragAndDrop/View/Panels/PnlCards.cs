using ArboriDragAndDrop.Arbori;
using ArboriDragAndDrop.Arbori.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArboriDragAndDrop.View.Panels
{
    public class PnlCards : Panel
    {
        Form1 form;

        private PnlCard card4;
        private PnlCard card5;
        private PnlCard card6;
        private PnlCard card3;
        private PnlCard card7;
        private PnlCard card2;
        private PnlCard card1;
        private System.Windows.Forms.PictureBox pct2;
        private System.Windows.Forms.PictureBox pct1;
        private System.Windows.Forms.PictureBox pct6;
        private System.Windows.Forms.PictureBox pct5;
        private System.Windows.Forms.PictureBox pct4;
        private System.Windows.Forms.PictureBox pct3;

        IArbor<Panel> arbor;

        List<PnlCard> clickCards;

        PnlCard card;

        public PnlCards(Form1 form1) { 
        
            this.form = form1;

            arbor = new Arbor<Panel>();

            card = new PnlCard(form,"");

            //PnlCards
            this.Size = new System.Drawing.Size(1409, 795);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PnlCards";
            this.Dock = DockStyle.Fill;

            clickCards = new List<PnlCard>();

            this.card1 = new PnlCard(form,"Depunty Director");
            this.card2 = new PnlCard(form,"IT Divison");
            this.card3 = new PnlCard(form,"Marketing Head");
            this.card4 = new PnlCard(form,"Security Head");
            this.card5 = new PnlCard(form," Add Development");
            this.card6 = new PnlCard(form,"Logistics Head");
            this.card7 = new PnlCard(form,"Public Relations");
            this.pct1 = new System.Windows.Forms.PictureBox();
            this.pct2 = new System.Windows.Forms.PictureBox();
            this.pct3 = new System.Windows.Forms.PictureBox();
            this.pct4 = new System.Windows.Forms.PictureBox();
            this.pct5 = new System.Windows.Forms.PictureBox();
            this.pct6 = new System.Windows.Forms.PictureBox();


            this.Controls.Add(this.card4);
            this.Controls.Add(this.card5);
            this.Controls.Add(this.card6);
            this.Controls.Add(this.card3);
            this.Controls.Add(this.card7);
            this.Controls.Add(this.card2);
            this.Controls.Add(this.card1);
            this.Controls.Add(this.pct1);
            this.Controls.Add(this.pct2);
            this.Controls.Add(this.pct3);
            this.Controls.Add(this.pct4);
            this.Controls.Add(this.pct5);
            this.Controls.Add(this.pct6);

            // card4
            this.card4.Location = new System.Drawing.Point(245, 468);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(184, 77);
            this.card4.TabIndex = 1;
             
            // card5
            this.card5.Location = new System.Drawing.Point(462, 468);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(184, 77);
            this.card5.TabIndex = 2;
             
            // card6
            this.card6.Location = new System.Drawing.Point(761, 471);
            this.card6.Name = "card6";
            this.card6.Size = new System.Drawing.Size(184, 77);
            this.card6.TabIndex = 3;
             
            // card3
            this.card3.Location = new System.Drawing.Point(863, 362);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(184, 77);
            this.card3.TabIndex = 4;
             
            // card7
            this.card7.Location = new System.Drawing.Point(980, 471);
            this.card7.Name = "card7";
            this.card7.Size = new System.Drawing.Size(184, 77);
            this.card7.TabIndex = 5;
             
            // card2
            this.card2.Location = new System.Drawing.Point(358, 362);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(184, 77);
            this.card2.TabIndex = 6;
             
            // card1
            this.card1.Location = new System.Drawing.Point(616, 246);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(184, 77);
            this.card1.TabIndex = 7;
            
            // pct1
            this.pct1.Image = global::ArboriDragAndDrop.Properties.Resources.up_arrow1;
            this.pct1.Location = new System.Drawing.Point(477, 265);
            this.pct1.Name = "pct1";
            this.pct1.Size = new System.Drawing.Size(199, 104);
            this.pct1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct1.TabIndex = 8;
            this.pct1.TabStop = false;
            
            // pct2
            this.pct2.Image = global::ArboriDragAndDrop.Properties.Resources.up_arrow;
            this.pct2.Location = new System.Drawing.Point(734, 265);
            this.pct2.Name = "pct2";
            this.pct2.Size = new System.Drawing.Size(199, 104);
            this.pct2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct2.TabIndex = 8;
            this.pct2.TabStop = false;
             
            // pct3
            this.pct3.Image = global::ArboriDragAndDrop.Properties.Resources.up_arrow1;
            this.pct3.Location = new System.Drawing.Point(338, 424);
            this.pct3.Name = "pct3";
            this.pct3.Size = new System.Drawing.Size(109, 53);
            this.pct3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct3.TabIndex = 8;
            this.pct3.TabStop = false;
             
            // pct4
            this.pct4.Image = global::ArboriDragAndDrop.Properties.Resources.up_arrow;
            this.pct4.Location = new System.Drawing.Point(472, 424);
            this.pct4.Name = "pct4";
            this.pct4.Size = new System.Drawing.Size(109, 53);
            this.pct4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct4.TabIndex = 8;
            this.pct4.TabStop = false;
             
            // pct5
            this.pct5.Image = global::ArboriDragAndDrop.Properties.Resources.up_arrow1;
            this.pct5.Location = new System.Drawing.Point(846, 424);
            this.pct5.Name = "pct5";
            this.pct5.Size = new System.Drawing.Size(109, 53);
            this.pct5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct5.TabIndex = 8;
            this.pct5.TabStop = false;
             
            // pct6
            this.pct6.Image = global::ArboriDragAndDrop.Properties.Resources.up_arrow;
            this.pct6.Location = new System.Drawing.Point(980, 424);
            this.pct6.Name = "pct6";
            this.pct6.Size = new System.Drawing.Size(109, 53);
            this.pct6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct6.TabIndex = 8;
            this.pct6.TabStop = false;


            arbor.add(null, card1, "left");
            arbor.add(card1, card2, "left");
            arbor.add(card1, card3, "right");
            arbor.add(card2, card4, "left");
            arbor.add(card2, card5, "right");
            arbor.add(card3, card6, "left");
            arbor.add(card3, card7, "right");

        //    arbor.afisare();

            this.card1.btnText.Click += new EventHandler(all_Click);
            this.card2.btnText.Click += new EventHandler(all_Click);
            this.card3.btnText.Click += new EventHandler(all_Click);
            this.card4.btnText.Click += new EventHandler(all_Click);
            this.card5.btnText.Click += new EventHandler(all_Click);
            this.card6.btnText.Click += new EventHandler(all_Click);
            this.card7.btnText.Click += new EventHandler(all_Click);

        }

        private PnlCard getPanelFromButton(Button button)
        {

            if (button.Tag is PnlCard associatedPanel)
            {
                return associatedPanel;
            }

            return null; 
        }

        private void all_Click(object sender, System.EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                form.ct++;
            //    MessageBox.Show(card.ToString());

                if (form.ct == 2)
                {
                    clickCards.Add(getPanelFromButton(clickedButton));
                    arbor.setT(card, clickCards[0]);
                    form.ct = 0;
                    PnlCard pnlCard = card;
                    string text1= clickCards[0].btnText.Text;
                    string text2 = pnlCard.btnText.Text;
                    card.btnText.Text = text1;
                    clickCards[0].btnText.Text = text2;
                    clickCards.Clear();
                }
                else
                {
                    card = getPanelFromButton(clickedButton);
                }

            }
        }


    }
}
