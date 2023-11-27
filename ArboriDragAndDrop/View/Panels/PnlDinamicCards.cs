using ArboriDragAndDrop.Arbori;
using ArboriDragAndDrop.Arbori.interfaces;
using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArboriDragAndDrop.View.Panels
{
    public class PnlDinamicCards : Panel
    {

        Form1 form;

        PnlCard cardPrimul;

        Button btnAddLeft;
        Button btnAddRight;
        BunifuElipse eliBtnRight;
        BunifuElipse eliBtnLeft;
        BunifuElipse eliTxt;

        PnlCard ultimulLeft;
        PnlCard ultimulRight;

        IArbor<PnlCard> arbor;

        List<PnlCard> allCards;
        
        int nr;

        Button btnSave;
        BunifuElipse eliBtn;

        TextBox txtName;
        Label lblName;

        public PnlDinamicCards(Form1 form1) {
        
            this.form = form1;

            this.Name = "PnlDinamicCards";
            this.Size = new System.Drawing.Size(1409, 795);
            this.Font = new System.Drawing.Font("Century Gothic", 12);
            this.AutoScroll = true;
            nr = 1;
            this.cardPrimul = new PnlCard(form,nr.ToString());
            this.btnAddLeft = new Button();
            this.btnAddRight = new Button();
            this.eliBtnLeft = new BunifuElipse();
            this.eliBtnRight = new BunifuElipse();
            this.btnSave = new Button();
            this.eliBtn = new BunifuElipse();
            this.txtName = new TextBox();
            this.eliTxt = new BunifuElipse();
            this.lblName = new Label();
            
            this.Controls.Add(this.cardPrimul);
            this.Controls.Add(btnAddLeft);
            this.Controls.Add(btnAddRight);
            this.Controls.Add(btnSave);
            this.Controls.Add(txtName);
            this.Controls.Add(lblName);

            this.eliTxt.TargetControl = txtName;
            this.eliTxt.ElipseRadius = 25;

            this.eliBtn.TargetControl = btnSave;
            this.eliBtn.ElipseRadius = 25;

            arbor = new Arbor<PnlCard>();

            allCards = new List<PnlCard>();

            this.eliBtnLeft.TargetControl = btnAddLeft;
            this.eliBtnLeft.ElipseRadius = 25;

            this.eliBtnRight.TargetControl = btnAddRight;
            eliBtnRight.ElipseRadius = 25;

            //cardPrimul
            this.cardPrimul.Location = new System.Drawing.Point(730, 130);
            this.cardPrimul.txtText.Visible = true;
            // this.cardPrimul.Size = new System.Drawing.Size(270,77);

            //lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(400, 35);
            this.lblName.Text = "Name: ";
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 23);

            //btnAddRight
            this.btnAddRight.Location = new System.Drawing.Point(958, 247);
            this.btnAddRight.Size = new System.Drawing.Size(184, 77);
            this.btnAddRight.FlatAppearance.BorderSize = 0;
            this.btnAddRight.FlatStyle = FlatStyle.Flat;
            this.btnAddRight.Text = "Add child";
            this.btnAddRight.Cursor = Cursors.Hand;
            this.btnAddRight.Click += new EventHandler(btnAddRight_Click);
            this.btnAddRight.BackColor = System.Drawing.Color.DimGray;

            //btnAddLeft
            this.btnAddLeft.Location = new System.Drawing.Point(556, 247);
            this.btnAddLeft.Size = new System.Drawing.Size(184, 77);
            this.btnAddLeft.FlatAppearance.BorderSize = 0;
            this.btnAddLeft.FlatStyle = FlatStyle.Flat;
            this.btnAddLeft.Text = "Add child";
            this.btnAddLeft.Cursor = Cursors.Hand;
            this.btnAddLeft.Click += new EventHandler(btnAddLeft_Click);
            this.btnAddLeft.BackColor = System.Drawing.Color.DimGray;

            //btnSave
            this.btnSave.Location = new System.Drawing.Point(580, 657);
            this.btnSave.Text = "Save";
            this.btnSave.Size = new System.Drawing.Size(230, 87);
            this.btnSave.BackColor = System.Drawing.Color.DimGray;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 16);
            this.btnSave.Click += new EventHandler(btnSave_Click);

            //txtName
            this.txtName.Location = new System.Drawing.Point(540, 30);
            this.txtName.Size = new System.Drawing.Size(673, 64);
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 19);
            this.txtName.TextAlign = HorizontalAlignment.Center;
            this.txtName.Multiline = true;
            this.txtName.BackColor = System.Drawing.Color.DimGray;
            this.txtName.BorderStyle = BorderStyle.None;
            this.txtName.ForeColor = System.Drawing.Color.Black;

            ultimulLeft = cardPrimul;
            ultimulRight = cardPrimul;

            arbor.add(null, cardPrimul, "");
            nr++;
           // arbor.afisareParinte(cardPrimul);

           allCards.Add(cardPrimul);

        }

        private bool verificare()
        {

            for (int i = 0; i < allCards.Count; i++)
            {
                if (allCards[i].txtText.Text.Equals(""))
                {
                    return false;
                }
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.btnAddLeft.Visible = false;
            this.btnAddRight.Visible = false;

            if(!txtName.Text.Equals(""))
            {
                //arbor.afisare();
                if (verificare())
                {
                    for (int i = 0; i < allCards.Count; i++)
                    {
                        allCards[i].btnText.Text = allCards[i].txtText.Text;
                        allCards[i].Name = allCards[i].btnText.Text;
                        allCards[i].txtText.Visible = false;

                    }
                    arbor.saveFisier(arbor.getNode(), txtName.Text);
                }
                   
                else
                {
                    MessageBox.Show("Nu a-ti completat toate chemarele", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Schema s-a salvat!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else MessageBox.Show("Nu a-ti introdus numele schemei", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        PnlCard parinteLeft4;

        PnlCard parinteleLeftR4;

        int ct = 1;

        int ct1 = 1;

        private void btnAddLeft_Click(object sender, EventArgs e)
        {
            if (ct == 1)
            {
                PnlCard pnlCard = new PnlCard(form, nr.ToString());
                pnlCard.txtText.Visible = true;
                pnlCard.Location = new System.Drawing.Point(ultimulLeft.Location.X - 300, ultimulLeft.Location.Y + 85);

                this.Controls.Add(pnlCard);

                arbor.add(ultimulLeft, pnlCard, "left");

                ultimulLeft = pnlCard;

                btnAddLeft.Location = new System.Drawing.Point(pnlCard.Location.X, pnlCard.Location.Y + 85);
                allCards.Add(pnlCard);
                nr++;
            }
            else
            {
             
                PnlCard pnlCard = new PnlCard(form, nr.ToString());
                pnlCard.txtText.Visible = true;
                pnlCard.Location = new System.Drawing.Point(ultimulLeft.Location.X - 100*(ct/2), ultimulLeft.Location.Y + 85);

                if (ct == 2)
                {
                    parinteLeft4 = pnlCard;
                    arbor.add(ultimulLeft, pnlCard, "left");
                }

                if(ct == 4)
                {

                    pnlCard.Size = new System.Drawing.Size(120, 77);
                    pnlCard.txtText.Size = new System.Drawing.Size(116, 59);
                    pnlCard.Location = new System.Drawing.Point(ultimulLeft.Location.X - 270, ultimulLeft.Location.Y + 85);
                  arbor.add(parinteLeft4, pnlCard, "left");
                }

                PnlCard parint = ultimulLeft;

                this.Controls.Add(pnlCard);

                ultimulLeft = pnlCard;

                btnAddLeft.Location = new System.Drawing.Point(pnlCard.Location.X, pnlCard.Location.Y + 85);

                nr++;

                allCards.Add(pnlCard);

                for (int i = 0; i < ct - 1; i++)
                {

                    PnlCard pnlCard1 = new PnlCard(form, nr.ToString());
                    pnlCard1.txtText.Visible = true;
                    if (ct == 4)
                    {
                        pnlCard1.Size = new System.Drawing.Size(120, 77);
                        pnlCard1.txtText.Size = new System.Drawing.Size(116,59);
                        pnlCard1.Location = new System.Drawing.Point(ultimulLeft.Location.X + 140, ultimulLeft.Location.Y);

                    }
                    else
                    {
                        pnlCard1.Location = new System.Drawing.Point(ultimulLeft.Location.X + 200, ultimulLeft.Location.Y);
                    }


                    if (ct == 2)
                    {
                        parinteleLeftR4 = pnlCard1;
                        arbor.add(parint, pnlCard1, "right");
                    }

                    if(ct==4)
                    {
                        if(i == 0)
                        arbor.add(parinteLeft4, pnlCard1, "right");

                        if(i>0 && i%2 == 1)
                        {
                            arbor.add(parinteleLeftR4, pnlCard1, "left");
                        }
                        else if(i>0 && i % 2 == 0)
                        {
                            arbor.add(parinteleLeftR4,pnlCard1 , "right");
                        }
                    }


                    this.Controls.Add(pnlCard1);
                    ultimulLeft = pnlCard1;
                    allCards.Add(pnlCard1);
                    nr++;
                }

            }
            if(ct== 4)
            {
                btnAddLeft.Visible = false;
            }
            ct *= 2;


        }

        PnlCard parinteleRight4;
        PnlCard parinteleRightL4;

        private void btnAddRight_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(ct1.ToString());
            if (ct1 == 1)
            {
                PnlCard pnlCard = new PnlCard(form, nr.ToString());
                pnlCard.txtText.Visible = true;
                pnlCard.Location = new System.Drawing.Point(ultimulRight.Location.X + 300, ultimulRight.Location.Y + 85);

                this.Controls.Add(pnlCard);

                arbor.add(ultimulRight, pnlCard, "right");

                ultimulRight = pnlCard;

                btnAddRight.Location = new System.Drawing.Point(pnlCard.Location.X, pnlCard.Location.Y + 85);
                allCards.Add(pnlCard);
                nr++;
            }
            else
            {
                PnlCard pnlCard = new PnlCard(form, nr.ToString());
                pnlCard.txtText.Visible = true;
                pnlCard.Location = new System.Drawing.Point(ultimulRight.Location.X + 100*(ct1/2), ultimulRight.Location.Y + 85);

                PnlCard parinte = ultimulRight;
                if (ct1 == 2)
                {
                    parinteleRight4 = pnlCard;
                    arbor.add(ultimulRight, pnlCard, "right");
                }
               
                if (ct1 == 4)
                {

                    pnlCard.Size = new System.Drawing.Size(120, 77);
                    pnlCard.txtText.Size = new System.Drawing.Size(116, 59);
                    pnlCard.Location = new System.Drawing.Point(ultimulRight.Location.X + 340 , ultimulRight.Location.Y + 85);
                    arbor.add(parinteleRight4, pnlCard, "right");
                }
                this.Controls.Add(pnlCard);
                allCards.Add(pnlCard);
                ultimulRight = pnlCard;

                nr++;

                for (int i = 0; i < ct1 - 1; i++)
                {
                    PnlCard pnlCard1 = new PnlCard(form, nr.ToString());
                    pnlCard1.txtText.Visible = true;
                   
                    if (ct1 == 4)
                    {
                        pnlCard1.Size = new System.Drawing.Size(120, 77);
                        pnlCard1.txtText.Size = new System.Drawing.Size(116, 59);
                        pnlCard1.Location = new System.Drawing.Point(ultimulRight.Location.X - 140, ultimulRight.Location.Y);

                    }
                    else
                    {
                        pnlCard1.Location = new System.Drawing.Point(ultimulRight.Location.X - 200, ultimulRight.Location.Y);
                    }

                    if (ct1 == 2)
                    {
                        parinteleRightL4 = pnlCard1;
                        arbor.add(parinte, pnlCard1, "left");
                    }



                    if (ct1 == 4)
                    {
                        if (i == 0)
                            arbor.add(parinteleRight4, pnlCard1, "left");

                        if (i > 0 && i % 2 == 1)
                        {
                            arbor.add(parinteleRightL4, pnlCard1, "right");
                        }

                        if(i>0 && i % 2 == 0)
                        {
                            arbor.add(parinteleRightL4,pnlCard1,"left");
                        }
                    }


                    this.Controls.Add(pnlCard1);
                    ultimulRight = pnlCard1;
                    allCards.Add(pnlCard1);
                    nr++;
                }
                btnAddRight.Location = new System.Drawing.Point(pnlCard.Location.X, pnlCard.Location.Y + 85);
            }

            if (ct1 == 4)
            {
                btnAddRight.Visible = false;
            }
            ct1 *= 2;


        }

        public Button findByText(string text)
        {

            for (int i = 0; i < allCards.Count; i++)
            {
                if (allCards[i].btnText.Text.Equals(text))
                {
                    return allCards[i].btnText;
                }
            }

            return null;
        }

        private PnlCard getPanelFromButton(Button button)
        {
            if (button != null)
                if (button.Tag is PnlCard associatedPanel)
                {
                    return associatedPanel;
                }

            return null;
        }



    }
}
