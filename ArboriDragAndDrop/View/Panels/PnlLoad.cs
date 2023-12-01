using ArboriDragAndDrop.Arbori;
using ArboriDragAndDrop.Arbori.interfaces;
using ArboriDragAndDrop.Users.Models;
using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.PeerToPeer.Collaboration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ArboriDragAndDrop.View.Panels
{
    public class PnlLoad : Panel
    {

        Form1 form;
        User user;
        string text;

        IArbor<PnlCard> arbor;

        List<PnlCard> allCards;

        Button btnSave;
        BunifuElipse elipse;

        Button btnEdit;
        BunifuElipse elipse2;

        Button btnS;
        BunifuElipse elipse3;

        Label lblName;

        string name;

        public PnlLoad(Form1 form1, User user1, string text1) { 
        
            this.form = form1;
            this.user = user1;
            this.text = text1;
            this.Name = "PnlLoad";
            arbor = new Arbor<PnlCard>();

            allCards = new List<PnlCard>();
            this.btnSave = new Button();

            this.Size = new System.Drawing.Size(1671, 925);
            this.Location = new System.Drawing.Point(102, 44);
            this.BackColor = Color.FromArgb(15, 20, 54);

            this.Controls.Add(btnSave);
            this.lblName = new Label();
            this.Controls.Add(lblName);

            this.btnEdit = new Button();
            this.btnS = new Button();

            this.Controls.Add(btnEdit);
            this.Controls.Add(btnS);

            this.elipse = new BunifuElipse();
            this.elipse2 = new BunifuElipse();
            this.elipse3 = new BunifuElipse();

            //lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(550, 55);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 25,FontStyle.Bold);

            //btnSave
            this.btnSave.Location = new System.Drawing.Point(500, 700);
            this.btnSave.Text = "Update";
            this.btnSave.Size = new System.Drawing.Size(250, 95);
            this.btnSave.BackColor = System.Drawing.Color.DimGray;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 16);
            this.btnSave.Click += new EventHandler(btnSave_Click);
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(15, 20, 35);
            this.btnSave.ForeColor = System.Drawing.Color.White;

            this.elipse.TargetControl = btnSave;
            this.elipse.ElipseRadius = 25;

            //btnEdit
            this.btnEdit.Location = new System.Drawing.Point(800, 700);
            this.btnEdit.Text = "Edit Text";
            this.btnEdit.Size = new System.Drawing.Size(250, 95);
            this.btnEdit.BackColor = System.Drawing.Color.DimGray;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 16);
            this.btnEdit.Click += new EventHandler(btnEdit_Click);
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(15, 20, 35);
            this.btnEdit.ForeColor = System.Drawing.Color.White;

            this.elipse.TargetControl = btnEdit;
            this.elipse.ElipseRadius = 25;

            //btnS
            this.btnS.Location = new System.Drawing.Point(800, 700);
            this.btnS.Text = "Save Names";
            this.btnS.Size = new System.Drawing.Size(250, 95);
            this.btnS.BackColor = System.Drawing.Color.DimGray;
            this.btnS.FlatAppearance.BorderSize = 0;
            this.btnS.FlatStyle = FlatStyle.Flat;
            this.btnS.Font = new System.Drawing.Font("Century Gothic", 16);
            this.btnS.Click += new EventHandler(btnS_Click);
            this.btnS.BackColor = System.Drawing.Color.FromArgb(15, 20, 35);
            this.btnS.ForeColor = System.Drawing.Color.White;
            this.btnS.Visible = false;

            this.elipse.TargetControl = btnS;
            this.elipse.ElipseRadius = 25;


            DimanicCards();
        }


        public void DimanicCards()
        {

            string[] prop = text.Split('\n');
            int ct = 0;
            for (int i = 0; i < prop.Length - 1; i++)
            {
                string t = prop[i];
                string[] p = t.Split('|');
                this.lblName.Text ="Numele schemei: " + p[0] ;
                name = p[0];

                if (i == 0)
                {

                    PnlCard pnlLeft = new PnlCard(form, p[1]);
                    PnlCard pnlRight = new PnlCard(form, p[3]);
                    PnlCard pnlMain = new PnlCard(form, p[2]);

                    this.Controls.Add(pnlMain);
                    this.Controls.Add(pnlLeft);
                    this.Controls.Add(pnlRight);

                    pnlMain.Location = new Point(720, 200);
                    pnlLeft.Location = new Point(420, 300);
                    pnlRight.Location = new Point(1020, 300);
                    pnlMain.txtText.DragEnter += all_DragEnter;
                    pnlMain.txtText.DragDrop += all_DragDrop;
                    pnlLeft.txtText.DragEnter += all_DragEnter;
                    pnlLeft.txtText.DragDrop += all_DragDrop;
                    pnlRight.txtText.DragEnter += all_DragEnter;
                    pnlRight.txtText.DragDrop += all_DragDrop;



                    arbor.add(null, pnlMain, "");

                    arbor.add(pnlMain, pnlLeft, "left");
                    arbor.add(pnlMain, pnlRight, "right");

                    allCards.Add(pnlMain);
                    allCards.Add(pnlLeft);
                    allCards.Add(pnlRight);


                }
                else
                {

                    PnlCard pnlLeft = new PnlCard(form, p[1]);
                    PnlCard pnlRight = new PnlCard(form, p[3]);

                    arbor.add(findCard(p[2]), pnlLeft, "left");
                    arbor.add(findCard(p[2]), pnlRight, "right");

                    if (ct >= 3)
                    {
                        pnlLeft.Size = new Size(90, 77);
                        pnlRight.Size = new Size(90, 77);
                        pnlLeft.txtText.Size = new System.Drawing.Size(80, 59);
                        pnlLeft.txtText.Size = new System.Drawing.Size(80, 59);

                        pnlLeft.Location = new Point(findCard(p[2]).Location.X - 15, findCard(p[2]).Location.Y + 100);
                        pnlRight.Location = new Point(findCard(p[2]).Location.X + 15 + 90, findCard(p[2]).Location.Y + 100);

                    }
                    else
                    {

                        pnlLeft.Location = new Point(findCard(p[2]).Location.X - 110, findCard(p[2]).Location.Y + 100);
                        pnlRight.Location = new Point(findCard(p[2]).Location.X + 110, findCard(p[2]).Location.Y + 100);

                    }

                    pnlLeft.txtText.DragEnter += all_DragEnter;
                    pnlLeft.txtText.DragDrop += all_DragDrop;
                    pnlRight.txtText.DragEnter += all_DragEnter;
                    pnlRight.txtText.DragDrop += all_DragDrop;

                    this.Controls.Add(pnlLeft);
                    this.Controls.Add(pnlRight);


                    allCards.Add(pnlLeft);
                    allCards.Add(pnlRight);

                }
                ct++;


                // MessageBox.Show(prop[i]);
            }
            // arbor.afisareParinte(allCards[3]);


        }


        private void btnS_Click(object sender, EventArgs e)
        {

            this.btnEdit.Visible = true;
            this.btnS.Visible = false;

            for (int i = 0; i < allCards.Count; i++)
            {
                allCards[i].txtText.Text = allCards[i].txtText.Text;
                allCards[i].Name = allCards[i].txtText.Text;
                allCards[i].txtText.ReadOnly = false;
            }


            StreamReader streamReader = new StreamReader(Application.StartupPath + @"/data/arbori.txt");

            string t = "";

            string final = "";

            while ((t = streamReader.ReadLine()) != null)
            {
                if (t.Split('|')[0] != name)
                    final += t + "\n";
            }

            streamReader.Close();

            //  MessageBox.Show(final);
            final += arbor.update(arbor.getNode(), name, user.Id.ToString());

            StreamWriter streamWriter = new StreamWriter(Application.StartupPath + @"/data/arbori.txt");
            streamWriter.Write(final);

            streamWriter.Close();

            this.form.removePnl("PnlHome");
            this.form.removePnl("PnlSlideTileBar");
            this.form.removePnl("PnlAdd");
            this.form.removePnl("PnlLoad");
            this.form.removePnl("PnlDelete");
            this.form.Controls.Add(new PnlSlideTileBar(form, user));
            this.form.Controls.Add(new PnlLoad(form, user, arbor.update(arbor.getNode(), name, user.Id.ToString())));
        }
        

        private void btnEdit_Click(object sender, EventArgs e) {

            this.btnEdit.Visible = false;
            this.btnS.Visible = true;
            for (int i = 0; i < allCards.Count; i++)
            {
                allCards[i].txtText.Visible = true;
            }
        
        }

        public PnlCard findCard(string text)
        {

            for(int i=0;i<allCards.Count;i++)
            {
                if (allCards[i].txtText.Text == text)
                    return allCards[i];
            }

            return null;
        }

        TextBox drag;
        int ct = 0;

        private void all_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            if (sender is TextBox button && ct == 0)
            {
                drag = button;
                ct++;
            }
            if (ct == 2) ct = 0;

        }

        public TextBox findByText(string text)
        {

            for (int i = 0; i < allCards.Count; i++)
            {
                if (allCards[i].txtText.Text.Equals(text))
                {
                    return allCards[i].txtText;
                }
            }

            return null;
        }

        public void setPnl(string name, string text)
        {


            for (int i = 0; i < allCards.Count; i++)
            {
                if (allCards[i].Name.Equals(name))
                {
                    allCards[i].txtText.Text = text;
                }
            }

        }

        private PnlCard getPanelFromButton(TextBox button)
        {
            if (button != null)
                if (button.Tag is PnlCard associatedPanel)
                {
                    return associatedPanel;
                }

            return null;
        }

        private void all_DragDrop(object sender, DragEventArgs e)
        {

            string text = sender.ToString().Remove(0, 36);
            TextBox btnDestinatie = findByText(text);
            PnlCard destinatie = getPanelFromButton(btnDestinatie);

            TextBox btnsura = drag;
            PnlCard sura = getPanelFromButton(btnsura);

            arbor.setT(sura, destinatie);
            string text1 = sura.txtText.Text;
            string text2 = destinatie.txtText.Text;
            destinatie.txtText.Text = text1;
            sura.txtText.Text = text2;
            ct = 0;
            //   arbor.afisare();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            StreamReader streamReader = new StreamReader(Application.StartupPath + @"/data/arbori.txt");

            string t = "";

            string final = "";

            while((t = streamReader.ReadLine()) != null)
            {
                if (t.Split('|')[0] != name)
                    final += t + "\n";
            }

            streamReader.Close();

          //  MessageBox.Show(final);
            final += arbor.update(arbor.getNode(), name,user.Id.ToString());

            StreamWriter streamWriter = new StreamWriter(Application.StartupPath + @"/data/arbori.txt");
            streamWriter.Write(final);

            streamWriter.Close();


            this.form.removePnl("PnlHome");
            this.form.removePnl("PnlSlideTileBar");
            this.form.removePnl("PnlAdd");
            this.form.removePnl("PnlLoad");
            this.form.removePnl("PnlDelete");
            this.form.Controls.Add(new PnlSlideTileBar(form, user));
            this.form.Controls.Add(new PnlLoad(form, user, arbor.update(arbor.getNode(), name, user.Id.ToString())));
            MessageBox.Show("Figura s-a salvat in fisier!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



    }
}
