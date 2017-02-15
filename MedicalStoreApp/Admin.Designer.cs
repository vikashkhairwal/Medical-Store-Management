namespace MedicalStoreApp
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.userdeatailsmetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.userdetailsmetroLabel = new MetroFramework.Controls.MetroLabel();
            this.stockanalysismetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.stockanalysismetroLabel = new MetroFramework.Controls.MetroLabel();
            this.logoutTile = new MetroFramework.Controls.MetroTile();
            this.exitTile = new MetroFramework.Controls.MetroTile();
            this.deletemedicineTile = new MetroFramework.Controls.MetroTile();
            this.udersdatabasemetroTile = new MetroFramework.Controls.MetroTile();
            this.deletedbLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.admintypevspricemetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // userdeatailsmetroTextBox
            // 
            this.userdeatailsmetroTextBox.Location = new System.Drawing.Point(14, 123);
            this.userdeatailsmetroTextBox.MaxLength = 327670000;
            this.userdeatailsmetroTextBox.Multiline = true;
            this.userdeatailsmetroTextBox.Name = "userdeatailsmetroTextBox";
            this.userdeatailsmetroTextBox.ReadOnly = true;
            this.userdeatailsmetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userdeatailsmetroTextBox.Size = new System.Drawing.Size(871, 422);
            this.userdeatailsmetroTextBox.TabIndex = 1;
            // 
            // userdetailsmetroLabel
            // 
            this.userdetailsmetroLabel.AutoSize = true;
            this.userdetailsmetroLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.userdetailsmetroLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.userdetailsmetroLabel.Location = new System.Drawing.Point(61, 89);
            this.userdetailsmetroLabel.Name = "userdetailsmetroLabel";
            this.userdetailsmetroLabel.Size = new System.Drawing.Size(154, 25);
            this.userdetailsmetroLabel.TabIndex = 2;
            this.userdetailsmetroLabel.Text = "Users Login Detail";
            this.userdetailsmetroLabel.UseStyleColors = true;
            // 
            // stockanalysismetroTextBox
            // 
            this.stockanalysismetroTextBox.Location = new System.Drawing.Point(892, 186);
            this.stockanalysismetroTextBox.Multiline = true;
            this.stockanalysismetroTextBox.Name = "stockanalysismetroTextBox";
            this.stockanalysismetroTextBox.ReadOnly = true;
            this.stockanalysismetroTextBox.Size = new System.Drawing.Size(204, 132);
            this.stockanalysismetroTextBox.TabIndex = 3;
            // 
            // stockanalysismetroLabel
            // 
            this.stockanalysismetroLabel.AutoSize = true;
            this.stockanalysismetroLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.stockanalysismetroLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.stockanalysismetroLabel.Location = new System.Drawing.Point(892, 89);
            this.stockanalysismetroLabel.Name = "stockanalysismetroLabel";
            this.stockanalysismetroLabel.Size = new System.Drawing.Size(125, 25);
            this.stockanalysismetroLabel.TabIndex = 4;
            this.stockanalysismetroLabel.Text = "Stock Analysis";
            this.stockanalysismetroLabel.UseStyleColors = true;
            // 
            // logoutTile
            // 
            this.logoutTile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logoutTile.Location = new System.Drawing.Point(892, 27);
            this.logoutTile.Name = "logoutTile";
            this.logoutTile.Size = new System.Drawing.Size(90, 32);
            this.logoutTile.TabIndex = 5;
            this.logoutTile.Text = "LOGOUT";
            this.logoutTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoutTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.logoutTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.logoutTile.UseTileImage = true;
            this.logoutTile.Click += new System.EventHandler(this.logoutTile_Click);
            // 
            // exitTile
            // 
            this.exitTile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitTile.Location = new System.Drawing.Point(991, 27);
            this.exitTile.Name = "exitTile";
            this.exitTile.Size = new System.Drawing.Size(81, 31);
            this.exitTile.TabIndex = 6;
            this.exitTile.Text = "EXIT";
            this.exitTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.exitTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.exitTile.Click += new System.EventHandler(this.exitTile_Click);
            // 
            // deletemedicineTile
            // 
            this.deletemedicineTile.Location = new System.Drawing.Point(581, 27);
            this.deletemedicineTile.Name = "deletemedicineTile";
            this.deletemedicineTile.Size = new System.Drawing.Size(258, 67);
            this.deletemedicineTile.Style = MetroFramework.MetroColorStyle.Teal;
            this.deletemedicineTile.TabIndex = 15;
            this.deletemedicineTile.Text = "DELETE MEDICINE DATABASE";
            this.deletemedicineTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deletemedicineTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.deletemedicineTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.deletemedicineTile.Click += new System.EventHandler(this.deletemedicineTile_Click);
            // 
            // udersdatabasemetroTile
            // 
            this.udersdatabasemetroTile.Location = new System.Drawing.Point(331, 27);
            this.udersdatabasemetroTile.Name = "udersdatabasemetroTile";
            this.udersdatabasemetroTile.Size = new System.Drawing.Size(229, 67);
            this.udersdatabasemetroTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.udersdatabasemetroTile.TabIndex = 16;
            this.udersdatabasemetroTile.Text = "DELETE USERS DATABASE";
            this.udersdatabasemetroTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.udersdatabasemetroTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.udersdatabasemetroTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.udersdatabasemetroTile.Click += new System.EventHandler(this.udersdatabasemetroTile_Click);
            // 
            // deletedbLabel
            // 
            this.deletedbLabel.AutoSize = true;
            this.deletedbLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.deletedbLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.deletedbLabel.Location = new System.Drawing.Point(23, 60);
            this.deletedbLabel.Name = "deletedbLabel";
            this.deletedbLabel.Size = new System.Drawing.Size(0, 0);
            this.deletedbLabel.TabIndex = 18;
            this.deletedbLabel.UseStyleColors = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.Location = new System.Drawing.Point(912, 140);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(141, 25);
            this.metroLabel12.TabIndex = 19;
            this.metroLabel12.Text = "Type VS Quantity";
            this.metroLabel12.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(928, 349);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(113, 25);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "Type VS Price";
            this.metroLabel1.UseStyleColors = true;
            // 
            // admintypevspricemetroTextBox
            // 
            this.admintypevspricemetroTextBox.Location = new System.Drawing.Point(892, 395);
            this.admintypevspricemetroTextBox.Multiline = true;
            this.admintypevspricemetroTextBox.Name = "admintypevspricemetroTextBox";
            this.admintypevspricemetroTextBox.ReadOnly = true;
            this.admintypevspricemetroTextBox.Size = new System.Drawing.Size(204, 132);
            this.admintypevspricemetroTextBox.TabIndex = 21;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 550);
            this.Controls.Add(this.admintypevspricemetroTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.deletedbLabel);
            this.Controls.Add(this.udersdatabasemetroTile);
            this.Controls.Add(this.deletemedicineTile);
            this.Controls.Add(this.exitTile);
            this.Controls.Add(this.logoutTile);
            this.Controls.Add(this.stockanalysismetroLabel);
            this.Controls.Add(this.stockanalysismetroTextBox);
            this.Controls.Add(this.userdetailsmetroLabel);
            this.Controls.Add(this.userdeatailsmetroTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox userdeatailsmetroTextBox;
        private MetroFramework.Controls.MetroLabel userdetailsmetroLabel;
        private MetroFramework.Controls.MetroTextBox stockanalysismetroTextBox;
        private MetroFramework.Controls.MetroLabel stockanalysismetroLabel;
        private MetroFramework.Controls.MetroTile logoutTile;
        private MetroFramework.Controls.MetroTile exitTile;
        private MetroFramework.Controls.MetroTile deletemedicineTile;
        private MetroFramework.Controls.MetroTile udersdatabasemetroTile;
        private MetroFramework.Controls.MetroLabel deletedbLabel;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox admintypevspricemetroTextBox;


    }
}