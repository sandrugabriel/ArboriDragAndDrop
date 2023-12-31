﻿using ArboriDragAndDrop.Users.Models;
using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArboriDragAndDrop.View.Panels
{
    public class PnlDelete : Panel
    {


        Form1 form;
        User user;

        Label lblTile;
        PictureBox pct;

        public PnlDelete(Form1 form1, User user1)
        {
            form = form1;
            user = user1;

            this.Size = new System.Drawing.Size(1671, 925);
            this.Location = new System.Drawing.Point(102, 44);
            this.BackColor = Color.FromArgb(15, 20, 54);
            this.Name = "PnlDelete";

            this.lblTile = new Label();
            this.pct = new PictureBox();


            // lblTile
            this.lblTile.AutoSize = true;
            this.lblTile.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTile.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTile.Location = new System.Drawing.Point(60, 42);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(243, 36);
            this.lblTile.TabIndex = 1;
            this.lblTile.Text = "Stergere Figura";

            // pct
            this.pct.BackColor = System.Drawing.SystemColors.Control;
            this.pct.Location = new System.Drawing.Point(51, 77);
            this.pct.Name = "pct";
            this.pct.Size = new System.Drawing.Size(265, 2);
            this.pct.TabIndex = 2;
            this.pct.TabStop = false;

            createCard(5);
        }

        public void createCard(int nr)
        {

            StreamReader streamReader = new StreamReader(Application.StartupPath + @"/data/arbori.txt");

            this.Controls.Clear();

            this.Controls.Add(pct);
            this.Controls.Add(lblTile);

            List<string> list = new List<string>();

            string text = "";

            while ((text = streamReader.ReadLine()) != null)
            {
                if (text.Split('|')[4] == user.Id.ToString())
                    list.Add(text.Split('|')[0].ToString());
            }

            streamReader.Close();
            list = list.Distinct().ToList();


            int x = 59, y = 200, ct = 0;

            foreach (string items in list)
            {
                ct++;
                Button btnCard = new Button();
                BunifuElipse eiBtn;

                eiBtn = new BunifuElipse();

                eiBtn.TargetControl = btnCard;
                eiBtn.ElipseRadius = 25;

                // btnCard
                btnCard.BackColor = System.Drawing.Color.FromArgb(15, 20, 35);
                btnCard.FlatAppearance.BorderSize = 0;
                btnCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnCard.ForeColor = System.Drawing.SystemColors.Control;
                btnCard.Location = new System.Drawing.Point(x, y);
                btnCard.Name = "btnCard";
                btnCard.Size = new System.Drawing.Size(250, 103);
                btnCard.Text = items;
                btnCard.Click += new EventHandler(btnCard_Click);

                this.Controls.Add(btnCard);

                x += 300;

                if (ct % nr == 0)
                {
                    x = 58;
                    y += 150;
                }

                if (y > this.Height)
                {
                    this.AutoScroll = true;
                }




                streamReader.Close();

            }

        }

        public void btnCard_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            string final = "";

            StreamReader streamReader = new StreamReader(Application.StartupPath + @"/data/arbori.txt");

            string text = "";

            while ((text = streamReader.ReadLine()) != null)
            {
                    if (text.Split('|')[0].ToString() != btn.Text)
                    final += text + "\n";
            }

            streamReader.Close();
       //     MessageBox.Show(final);

            StreamWriter streamWriter = new StreamWriter(Application.StartupPath + @"/data/arbori.txt");
            streamWriter.Write(final);

            streamWriter.Close();

             MessageBox.Show($"{btn.Text} s-a sters!","Succes",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.form.removePnl("PnlHome");
            this.form.removePnl("PnlSlideTileBar");
            this.form.removePnl("PnlAdd");
            this.form.removePnl("PnlLoad");
            this.form.removePnl("PnlDelete");
            this.form.Controls.Add(new PnlSlideTileBar(form, user));
            this.form.Controls.Add(new PnlHome(form, user));

        }



    }
}
