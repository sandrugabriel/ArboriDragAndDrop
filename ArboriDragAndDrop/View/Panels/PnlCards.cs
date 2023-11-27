using ArboriDragAndDrop.Arbori;
using ArboriDragAndDrop.Arbori.interfaces;
using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ZBobb;

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
        private Button btnSave;
        private BunifuElipse eliBtn;
        private TextBox txtName;
        private Label lblName;
        private BunifuElipse eliLbl;
        private Button btnAdd;

        private PictureBox pctDesign;
        private Label lblTile;
        private Button btnPrimul;

        private Panel pnlSlide;


        IArbor<Panel> arbor;

        List<PnlCard> clickCards;

        PnlCard card;

        List<PnlCard> allCards;

        Button btnUlt;

        public PnlCards(Form1 form1) { 
        
            this.form = form1;

            arbor = new Arbor<Panel>();

            card = new PnlCard(form,"");

            btnUlt = new Button();

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
            this.card5 = new PnlCard(form,"Add Development");
            this.card6 = new PnlCard(form,"Logistics Head");
            this.card7 = new PnlCard(form,"Public Relations");
            this.pct1 = new System.Windows.Forms.PictureBox();
            this.pct2 = new System.Windows.Forms.PictureBox();
            this.pct3 = new System.Windows.Forms.PictureBox();
            this.pct4 = new System.Windows.Forms.PictureBox();
            this.pct5 = new System.Windows.Forms.PictureBox();
            this.pct6 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.eliBtn = new BunifuElipse();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new TextBox();
            this.eliLbl = new BunifuElipse();
            this.pctDesign = new PictureBox();
            this.lblTile = new Label();
            this.btnPrimul = new System.Windows.Forms.Button();
            this.pnlSlide = new Panel();
            this.btnAdd = new Button();

            eliLbl.TargetControl = txtName;
            eliLbl.ElipseRadius = 25;

            eliBtn.TargetControl = btnSave;
            eliBtn.ElipseRadius = 25;

            this.Controls.Add(pnlSlide);
            this.pnlSlide.Controls.Add(pctDesign);
            this.pnlSlide.Controls.Add(lblTile);
            this.pnlSlide.Controls.Add(btnPrimul);
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
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.pnlSlide.Controls.Add(this.btnAdd);

            //btnAdd
            this.btnAdd.Location = new System.Drawing.Point(0, 206);
            this.btnAdd.Size = new System.Drawing.Size(225, 77);
            this.btnAdd.Text = "Add Schema";
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = FlatStyle.Flat;
            this.btnAdd.Cursor = Cursors.Hand;
            this.btnAdd.AutoEllipsis = true;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 14);
            this.btnAdd.Click += new EventHandler(btnAdd_Click);

            //pnlSlide
            this.pnlSlide.Location = new System.Drawing.Point(0,0);
            this.pnlSlide.Size = new System.Drawing.Size(225, 795);
            this.pnlSlide.BackColor = System.Drawing.SystemColors.AppWorkspace;

            //pctDesign
            this.pctDesign.Location = new System.Drawing.Point(28, 157);
            this.pctDesign.Size = new System.Drawing.Size(197, 2);
            this.pctDesign.BackColor = System.Drawing.Color.Black;

            //lbblTile
            this.lblTile.Location = new System.Drawing.Point(37, 119);
            this.lblTile.AutoSize = true;
            this.lblTile.Font = new System.Drawing.Font("Century Gothic", 20);
            this.lblTile.Text = "Scheme";

            //btnPrimul
            this.btnPrimul.Location = new System.Drawing.Point(0, this.btnAdd.Location.Y + 85);
            this.btnPrimul.Size = new System.Drawing.Size(225, 77);
            this.btnPrimul.FlatAppearance.BorderSize = 0;
            this.btnPrimul.FlatStyle = FlatStyle.Flat;
            this.btnPrimul.Text = "schema principala";
            this.btnPrimul.Font = new System.Drawing.Font("Century Gothic", 14);
            this.btnPrimul.AutoEllipsis = true;
            this.btnPrimul.Cursor = Cursors.Hand;
            this.btnPrimul.Click += new EventHandler(btnPrim_Click);

            //lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(631, 25);
            this.lblName.Text = "Name";
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 23);

            //txtName
            this.txtName.Location = new System.Drawing.Point(371, 77);
            this.txtName.Size = new System.Drawing.Size(673, 64);
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 19);
            this.txtName.TextAlign = HorizontalAlignment.Center;
            this.txtName.Multiline = true;
            this.txtName.BackColor = System.Drawing.Color.DimGray;
            this.txtName.BorderStyle = BorderStyle.None;
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Visible = false;

            //btnSave
            this.btnSave.Location = new System.Drawing.Point(580, 657);
            this.btnSave.Text = "Save";
            this.btnSave.Size = new System.Drawing.Size(230, 87);
            this.btnSave.BackColor = System.Drawing.Color.DimGray;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 16);
            this.btnSave.Click += new EventHandler(btnSave_Click);

            // card4
            this.card4.Location = new System.Drawing.Point(245, 468);
            this.card4.Name = "Security Head";
            this.card4.Size = new System.Drawing.Size(184, 77);
            this.card4.TabIndex = 1;
             
            // card5
            this.card5.Location = new System.Drawing.Point(462, 468);
            this.card5.Name = "Add Development";
            this.card5.Size = new System.Drawing.Size(184, 77);
            this.card5.TabIndex = 2;
             
            // card6
            this.card6.Location = new System.Drawing.Point(761, 471);
            this.card6.Name = "Logistics Head";
            this.card6.Size = new System.Drawing.Size(184, 77);
            this.card6.TabIndex = 3;
             
            // card3
            this.card3.Location = new System.Drawing.Point(863, 362);
            this.card3.Name = "Marketing Head";
            this.card3.Size = new System.Drawing.Size(184, 77);
            this.card3.TabIndex = 4;
             
            // card7
            this.card7.Location = new System.Drawing.Point(980, 471);
            this.card7.Name = "Public Relations";
            this.card7.Size = new System.Drawing.Size(184, 77);
            this.card7.TabIndex = 5;
             
            // card2
            this.card2.Location = new System.Drawing.Point(358, 362);
            this.card2.Name = "IT Divison";
            this.card2.Size = new System.Drawing.Size(184, 77);
            this.card2.TabIndex = 6;
             
            // card1
            this.card1.Location = new System.Drawing.Point(616, 246);
            this.card1.Name = "Depunty Director";
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

            this.card1.btnText.DragDrop += all_DragDrop;
            this.card2.btnText.DragDrop += all_DragDrop;
            this.card3.btnText.DragDrop += all_DragDrop;
            this.card4.btnText.DragDrop += all_DragDrop;
            this.card5.btnText.DragDrop += all_DragDrop;
            this.card6.btnText.DragDrop += all_DragDrop;
            this.card7.btnText.DragDrop += all_DragDrop;

            this.card1.btnText.DragEnter += all_DragEnter;
            this.card2.btnText.DragEnter += all_DragEnter;
            this.card3.btnText.DragEnter += all_DragEnter;
            this.card4.btnText.DragEnter += all_DragEnter;
            this.card5.btnText.DragEnter += all_DragEnter;
            this.card6.btnText.DragEnter += all_DragEnter;
            this.card7.btnText.DragEnter += all_DragEnter;

            allCards = new List<PnlCard>();

            allCards.Add(card1);
            allCards.Add(card2);
            allCards.Add(card3);
            allCards.Add(card4);
            allCards.Add(card5);
            allCards.Add(card6);
            allCards.Add(card7);

            //MessageBox.Show(arbor.getNode().Data.Name);

            btnUlt = btnPrimul;

            pnlSlide.AutoScroll = true;

            loadBar();

        }

        public void btnAdd_Click(object sender, EventArgs e)
        {



        }

        public void loadBar()
        {

            StreamReader streamReader = new StreamReader(Application.StartupPath + @"/data/arbori.txt");

            string text = "";
            int ct = 0;

            while((text = streamReader.ReadLine()) != null)
            {
                string[] prop = text.Split('|');
                if (ct == 3 && !prop[0].Equals("schema principala"))
                {
                    Button btn = new Button();

                    btn.Location = new System.Drawing.Point(0, btnUlt.Location.Y + 85);
                    btn.Size = new System.Drawing.Size(225, 77);
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Text = prop[0];
                    btn.Font = new System.Drawing.Font("Century Gothic", 14);
                    btn.AutoEllipsis = true;
                    btn.Cursor = Cursors.Hand;
                    btn.Click += new EventHandler(btnPrim_Click);

                    this.pnlSlide.Controls.Add(btn);

                    btnUlt = btn;
                    ct = 0;
                }

                ct++;
               // MessageBox.Show(text);
            }

            streamReader.Close();

        }

        public PnlCard findByName(string name)
        {
                foreach (Control control in Controls)
                {
                    if (control is PnlCard panel && panel.Name == name)
                    {
                        return panel;
                    }
                }

            return null;
        }

        private void btnPrim_Click(object sender, EventArgs e)
        {


            if(sender is Button button)
            {


                string nameBtn = button.Text;

                if (nameBtn == "schema principala")
                {
                    this.form.removePnl("PnlCards");
                    this.form.Controls.Add(new PnlCards(form));
                }

                StreamReader reader = new StreamReader(Application.StartupPath +@"/data/arbori.txt");
                string text = "";
                int ct = 0;

                while ((text = reader.ReadLine()) != null)
                {

                    string[] prop = text.Split('|');
                    if (prop[0] == nameBtn)
                    {
                        if (ct == 0)
                        {


                            PnlCard sursa1 = findByName(prop[1]);

                            arbor.setT(sursa1, card2);
                            string text1 = sursa1.Name;
                            card2.btnText.Text = text1;
                            card2.Name = sursa1.Name;

                            PnlCard sursa = findByName(prop[2]);

                            arbor.setT(sursa, card1);
                            string text11 = sursa.Name;
                            card1.btnText.Text = text11;
                            card1.Name = sursa.Name;

                            PnlCard sursa2 = findByName(prop[3]);

                            arbor.setT(sursa2, card3);
                            string text_1 = sursa2.Name;
                            string text_2 = card3.Name;
                            card3.btnText.Text = text_1;
                            sursa2.btnText.Text = text_2;
                            card3.Name = sursa2.Name;
                        }

                        if (ct == 1)
                        {
/*
                            PnlCard sursa = findByName(prop[1]);

                            arbor.setT(sursa, card4);*/
                            string text1 = prop[1];
                            card4.btnText.Text = text1;
                            card4.Name = prop[1];


/*
                            PnlCard sursa1 = findByName(prop[3]);

                            arbor.setT(sursa1, card5);*/
                            string text_1 = prop[3];
                            card5.btnText.Text = text_1;
                            card5.Name = prop[3];

                        }

                        if (ct == 2)
                        {

                            string text1 = prop[1];
                            card6.btnText.Text = text1;
                            card6.Name = prop[1];


                            string text_1 = prop[3];
                            card7.btnText.Text = text_1;
                            card7.Name = prop[3];

                        }

                        ct++;
                    }
                   
                }


                reader.Close();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!txtName.Text.Equals(""))
            {
                arbor.saveFisier(arbor.getNode(), txtName.Text);

                btnUlt = btnPrimul;

                this.pnlSlide.Controls.Clear();

                this.pnlSlide.Controls.Add(pctDesign);
                this.pnlSlide.Controls.Add(lblTile);
                this.pnlSlide.Controls.Add(btnAdd);
                this.pnlSlide.Controls.Add(btnPrimul);

                loadBar();
            }
                
            else MessageBox.Show("Introduceti numele schemei!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private PnlCard getPanelFromButton(Button button)
        {
            if( button != null )
            if (button.Tag is PnlCard associatedPanel)
            {
                return associatedPanel;
            }

            return null; 
        }

        Button drag;
        int ct = 0;

        private void all_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            if (sender is Button button && ct == 0)
            {
                drag = button;
                ct++;
            }
            if (ct == 2) ct = 0;
               
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

        public void setPnl(string name,string text)
        {


            for (int i = 0; i < allCards.Count; i++)
            {
                if (allCards[i].Name.Equals(name))
                {
                    allCards[i].btnText.Text = text;
                }
            }

        }

        private void all_DragDrop(object sender, DragEventArgs e)
        {

            string text = sender.ToString().Remove(0, 35);
            Button btnDestinatie = findByText(text);
            PnlCard destinatie = getPanelFromButton(btnDestinatie);

            Button btnsura = drag;
            PnlCard sura = getPanelFromButton(btnsura);

            arbor.setT(sura,destinatie);
            string text1 = sura.btnText.Text;
            string text2 = destinatie.btnText.Text;
            destinatie.btnText.Text = text1;
            sura.btnText.Text = text2;
            ct = 0;
         //   arbor.afisare();
        }





    }
}
