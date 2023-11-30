using ArboriDragAndDrop.Users.Models;
using ArboriDragAndDrop.Users.Services;
using ArboriDragAndDrop.Users.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArboriDragAndDrop.View.Panels
{
    public class PnlLogin : Panel
    {
        Form1 form;

        private Bunifu.Framework.UI.BunifuElipse eliBtnSign;
        private Bunifu.Framework.UI.BunifuElipse elilblTile;
        private Bunifu.Framework.UI.BunifuElipse eliSignIn;
        private Bunifu.UI.WinForms.BunifuGradientPanel pnlGradient;
        private System.Windows.Forms.LinkLabel linkForgot;
        private Bunifu.UI.WinForms.BunifuTextBox txtPass;
        private Bunifu.UI.WinForms.BunifuTextBox txtEmail;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.Label lblEmail;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSignUp;
        private System.Windows.Forms.Label lblSign;
        private Bunifu.UI.WinForms.BunifuLabel lblPers;
        private System.Windows.Forms.Panel pnlDesign;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSignIn;
        private System.Windows.Forms.Label lblErorPass;
        private System.Windows.Forms.Label lblErrorEmail;

        IServiceUsers serviceUsers;

        public PnlLogin(Form1 form1) {

            form = form1;

            serviceUsers = ServiceUsersSingletion.Instance;

            //PnlLogin
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.Size = new System.Drawing.Size(1776, 925);
            this.Dock = DockStyle.Fill;
            this.Font = new System.Drawing.Font("Comfortaa", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PnlLogin";
            this.Resize += new EventHandler(this_Resize);

            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MockupLogin));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.eliBtnSign = new Bunifu.Framework.UI.BunifuElipse();
            this.btnSignUp = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.elilblTile = new Bunifu.Framework.UI.BunifuElipse();
            this.lblPers = new Bunifu.UI.WinForms.BunifuLabel();
            this.eliSignIn = new Bunifu.Framework.UI.BunifuElipse();
            this.btnSignIn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlGradient = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.linkForgot = new System.Windows.Forms.LinkLabel();
            this.txtPass = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtEmail = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblTile = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pnlDesign = new System.Windows.Forms.Panel();
            this.lblSign = new System.Windows.Forms.Label();
            this.lblErorPass = new System.Windows.Forms.Label();
            this.lblErrorEmail = new System.Windows.Forms.Label();

            this.Controls.Add(this.pnlGradient);
             
            // eliBtnSign
            this.eliBtnSign.ElipseRadius = 20;
            this.eliBtnSign.TargetControl = this.btnSignUp;
             
            // btnSignUp
            this.btnSignUp.AllowAnimations = true;
            this.btnSignUp.AllowMouseEffects = true;
            this.btnSignUp.AllowToggling = false;
            this.btnSignUp.AnimationSpeed = 200;
            this.btnSignUp.AutoGenerateColors = false;
            this.btnSignUp.AutoRoundBorders = false;
            this.btnSignUp.AutoSizeLeftIcon = true;
            this.btnSignUp.AutoSizeRightIcon = true;
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignUp.BackgroundImage")));
            this.btnSignUp.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSignUp.ButtonText = "Sign Up";
            this.btnSignUp.ButtonTextMarginLeft = 0;
            this.btnSignUp.ColorContrastOnClick = 45;
            this.btnSignUp.ColorContrastOnHover = 45;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnSignUp.CustomizableEdges = borderEdges2;
            this.btnSignUp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSignUp.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSignUp.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnSignUp.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnSignUp.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSignUp.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.IconLeft = null;
            this.btnSignUp.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignUp.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSignUp.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSignUp.IconMarginLeft = 11;
            this.btnSignUp.IconPadding = 10;
            this.btnSignUp.IconRight = null;
            this.btnSignUp.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSignUp.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSignUp.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSignUp.IconSize = 25;
            this.btnSignUp.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnSignUp.IdleBorderRadius = 0;
            this.btnSignUp.IdleBorderThickness = 0;
            this.btnSignUp.IdleFillColor = System.Drawing.Color.Empty;
            this.btnSignUp.IdleIconLeftImage = null;
            this.btnSignUp.IdleIconRightImage = null;
            this.btnSignUp.IndicateFocus = false;
            this.btnSignUp.Location = new System.Drawing.Point(1017, 35);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSignUp.OnDisabledState.BorderRadius = 1;
            this.btnSignUp.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSignUp.OnDisabledState.BorderThickness = 1;
            this.btnSignUp.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSignUp.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSignUp.OnDisabledState.IconLeftImage = null;
            this.btnSignUp.OnDisabledState.IconRightImage = null;
            this.btnSignUp.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnSignUp.onHoverState.BorderRadius = 1;
            this.btnSignUp.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSignUp.onHoverState.BorderThickness = 1;
            this.btnSignUp.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSignUp.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.onHoverState.IconLeftImage = null;
            this.btnSignUp.onHoverState.IconRightImage = null;
            this.btnSignUp.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(31)))), ((int)(((byte)(70)))));
            this.btnSignUp.OnIdleState.BorderRadius = 1;
            this.btnSignUp.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSignUp.OnIdleState.BorderThickness = 1;
            this.btnSignUp.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(31)))), ((int)(((byte)(95)))));
            this.btnSignUp.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.OnIdleState.IconLeftImage = null;
            this.btnSignUp.OnIdleState.IconRightImage = null;
            this.btnSignUp.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSignUp.OnPressedState.BorderRadius = 1;
            this.btnSignUp.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSignUp.OnPressedState.BorderThickness = 1;
            this.btnSignUp.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSignUp.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.OnPressedState.IconLeftImage = null;
            this.btnSignUp.OnPressedState.IconRightImage = null;
            this.btnSignUp.Size = new System.Drawing.Size(144, 46);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignUp.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSignUp.TextMarginLeft = 0;
            this.btnSignUp.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSignUp.UseDefaultRadiusAndThickness = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            
            // elilblTile
            this.elilblTile.ElipseRadius = 25;
            this.elilblTile.TargetControl = this.lblPers;
             
            // lblPers
            this.lblPers.AllowParentOverrides = false;
            this.lblPers.AutoEllipsis = false;
            this.lblPers.AutoSize = false;
            this.lblPers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(20)))), ((int)(((byte)(42)))));
            this.lblPers.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPers.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblPers.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPers.ForeColor = System.Drawing.Color.White;
            this.lblPers.Location = new System.Drawing.Point(621, 195);
            this.lblPers.Name = "lblPers";
            this.lblPers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPers.Size = new System.Drawing.Size(537, 50);
            this.lblPers.TabIndex = 12;
            this.lblPers.Text = "Personal";
            this.lblPers.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPers.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
             
            // eliSignIn
            this.eliSignIn.ElipseRadius = 25;
            this.eliSignIn.TargetControl = this.btnSignIn;
            
            // btnSignIn
            this.btnSignIn.AllowAnimations = true;
            this.btnSignIn.AllowMouseEffects = true;
            this.btnSignIn.AllowToggling = false;
            this.btnSignIn.AnimationSpeed = 200;
            this.btnSignIn.AutoGenerateColors = false;
            this.btnSignIn.AutoRoundBorders = false;
            this.btnSignIn.AutoSizeLeftIcon = true;
            this.btnSignIn.AutoSizeRightIcon = true;
            this.btnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSignIn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignIn.BackgroundImage")));
            this.btnSignIn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSignIn.ButtonText = "Sign In";
            this.btnSignIn.ButtonTextMarginLeft = 0;
            this.btnSignIn.ColorContrastOnClick = 45;
            this.btnSignIn.ColorContrastOnHover = 45;
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSignIn.CustomizableEdges = borderEdges1;
            this.btnSignIn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSignIn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSignIn.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnSignIn.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnSignIn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSignIn.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.IconLeft = null;
            this.btnSignIn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignIn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSignIn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSignIn.IconMarginLeft = 11;
            this.btnSignIn.IconPadding = 10;
            this.btnSignIn.IconRight = null;
            this.btnSignIn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSignIn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSignIn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSignIn.IconSize = 25;
            this.btnSignIn.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnSignIn.IdleBorderRadius = 0;
            this.btnSignIn.IdleBorderThickness = 0;
            this.btnSignIn.IdleFillColor = System.Drawing.Color.Empty;
            this.btnSignIn.IdleIconLeftImage = null;
            this.btnSignIn.IdleIconRightImage = null;
            this.btnSignIn.IndicateFocus = false;
            this.btnSignIn.Location = new System.Drawing.Point(621, 661);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSignIn.OnDisabledState.BorderRadius = 1;
            this.btnSignIn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSignIn.OnDisabledState.BorderThickness = 1;
            this.btnSignIn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSignIn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSignIn.OnDisabledState.IconLeftImage = null;
            this.btnSignIn.OnDisabledState.IconRightImage = null;
            this.btnSignIn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnSignIn.onHoverState.BorderRadius = 1;
            this.btnSignIn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSignIn.onHoverState.BorderThickness = 1;
            this.btnSignIn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSignIn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.onHoverState.IconLeftImage = null;
            this.btnSignIn.onHoverState.IconRightImage = null;
            this.btnSignIn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.btnSignIn.OnIdleState.BorderRadius = 1;
            this.btnSignIn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSignIn.OnIdleState.BorderThickness = 1;
            this.btnSignIn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(31)))), ((int)(((byte)(79)))));
            this.btnSignIn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.OnIdleState.IconLeftImage = null;
            this.btnSignIn.OnIdleState.IconRightImage = null;
            this.btnSignIn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSignIn.OnPressedState.BorderRadius = 1;
            this.btnSignIn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSignIn.OnPressedState.BorderThickness = 1;
            this.btnSignIn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSignIn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.OnPressedState.IconLeftImage = null;
            this.btnSignIn.OnPressedState.IconRightImage = null;
            this.btnSignIn.Size = new System.Drawing.Size(537, 79);
            this.btnSignIn.TabIndex = 14;
            this.btnSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignIn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSignIn.TextMarginLeft = 0;
            this.btnSignIn.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSignIn.UseDefaultRadiusAndThickness = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
             
            // pnlGradient
            this.pnlGradient.BackColor = System.Drawing.Color.Transparent;
            this.pnlGradient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlGradient.BackgroundImage")));
            this.pnlGradient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGradient.BorderRadius = 0;
            this.pnlGradient.Controls.Add(this.btnSignIn);
            this.pnlGradient.Controls.Add(this.lblPers);
            this.pnlGradient.Controls.Add(this.lblErrorEmail);
            this.pnlGradient.Controls.Add(this.lblErorPass);
            this.pnlGradient.Controls.Add(this.linkForgot);
            this.pnlGradient.Controls.Add(this.txtPass);
            this.pnlGradient.Controls.Add(this.txtEmail);
            this.pnlGradient.Controls.Add(this.lblPass);
            this.pnlGradient.Controls.Add(this.lblTile);
            this.pnlGradient.Controls.Add(this.lblEmail);
            this.pnlGradient.Controls.Add(this.pnlDesign);
            this.pnlGradient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGradient.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.pnlGradient.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.pnlGradient.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(58)))));
            this.pnlGradient.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(58)))));
            this.pnlGradient.Location = new System.Drawing.Point(0, 0);
            this.pnlGradient.Name = "pnlGradient";
            this.pnlGradient.Quality = 10;
            this.pnlGradient.Size = new System.Drawing.Size(1776, 925);
            this.pnlGradient.TabIndex = 2;
             
            // linkForgot
            this.linkForgot.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.linkForgot.AutoSize = true;
            this.linkForgot.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkForgot.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkForgot.LinkColor = System.Drawing.Color.DarkGray;
            this.linkForgot.Location = new System.Drawing.Point(956, 552);
            this.linkForgot.Name = "linkForgot";
            this.linkForgot.Size = new System.Drawing.Size(202, 33);
            this.linkForgot.TabIndex = 10;
            this.linkForgot.TabStop = true;
            this.linkForgot.Text = "Forgot Password?";
            this.linkForgot.Click += new System.EventHandler(this.linkForgot_Click);
             
            // txtPass
            this.txtPass.AcceptsReturn = false;
            this.txtPass.AcceptsTab = false;
            this.txtPass.AnimationSpeed = 200;
            this.txtPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPass.AutoSizeHeight = true;
            this.txtPass.BackColor = System.Drawing.Color.Transparent;
            this.txtPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPass.BackgroundImage")));
            this.txtPass.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.txtPass.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(100)))));
            this.txtPass.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.txtPass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.txtPass.BorderRadius = 5;
            this.txtPass.BorderThickness = 2;
            this.txtPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultFont = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.DefaultText = "";
            this.txtPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.txtPass.ForeColor = System.Drawing.Color.White;
            this.txtPass.HideSelection = true;
            this.txtPass.IconLeft = null;
            this.txtPass.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.IconPadding = 10;
            this.txtPass.IconRight = null;
            this.txtPass.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.Lines = new string[0];
            this.txtPass.Location = new System.Drawing.Point(621, 488);
            this.txtPass.MaxLength = 32767;
            this.txtPass.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPass.Modified = false;
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            stateProperties1.BorderColor = System.Drawing.Color.White;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPass.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(100)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPass.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPass.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPass.OnIdleState = stateProperties4;
            this.txtPass.Padding = new System.Windows.Forms.Padding(3);
            this.txtPass.PasswordChar = '\0';
            this.txtPass.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPass.PlaceholderText = "Enter your password";
            this.txtPass.ReadOnly = false;
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(537, 61);
            this.txtPass.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPass.TabIndex = 8;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPass.TextMarginBottom = 0;
            this.txtPass.TextMarginLeft = 3;
            this.txtPass.TextMarginTop = 1;
            this.txtPass.TextPlaceholder = "Enter your password";
            this.txtPass.UseSystemPasswordChar = false;
            this.txtPass.WordWrap = true;
             
            // txtEmail
            this.txtEmail.AcceptsReturn = false;
            this.txtEmail.AcceptsTab = false;
            this.txtEmail.AnimationSpeed = 200;
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmail.AutoSizeHeight = true;
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtEmail.BackgroundImage")));
            this.txtEmail.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.txtEmail.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(100)))));
            this.txtEmail.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.txtEmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.txtEmail.BorderRadius = 5;
            this.txtEmail.BorderThickness = 2;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultFont = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.DefaultText = "";
            this.txtEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.HideSelection = true;
            this.txtEmail.IconLeft = null;
            this.txtEmail.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.IconPadding = 10;
            this.txtEmail.IconRight = null;
            this.txtEmail.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(621, 345);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtEmail.Modified = false;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            stateProperties5.BorderColor = System.Drawing.Color.White;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmail.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(100)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtEmail.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmail.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(20)))), ((int)(((byte)(54)))));
            stateProperties8.ForeColor = System.Drawing.Color.White;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmail.OnIdleState = stateProperties8;
            this.txtEmail.Padding = new System.Windows.Forms.Padding(3);
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "Enter your email";
            this.txtEmail.ReadOnly = false;
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(537, 61);
            this.txtEmail.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtEmail.TabIndex = 8;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TextMarginBottom = 0;
            this.txtEmail.TextMarginLeft = 3;
            this.txtEmail.TextMarginTop = 1;
            this.txtEmail.TextPlaceholder = "Enter your email";
            this.txtEmail.UseSystemPasswordChar = false;
            this.txtEmail.WordWrap = true;
             
            // lblPass
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(136)))), ((int)(((byte)(156)))));
            this.lblPass.Location = new System.Drawing.Point(618, 455);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(114, 25);
            this.lblPass.TabIndex = 7;
            this.lblPass.Text = "Password";
             
            // lblTile
            this.lblTile.AutoSize = true;
            this.lblTile.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTile.ForeColor = System.Drawing.Color.White;
            this.lblTile.Location = new System.Drawing.Point(813, 64);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(171, 57);
            this.lblTile.TabIndex = 7;
            this.lblTile.Text = "Sign In";
             
            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(136)))), ((int)(((byte)(156)))));
            this.lblEmail.Location = new System.Drawing.Point(618, 312);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(163, 25);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email Address";
             
            // pnlDesign
            this.pnlDesign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(65)))));
            this.pnlDesign.Controls.Add(this.btnSignUp);
            this.pnlDesign.Controls.Add(this.lblSign);
            this.pnlDesign.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDesign.Location = new System.Drawing.Point(0, 808);
            this.pnlDesign.Name = "pnlDesign";
            this.pnlDesign.Size = new System.Drawing.Size(1776, 117);
            this.pnlDesign.TabIndex = 13;
             
            // lblSign
            this.lblSign.AutoSize = true;
            this.lblSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(65)))));
            this.lblSign.Font = new System.Drawing.Font("Comfortaa Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSign.ForeColor = System.Drawing.Color.White;
            this.lblSign.Location = new System.Drawing.Point(616, 35);
            this.lblSign.Name = "lblSign";
            this.lblSign.Size = new System.Drawing.Size(395, 44);
            this.lblSign.TabIndex = 3;
            this.lblSign.Text = $@"Don't have an account yet?";

            // lblErorPass
            this.lblErorPass.AutoSize = true;
            this.lblErorPass.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErorPass.ForeColor = System.Drawing.Color.Red;
            this.lblErorPass.Location = new System.Drawing.Point(618, 552);
            this.lblErorPass.Name = "lblErorPass";
            this.lblErorPass.Size = new System.Drawing.Size(74, 33);
            this.lblErorPass.TabIndex = 15;
            this.lblErorPass.Text = "The password is not correct.";
             
            // lblErrorEmail
            this.lblErrorEmail.AutoSize = true;
            this.lblErrorEmail.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEmail.Location = new System.Drawing.Point(618, 409);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(74, 33);
            this.lblErrorEmail.TabIndex = 15;
            this.lblErrorEmail.Text = "The email is not correct.";

            this.lblErorPass.Visible = false;
            this.lblErrorEmail.Visible = false;

            this.lblTile.Location = new System.Drawing.Point(this.form.Size.Width/2-85,80);
            this.lblPers.Location = new System.Drawing.Point(this.lblTile.Location.X-180,this.lblTile.Location.Y*2+50);
            this.lblEmail.Location = new System.Drawing.Point(this.lblPers.Location.X,this.lblPers.Location.Y + 120);
            this.txtEmail.Location = new System.Drawing.Point(this.lblEmail.Location.X, this.lblEmail.Location.Y + 30);
            this.lblErrorEmail.Location = new System.Drawing.Point(txtEmail.Location.X,txtEmail.Location.Y+65);
            this.lblPass.Location = new System.Drawing.Point(this.txtEmail.Location.X, this.txtEmail.Location.Y + 110);
            this.txtPass.Location = new System.Drawing.Point(this.lblPass.Location.X, this.lblPass.Location.Y + 30);
            this.lblErorPass.Location = new System.Drawing.Point(txtPass.Location.X, txtPass.Location.Y + 65);
            this.linkForgot.Location = new System.Drawing.Point(this.txtPass.Location.X + 335, this.txtPass.Location.Y + 110);
            this.btnSignIn.Location = new System.Drawing.Point(this.txtPass.Location.X, this.txtPass.Location.Y+150);
            this.lblSign.Location = new System.Drawing.Point(this.btnSignIn.Location.X,this.pnlDesign.Size.Height/2-22);
            this.btnSignUp.Location = new System.Drawing.Point(this.lblSign.Location.X + lblSign.Size.Width + 5, this.pnlDesign.Size.Height / 2 - 20);
        }

        private void this_Resize(object sender, System.EventArgs e)
        {
            this.lblTile.Location = new System.Drawing.Point(this.form.Size.Width / 2 - 85, 80);
            this.lblPers.Location = new System.Drawing.Point(this.lblTile.Location.X - 180, this.lblTile.Location.Y * 2 + 50);
            this.lblEmail.Location = new System.Drawing.Point(this.lblPers.Location.X, this.lblPers.Location.Y + 120);
            this.txtEmail.Location = new System.Drawing.Point(this.lblEmail.Location.X, this.lblEmail.Location.Y + 30);
            this.lblErrorEmail.Location = new System.Drawing.Point(txtEmail.Location.X, txtEmail.Location.Y + 65);
            this.lblPass.Location = new System.Drawing.Point(this.txtEmail.Location.X, this.txtEmail.Location.Y + 110);
            this.txtPass.Location = new System.Drawing.Point(this.lblPass.Location.X, this.lblPass.Location.Y + 30);
            this.lblErorPass.Location = new System.Drawing.Point(txtPass.Location.X, txtPass.Location.Y + 65);
            this.linkForgot.Location = new System.Drawing.Point(this.txtPass.Location.X + 335, this.txtPass.Location.Y + 110);
            this.btnSignIn.Location = new System.Drawing.Point(this.txtPass.Location.X, this.txtPass.Location.Y + 150);
            this.lblSign.Location = new System.Drawing.Point(this.btnSignIn.Location.X, this.pnlDesign.Size.Height / 2 - 22);
            this.btnSignUp.Location = new System.Drawing.Point(this.lblSign.Location.X + lblSign.Size.Width + 5, this.pnlDesign.Size.Height / 2 - 20);

        }

        List<string> errors = new List<string>();

        public void verification()
        {

            errors.Clear();
          //  this.txtEmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
           // this.txtPass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.txtEmail.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.txtPass.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.lblErorPass.Visible = false;
            this.lblErrorEmail.Visible = false;

            if (!txtEmail.Text.Contains("@") || txtEmail.Text.Equals(""))
            {
                errors.Add("1");
            }

            if (txtPass.Text.Length < 7)
            {
                errors.Add("2");
            }

            if(errors.Count > 0)
            if (errors[0].Equals("1"))
            {
                txtEmail.BorderColorIdle = System.Drawing.Color.OrangeRed;
                txtEmail.BorderColorDisabled = System.Drawing.Color.OrangeRed;
                lblErrorEmail.Visible = true;
            }

            if(errors.Count > 0)
            if (errors[0].Equals("2"))
            {
                txtPass.BorderColorIdle = System.Drawing.Color.OrangeRed;
                txtPass.BorderColorDisabled = System.Drawing.Color.OrangeRed;
                lblErorPass.Visible = true;
            }

            if (errors.Count > 1)
                if (errors[1].Equals("2"))
                {
                    txtPass.BorderColorIdle = System.Drawing.Color.OrangeRed;
                    txtPass.BorderColorDisabled = System.Drawing.Color.OrangeRed;
                    lblErorPass.Visible = true;
                }

        }

        private void linkForgot_Click(object sender, EventArgs e)
        {


        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

            verification();

            if(errors.Count == 0)
            {
                if (serviceUsers.getByEmailPass(txtEmail.Text, txtPass.Text) == null)
                {
                    this.txtEmail.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
                    this.txtPass.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
                    this.lblErorPass.Visible = true;
                    this.lblErrorEmail.Visible = true;
                }
                else
                {
                    this.form.removePnl("PnlLogin");
                    User user = serviceUsers.getByEmailPass(txtEmail.Text, txtPass.Text);
                    this.form.removePnl("PnlSignUp");
                    this.form.Controls.Add(new PnlSlideTileBar(form, user));
                    this.form.Controls.Add(new PnlHome(form, user));
                }

            }


        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            this.form.removePnl("PnlLogin");
            this.form.Controls.Add(new PnlSignUp(form));

        }


    }
}
