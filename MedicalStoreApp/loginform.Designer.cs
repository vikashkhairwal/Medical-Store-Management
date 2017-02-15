namespace MedicalStoreApp
{
    partial class loginform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginform));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.loginTab = new MetroFramework.Controls.MetroTabPage();
            this.loginlabel = new MetroFramework.Controls.MetroLabel();
            this.loginbtn = new MetroFramework.Controls.MetroButton();
            this.passwordtextbox = new MetroFramework.Controls.MetroTextBox();
            this.usernametextbox = new MetroFramework.Controls.MetroTextBox();
            this.passwordlabel = new MetroFramework.Controls.MetroLabel();
            this.usernamelabel = new MetroFramework.Controls.MetroLabel();
            this.registertab = new MetroFramework.Controls.MetroTabPage();
            this.registerProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.hiddenregsuccess = new MetroFramework.Controls.MetroLabel();
            this.hiddenmobileLabel = new MetroFramework.Controls.MetroLabel();
            this.hiddenpassLabel = new MetroFramework.Controls.MetroLabel();
            this.hiddenmetroLabel = new MetroFramework.Controls.MetroLabel();
            this.registerbtn = new MetroFramework.Controls.MetroButton();
            this.regmobilenotxtbox = new MetroFramework.Controls.MetroTextBox();
            this.regmobilecodetxtbox = new MetroFramework.Controls.MetroTextBox();
            this.regmobilenolabel = new MetroFramework.Controls.MetroLabel();
            this.regpasstxtbox = new MetroFramework.Controls.MetroTextBox();
            this.regpasslabel = new MetroFramework.Controls.MetroLabel();
            this.regemailtxtbox = new MetroFramework.Controls.MetroTextBox();
            this.regemaillabel = new MetroFramework.Controls.MetroLabel();
            this.startmetroTile = new MetroFramework.Controls.MetroTile();
            this.metroProgressSpinner2 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.startProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.tmrcounter = new System.Windows.Forms.Timer(this.components);
            this.metroTabControl1.SuspendLayout();
            this.loginTab.SuspendLayout();
            this.registertab.SuspendLayout();
            this.startmetroTile.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.loginTab);
            this.metroTabControl1.Controls.Add(this.registertab);
            this.metroTabControl1.Location = new System.Drawing.Point(103, 97);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(586, 344);
            this.metroTabControl1.TabIndex = 0;
            // 
            // loginTab
            // 
            this.loginTab.Controls.Add(this.loginlabel);
            this.loginTab.Controls.Add(this.loginbtn);
            this.loginTab.Controls.Add(this.passwordtextbox);
            this.loginTab.Controls.Add(this.usernametextbox);
            this.loginTab.Controls.Add(this.passwordlabel);
            this.loginTab.Controls.Add(this.usernamelabel);
            this.loginTab.HorizontalScrollbarBarColor = true;
            this.loginTab.Location = new System.Drawing.Point(4, 35);
            this.loginTab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.loginTab.Name = "loginTab";
            this.loginTab.Size = new System.Drawing.Size(578, 305);
            this.loginTab.TabIndex = 0;
            this.loginTab.Text = "Login";
            this.loginTab.VerticalScrollbarBarColor = true;
            // 
            // loginlabel
            // 
            this.loginlabel.AutoSize = true;
            this.loginlabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.loginlabel.Location = new System.Drawing.Point(216, 250);
            this.loginlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(0, 0);
            this.loginlabel.TabIndex = 7;
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(254, 195);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(167, 37);
            this.loginbtn.TabIndex = 6;
            this.loginbtn.Text = "LOGIN";
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Location = new System.Drawing.Point(254, 127);
            this.passwordtextbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.PasswordChar = '●';
            this.passwordtextbox.Size = new System.Drawing.Size(167, 23);
            this.passwordtextbox.TabIndex = 5;
            this.passwordtextbox.UseStyleColors = true;
            this.passwordtextbox.UseSystemPasswordChar = true;
            // 
            // usernametextbox
            // 
            this.usernametextbox.Location = new System.Drawing.Point(254, 59);
            this.usernametextbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(167, 23);
            this.usernametextbox.TabIndex = 4;
            this.usernametextbox.UseStyleColors = true;
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.passwordlabel.Location = new System.Drawing.Point(119, 127);
            this.passwordlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(73, 19);
            this.passwordlabel.TabIndex = 3;
            this.passwordlabel.Text = "Password";
            this.passwordlabel.UseStyleColors = true;
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.usernamelabel.Location = new System.Drawing.Point(86, 63);
            this.usernamelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(136, 19);
            this.usernamelabel.TabIndex = 2;
            this.usernamelabel.Text = "E-mail /Mobile  No";
            this.usernamelabel.UseStyleColors = true;
            // 
            // registertab
            // 
            this.registertab.Controls.Add(this.registerProgressBar);
            this.registertab.Controls.Add(this.hiddenregsuccess);
            this.registertab.Controls.Add(this.hiddenmobileLabel);
            this.registertab.Controls.Add(this.hiddenpassLabel);
            this.registertab.Controls.Add(this.hiddenmetroLabel);
            this.registertab.Controls.Add(this.registerbtn);
            this.registertab.Controls.Add(this.regmobilenotxtbox);
            this.registertab.Controls.Add(this.regmobilecodetxtbox);
            this.registertab.Controls.Add(this.regmobilenolabel);
            this.registertab.Controls.Add(this.regpasstxtbox);
            this.registertab.Controls.Add(this.regpasslabel);
            this.registertab.Controls.Add(this.regemailtxtbox);
            this.registertab.Controls.Add(this.regemaillabel);
            this.registertab.HorizontalScrollbarBarColor = true;
            this.registertab.Location = new System.Drawing.Point(4, 35);
            this.registertab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.registertab.Name = "registertab";
            this.registertab.Size = new System.Drawing.Size(578, 305);
            this.registertab.TabIndex = 1;
            this.registertab.Text = "Register";
            this.registertab.VerticalScrollbarBarColor = true;
            this.registertab.Visible = false;
            // 
            // registerProgressBar
            // 
            this.registerProgressBar.Location = new System.Drawing.Point(3, 278);
            this.registerProgressBar.Name = "registerProgressBar";
            this.registerProgressBar.Size = new System.Drawing.Size(580, 31);
            this.registerProgressBar.TabIndex = 14;
            // 
            // hiddenregsuccess
            // 
            this.hiddenregsuccess.AutoSize = true;
            this.hiddenregsuccess.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.hiddenregsuccess.ForeColor = System.Drawing.SystemColors.Highlight;
            this.hiddenregsuccess.Location = new System.Drawing.Point(190, 249);
            this.hiddenregsuccess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hiddenregsuccess.Name = "hiddenregsuccess";
            this.hiddenregsuccess.Size = new System.Drawing.Size(0, 0);
            this.hiddenregsuccess.TabIndex = 13;
            // 
            // hiddenmobileLabel
            // 
            this.hiddenmobileLabel.AutoSize = true;
            this.hiddenmobileLabel.ForeColor = System.Drawing.Color.Red;
            this.hiddenmobileLabel.Location = new System.Drawing.Point(408, 141);
            this.hiddenmobileLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hiddenmobileLabel.Name = "hiddenmobileLabel";
            this.hiddenmobileLabel.Size = new System.Drawing.Size(0, 0);
            this.hiddenmobileLabel.TabIndex = 12;
            // 
            // hiddenpassLabel
            // 
            this.hiddenpassLabel.AutoSize = true;
            this.hiddenpassLabel.ForeColor = System.Drawing.Color.Red;
            this.hiddenpassLabel.Location = new System.Drawing.Point(408, 84);
            this.hiddenpassLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hiddenpassLabel.Name = "hiddenpassLabel";
            this.hiddenpassLabel.Size = new System.Drawing.Size(0, 0);
            this.hiddenpassLabel.TabIndex = 11;
            // 
            // hiddenmetroLabel
            // 
            this.hiddenmetroLabel.AutoSize = true;
            this.hiddenmetroLabel.BackColor = System.Drawing.Color.Red;
            this.hiddenmetroLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.hiddenmetroLabel.ForeColor = System.Drawing.Color.Red;
            this.hiddenmetroLabel.Location = new System.Drawing.Point(408, 41);
            this.hiddenmetroLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hiddenmetroLabel.Name = "hiddenmetroLabel";
            this.hiddenmetroLabel.Size = new System.Drawing.Size(0, 0);
            this.hiddenmetroLabel.TabIndex = 10;
            // 
            // registerbtn
            // 
            this.registerbtn.Location = new System.Drawing.Point(248, 191);
            this.registerbtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(154, 37);
            this.registerbtn.TabIndex = 9;
            this.registerbtn.Text = "REGISTER";
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // regmobilenotxtbox
            // 
            this.regmobilenotxtbox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.regmobilenotxtbox.Location = new System.Drawing.Point(284, 141);
            this.regmobilenotxtbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.regmobilenotxtbox.MaxLength = 10;
            this.regmobilenotxtbox.Name = "regmobilenotxtbox";
            this.regmobilenotxtbox.Size = new System.Drawing.Size(116, 23);
            this.regmobilenotxtbox.TabIndex = 8;
            this.regmobilenotxtbox.UseStyleColors = true;
            // 
            // regmobilecodetxtbox
            // 
            this.regmobilecodetxtbox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.regmobilecodetxtbox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.regmobilecodetxtbox.Location = new System.Drawing.Point(247, 141);
            this.regmobilecodetxtbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.regmobilecodetxtbox.Name = "regmobilecodetxtbox";
            this.regmobilecodetxtbox.ReadOnly = true;
            this.regmobilecodetxtbox.Size = new System.Drawing.Size(32, 23);
            this.regmobilecodetxtbox.TabIndex = 7;
            this.regmobilecodetxtbox.Text = "+91";
            this.regmobilecodetxtbox.UseWaitCursor = true;
            // 
            // regmobilenolabel
            // 
            this.regmobilenolabel.AutoSize = true;
            this.regmobilenolabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.regmobilenolabel.Location = new System.Drawing.Point(137, 141);
            this.regmobilenolabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.regmobilenolabel.Name = "regmobilenolabel";
            this.regmobilenolabel.Size = new System.Drawing.Size(80, 19);
            this.regmobilenolabel.TabIndex = 6;
            this.regmobilenolabel.Text = "Mobile No";
            // 
            // regpasstxtbox
            // 
            this.regpasstxtbox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.regpasstxtbox.Location = new System.Drawing.Point(246, 84);
            this.regpasstxtbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.regpasstxtbox.Name = "regpasstxtbox";
            this.regpasstxtbox.PasswordChar = '●';
            this.regpasstxtbox.Size = new System.Drawing.Size(155, 23);
            this.regpasstxtbox.TabIndex = 5;
            this.regpasstxtbox.UseStyleColors = true;
            this.regpasstxtbox.UseSystemPasswordChar = true;
            // 
            // regpasslabel
            // 
            this.regpasslabel.AutoSize = true;
            this.regpasslabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.regpasslabel.Location = new System.Drawing.Point(142, 88);
            this.regpasslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.regpasslabel.Name = "regpasslabel";
            this.regpasslabel.Size = new System.Drawing.Size(73, 19);
            this.regpasslabel.TabIndex = 4;
            this.regpasslabel.Text = "Password";
            // 
            // regemailtxtbox
            // 
            this.regemailtxtbox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.regemailtxtbox.Location = new System.Drawing.Point(247, 37);
            this.regemailtxtbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.regemailtxtbox.Name = "regemailtxtbox";
            this.regemailtxtbox.Size = new System.Drawing.Size(155, 23);
            this.regemailtxtbox.TabIndex = 3;
            this.regemailtxtbox.UseStyleColors = true;
            this.regemailtxtbox.Click += new System.EventHandler(this.regemailtxtbox_Click);
            // 
            // regemaillabel
            // 
            this.regemaillabel.AutoSize = true;
            this.regemaillabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.regemaillabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.regemaillabel.Location = new System.Drawing.Point(145, 37);
            this.regemaillabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.regemaillabel.Name = "regemaillabel";
            this.regemaillabel.Size = new System.Drawing.Size(45, 19);
            this.regemaillabel.TabIndex = 2;
            this.regemaillabel.Text = "Email";
            // 
            // startmetroTile
            // 
            this.startmetroTile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startmetroTile.BackColor = System.Drawing.Color.White;
            this.startmetroTile.Controls.Add(this.metroProgressSpinner2);
            this.startmetroTile.Controls.Add(this.metroProgressSpinner1);
            this.startmetroTile.Controls.Add(this.startProgressBar);
            this.startmetroTile.Location = new System.Drawing.Point(103, 50);
            this.startmetroTile.Name = "startmetroTile";
            this.startmetroTile.Size = new System.Drawing.Size(611, 441);
            this.startmetroTile.TabIndex = 8;
            this.startmetroTile.Text = "LOADING.......";
            this.startmetroTile.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.startmetroTile.TileImage = ((System.Drawing.Image)(resources.GetObject("startmetroTile.TileImage")));
            this.startmetroTile.TileImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.startmetroTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.startmetroTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.startmetroTile.UseTileImage = true;
            this.startmetroTile.UseWaitCursor = true;
            // 
            // metroProgressSpinner2
            // 
            this.metroProgressSpinner2.Location = new System.Drawing.Point(491, 51);
            this.metroProgressSpinner2.Maximum = 100;
            this.metroProgressSpinner2.Name = "metroProgressSpinner2";
            this.metroProgressSpinner2.Size = new System.Drawing.Size(95, 91);
            this.metroProgressSpinner2.Speed = 2F;
            this.metroProgressSpinner2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroProgressSpinner2.TabIndex = 2;
            this.metroProgressSpinner2.UseWaitCursor = true;
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.BackColor = System.Drawing.Color.White;
            this.metroProgressSpinner1.Location = new System.Drawing.Point(32, 51);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(95, 91);
            this.metroProgressSpinner1.Speed = 2F;
            this.metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroProgressSpinner1.TabIndex = 1;
            this.metroProgressSpinner1.UseWaitCursor = true;
            // 
            // startProgressBar
            // 
            this.startProgressBar.FontWeight = MetroFramework.MetroProgressBarWeight.Regular;
            this.startProgressBar.Location = new System.Drawing.Point(47, 230);
            this.startProgressBar.Maximum = 1000;
            this.startProgressBar.Name = "startProgressBar";
            this.startProgressBar.Size = new System.Drawing.Size(510, 25);
            this.startProgressBar.TabIndex = 0;
            this.startProgressBar.Tag = "";
            this.startProgressBar.UseWaitCursor = true;
            // 
            // tmrcounter
            // 
            this.tmrcounter.Enabled = true;
            this.tmrcounter.Tick += new System.EventHandler(this.tmrcounter_Tick);
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(806, 496);
            this.Controls.Add(this.startmetroTile);
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "loginform";
            this.Text = "Medical Store Management";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.loginform_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.loginTab.ResumeLayout(false);
            this.loginTab.PerformLayout();
            this.registertab.ResumeLayout(false);
            this.registertab.PerformLayout();
            this.startmetroTile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage loginTab;
        private MetroFramework.Controls.MetroTextBox passwordtextbox;
        private MetroFramework.Controls.MetroTextBox usernametextbox;
        private MetroFramework.Controls.MetroLabel passwordlabel;
        private MetroFramework.Controls.MetroLabel usernamelabel;
        private MetroFramework.Controls.MetroTabPage registertab;
        private MetroFramework.Controls.MetroButton loginbtn;
        private MetroFramework.Controls.MetroTextBox regemailtxtbox;
        private MetroFramework.Controls.MetroLabel regemaillabel;
        private MetroFramework.Controls.MetroButton registerbtn;
        private MetroFramework.Controls.MetroTextBox regmobilenotxtbox;
        private MetroFramework.Controls.MetroTextBox regmobilecodetxtbox;
        private MetroFramework.Controls.MetroLabel regmobilenolabel;
        private MetroFramework.Controls.MetroTextBox regpasstxtbox;
        private MetroFramework.Controls.MetroLabel regpasslabel;
        private MetroFramework.Controls.MetroLabel hiddenmetroLabel;
        private MetroFramework.Controls.MetroLabel hiddenmobileLabel;
        private MetroFramework.Controls.MetroLabel hiddenpassLabel;
        private MetroFramework.Controls.MetroLabel hiddenregsuccess;
        private MetroFramework.Controls.MetroLabel loginlabel;
        private MetroFramework.Controls.MetroProgressBar registerProgressBar;
        private MetroFramework.Controls.MetroTile startmetroTile;
        private MetroFramework.Controls.MetroProgressBar startProgressBar;
        private System.Windows.Forms.Timer tmrcounter;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner2;


    }
}

