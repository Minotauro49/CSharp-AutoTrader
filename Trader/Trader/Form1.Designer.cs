namespace Trader
{
    partial class AutoTrade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoTrade));
            this.login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Checkbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.password = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.recover = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(63)))), ((int)(((byte)(100)))));
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login.BorderRadius = 0;
            this.login.ButtonText = "Login";
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.DisabledColor = System.Drawing.Color.Gray;
            this.login.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Iconcolor = System.Drawing.Color.Transparent;
            this.login.Iconimage = null;
            this.login.Iconimage_right = null;
            this.login.Iconimage_right_Selected = null;
            this.login.Iconimage_Selected = null;
            this.login.IconMarginLeft = 0;
            this.login.IconMarginRight = 0;
            this.login.IconRightVisible = true;
            this.login.IconRightZoom = 0D;
            this.login.IconVisible = true;
            this.login.IconZoom = 90D;
            this.login.IsTab = false;
            this.login.Location = new System.Drawing.Point(106, 394);
            this.login.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.login.Name = "login";
            this.login.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(63)))), ((int)(((byte)(100)))));
            this.login.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.login.OnHoverTextColor = System.Drawing.Color.White;
            this.login.selected = false;
            this.login.Size = new System.Drawing.Size(426, 53);
            this.login.TabIndex = 3;
            this.login.Text = "Login";
            this.login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login.Textcolor = System.Drawing.Color.White;
            this.login.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // Checkbox
            // 
            this.Checkbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Checkbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Checkbox.Checked = false;
            this.Checkbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(52)))), ((int)(((byte)(83)))));
            this.Checkbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Checkbox.ForeColor = System.Drawing.Color.White;
            this.Checkbox.Location = new System.Drawing.Point(106, 479);
            this.Checkbox.Name = "Checkbox";
            this.Checkbox.Padding = new System.Windows.Forms.Padding(2);
            this.Checkbox.Size = new System.Drawing.Size(20, 20);
            this.Checkbox.TabIndex = 4;
            this.Checkbox.OnChange += new System.EventHandler(this.Checkbox_OnChange);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(129, 480);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(129, 19);
            this.label.TabIndex = 5;
            this.label.Text = "Keep me logged in";
            this.label.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(102, 172);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(155, 23);
            this.bunifuCustomLabel2.TabIndex = 8;
            this.bunifuCustomLabel2.Text = "Username or Email";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click_1);
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.SystemColors.ButtonShadow;
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.SystemColors.ButtonShadow;
            this.bunifuMetroTextbox1.BorderThickness = 1;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(106, 199);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(426, 56);
            this.bunifuMetroTextbox1.TabIndex = 10;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMetroTextbox1.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox1_OnValueChanged);
            // 
            // password
            // 
            this.password.BorderColorFocused = System.Drawing.Color.SlateGray;
            this.password.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.password.BorderThickness = 1;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password.isPassword = true;
            this.password.Location = new System.Drawing.Point(106, 311);
            this.password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password.Name = "password";
            this.password.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.password.Size = new System.Drawing.Size(426, 56);
            this.password.TabIndex = 12;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.OnValueChanged += new System.EventHandler(this.password_OnValueChanged);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(102, 284);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(86, 23);
            this.bunifuCustomLabel3.TabIndex = 11;
            this.bunifuCustomLabel3.Text = "Password";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(118)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(104, 95);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(185, 33);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Login to MyASX";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // recover
            // 
            this.recover.AutoSize = true;
            this.recover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recover.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(118)))));
            this.recover.Location = new System.Drawing.Point(106, 526);
            this.recover.Name = "recover";
            this.recover.Size = new System.Drawing.Size(152, 18);
            this.recover.TabIndex = 13;
            this.recover.Text = "Forgotten your details?";
            this.recover.Click += new System.EventHandler(this.bunifuCustomLabel4_Click);
            // 
            // AutoTrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 613);
            this.Controls.Add(this.recover);
            this.Controls.Add(this.password);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuMetroTextbox1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Checkbox);
            this.Controls.Add(this.login);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AutoTrade";
            this.Text = "AutoTrade";
            this.Load += new System.EventHandler(this.AutoTrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton login;
        private Bunifu.Framework.UI.BunifuCheckbox Checkbox;
        private Bunifu.Framework.UI.BunifuCustomLabel label;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox password;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel recover;
    }
}

