namespace GarthProject
{
    partial class frmMainForm
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
            this.btnSplashScreen = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.dgvAlbums = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splashScreenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAlbumSearch = new System.Windows.Forms.Button();
            this.txtAlbumSearch = new System.Windows.Forms.TextBox();
            this.pbCurrentAlbum = new System.Windows.Forms.PictureBox();
            this.gbAddNewAlbum = new System.Windows.Forms.GroupBox();
            this.btnAddAlbum = new System.Windows.Forms.Button();
            this.txtAlbumURL = new System.Windows.Forms.TextBox();
            this.lblAlbumURL = new System.Windows.Forms.Label();
            this.txtAlbumDesc = new System.Windows.Forms.TextBox();
            this.lblAlbumDesc = new System.Windows.Forms.Label();
            this.txtAlbumYear = new System.Windows.Forms.TextBox();
            this.lblAlbumYear = new System.Windows.Forms.Label();
            this.txtAlbumArtist = new System.Windows.Forms.TextBox();
            this.lblAlbumArtist = new System.Windows.Forms.Label();
            this.txtAlbumName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSongs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbums)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentAlbum)).BeginInit();
            this.gbAddNewAlbum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSplashScreen
            // 
            this.btnSplashScreen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSplashScreen.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplashScreen.Location = new System.Drawing.Point(1218, 72);
            this.btnSplashScreen.Name = "btnSplashScreen";
            this.btnSplashScreen.Size = new System.Drawing.Size(246, 64);
            this.btnSplashScreen.TabIndex = 20;
            this.btnSplashScreen.Text = "Splash Screen";
            this.btnSplashScreen.UseVisualStyleBackColor = true;
            this.btnSplashScreen.Click += new System.EventHandler(this.btnSplashScreen_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadData.Location = new System.Drawing.Point(28, 72);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(246, 64);
            this.btnLoadData.TabIndex = 19;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // dgvAlbums
            // 
            this.dgvAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbums.Location = new System.Drawing.Point(296, 163);
            this.dgvAlbums.Name = "dgvAlbums";
            this.dgvAlbums.RowHeadersWidth = 51;
            this.dgvAlbums.RowTemplate.Height = 24;
            this.dgvAlbums.Size = new System.Drawing.Size(1168, 354);
            this.dgvAlbums.TabIndex = 21;
            this.dgvAlbums.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlbums_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDataMenuItem,
            this.splashScreenMenuItem,
            this.helpMenuItem,
            this.exitMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1512, 30);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadDataMenuItem
            // 
            this.loadDataMenuItem.Name = "loadDataMenuItem";
            this.loadDataMenuItem.Size = new System.Drawing.Size(92, 26);
            this.loadDataMenuItem.Text = "Load Data";
            this.loadDataMenuItem.Click += new System.EventHandler(this.loadDataMenuItem_Click);
            // 
            // splashScreenMenuItem
            // 
            this.splashScreenMenuItem.Name = "splashScreenMenuItem";
            this.splashScreenMenuItem.Size = new System.Drawing.Size(114, 26);
            this.splashScreenMenuItem.Text = "Splash Screen";
            this.splashScreenMenuItem.Click += new System.EventHandler(this.splashScreenMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpMenuItem.Text = "Help";
            this.helpMenuItem.Click += new System.EventHandler(this.helpMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(47, 26);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // btnAlbumSearch
            // 
            this.btnAlbumSearch.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlbumSearch.Location = new System.Drawing.Point(296, 72);
            this.btnAlbumSearch.Name = "btnAlbumSearch";
            this.btnAlbumSearch.Size = new System.Drawing.Size(246, 64);
            this.btnAlbumSearch.TabIndex = 23;
            this.btnAlbumSearch.Text = "Album Search";
            this.btnAlbumSearch.UseVisualStyleBackColor = true;
            this.btnAlbumSearch.Click += new System.EventHandler(this.btnAlbumSearch_Click);
            // 
            // txtAlbumSearch
            // 
            this.txtAlbumSearch.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold);
            this.txtAlbumSearch.Location = new System.Drawing.Point(585, 81);
            this.txtAlbumSearch.Name = "txtAlbumSearch";
            this.txtAlbumSearch.Size = new System.Drawing.Size(601, 45);
            this.txtAlbumSearch.TabIndex = 24;
            // 
            // pbCurrentAlbum
            // 
            this.pbCurrentAlbum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbCurrentAlbum.Location = new System.Drawing.Point(17, 206);
            this.pbCurrentAlbum.Name = "pbCurrentAlbum";
            this.pbCurrentAlbum.Size = new System.Drawing.Size(262, 262);
            this.pbCurrentAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCurrentAlbum.TabIndex = 25;
            this.pbCurrentAlbum.TabStop = false;
            // 
            // gbAddNewAlbum
            // 
            this.gbAddNewAlbum.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbAddNewAlbum.Controls.Add(this.btnAddAlbum);
            this.gbAddNewAlbum.Controls.Add(this.txtAlbumURL);
            this.gbAddNewAlbum.Controls.Add(this.lblAlbumURL);
            this.gbAddNewAlbum.Controls.Add(this.txtAlbumDesc);
            this.gbAddNewAlbum.Controls.Add(this.lblAlbumDesc);
            this.gbAddNewAlbum.Controls.Add(this.txtAlbumYear);
            this.gbAddNewAlbum.Controls.Add(this.lblAlbumYear);
            this.gbAddNewAlbum.Controls.Add(this.txtAlbumArtist);
            this.gbAddNewAlbum.Controls.Add(this.lblAlbumArtist);
            this.gbAddNewAlbum.Controls.Add(this.txtAlbumName);
            this.gbAddNewAlbum.Controls.Add(this.label1);
            this.gbAddNewAlbum.Location = new System.Drawing.Point(17, 541);
            this.gbAddNewAlbum.Name = "gbAddNewAlbum";
            this.gbAddNewAlbum.Size = new System.Drawing.Size(865, 144);
            this.gbAddNewAlbum.TabIndex = 26;
            this.gbAddNewAlbum.TabStop = false;
            this.gbAddNewAlbum.Text = "Add New Album";
            // 
            // btnAddAlbum
            // 
            this.btnAddAlbum.Location = new System.Drawing.Point(752, 56);
            this.btnAddAlbum.Name = "btnAddAlbum";
            this.btnAddAlbum.Size = new System.Drawing.Size(94, 38);
            this.btnAddAlbum.TabIndex = 10;
            this.btnAddAlbum.Text = "Add Album";
            this.btnAddAlbum.UseVisualStyleBackColor = true;
            this.btnAddAlbum.Click += new System.EventHandler(this.btnAddAlbum_Click);
            // 
            // txtAlbumURL
            // 
            this.txtAlbumURL.Location = new System.Drawing.Point(100, 102);
            this.txtAlbumURL.Name = "txtAlbumURL";
            this.txtAlbumURL.Size = new System.Drawing.Size(628, 22);
            this.txtAlbumURL.TabIndex = 9;
            this.txtAlbumURL.Tag = "URL";
            // 
            // lblAlbumURL
            // 
            this.lblAlbumURL.AutoSize = true;
            this.lblAlbumURL.Location = new System.Drawing.Point(16, 105);
            this.lblAlbumURL.Name = "lblAlbumURL";
            this.lblAlbumURL.Size = new System.Drawing.Size(78, 16);
            this.lblAlbumURL.TabIndex = 8;
            this.lblAlbumURL.Text = "Album URL:";
            // 
            // txtAlbumDesc
            // 
            this.txtAlbumDesc.Location = new System.Drawing.Point(141, 64);
            this.txtAlbumDesc.Name = "txtAlbumDesc";
            this.txtAlbumDesc.Size = new System.Drawing.Size(587, 22);
            this.txtAlbumDesc.TabIndex = 7;
            this.txtAlbumDesc.Tag = "Description";
            // 
            // lblAlbumDesc
            // 
            this.lblAlbumDesc.AutoSize = true;
            this.lblAlbumDesc.Location = new System.Drawing.Point(16, 67);
            this.lblAlbumDesc.Name = "lblAlbumDesc";
            this.lblAlbumDesc.Size = new System.Drawing.Size(119, 16);
            this.lblAlbumDesc.TabIndex = 6;
            this.lblAlbumDesc.Text = "Album Description:";
            // 
            // txtAlbumYear
            // 
            this.txtAlbumYear.Location = new System.Drawing.Point(618, 25);
            this.txtAlbumYear.Name = "txtAlbumYear";
            this.txtAlbumYear.Size = new System.Drawing.Size(110, 22);
            this.txtAlbumYear.TabIndex = 5;
            this.txtAlbumYear.Tag = "Year";
            // 
            // lblAlbumYear
            // 
            this.lblAlbumYear.AutoSize = true;
            this.lblAlbumYear.Location = new System.Drawing.Point(532, 28);
            this.lblAlbumYear.Name = "lblAlbumYear";
            this.lblAlbumYear.Size = new System.Drawing.Size(80, 16);
            this.lblAlbumYear.TabIndex = 4;
            this.lblAlbumYear.Text = "Album Year:";
            // 
            // txtAlbumArtist
            // 
            this.txtAlbumArtist.Location = new System.Drawing.Point(395, 25);
            this.txtAlbumArtist.Name = "txtAlbumArtist";
            this.txtAlbumArtist.Size = new System.Drawing.Size(129, 22);
            this.txtAlbumArtist.TabIndex = 3;
            this.txtAlbumArtist.Tag = "Artist";
            // 
            // lblAlbumArtist
            // 
            this.lblAlbumArtist.AutoSize = true;
            this.lblAlbumArtist.Location = new System.Drawing.Point(309, 28);
            this.lblAlbumArtist.Name = "lblAlbumArtist";
            this.lblAlbumArtist.Size = new System.Drawing.Size(80, 16);
            this.lblAlbumArtist.TabIndex = 2;
            this.lblAlbumArtist.Text = "Album Artist:";
            // 
            // txtAlbumName
            // 
            this.txtAlbumName.Location = new System.Drawing.Point(110, 25);
            this.txtAlbumName.Name = "txtAlbumName";
            this.txtAlbumName.Size = new System.Drawing.Size(193, 22);
            this.txtAlbumName.TabIndex = 1;
            this.txtAlbumName.Tag = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Album Name:";
            // 
            // dgvSongs
            // 
            this.dgvSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongs.Location = new System.Drawing.Point(894, 532);
            this.dgvSongs.Name = "dgvSongs";
            this.dgvSongs.RowHeadersWidth = 51;
            this.dgvSongs.RowTemplate.Height = 24;
            this.dgvSongs.Size = new System.Drawing.Size(610, 215);
            this.dgvSongs.TabIndex = 27;
            // 
            // frmMainForm
            // 
            this.AcceptButton = this.btnLoadData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSplashScreen;
            this.ClientSize = new System.Drawing.Size(1512, 759);
            this.Controls.Add(this.dgvSongs);
            this.Controls.Add(this.gbAddNewAlbum);
            this.Controls.Add(this.pbCurrentAlbum);
            this.Controls.Add(this.txtAlbumSearch);
            this.Controls.Add(this.btnAlbumSearch);
            this.Controls.Add(this.dgvAlbums);
            this.Controls.Add(this.btnSplashScreen);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garth Brooks DB Project Main Screen";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbums)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentAlbum)).EndInit();
            this.gbAddNewAlbum.ResumeLayout(false);
            this.gbAddNewAlbum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSplashScreen;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.DataGridView dgvAlbums;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem splashScreenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDataMenuItem;
        private System.Windows.Forms.Button btnAlbumSearch;
        private System.Windows.Forms.TextBox txtAlbumSearch;
        private System.Windows.Forms.PictureBox pbCurrentAlbum;
        private System.Windows.Forms.GroupBox gbAddNewAlbum;
        private System.Windows.Forms.Button btnAddAlbum;
        private System.Windows.Forms.TextBox txtAlbumURL;
        private System.Windows.Forms.Label lblAlbumURL;
        private System.Windows.Forms.TextBox txtAlbumDesc;
        private System.Windows.Forms.Label lblAlbumDesc;
        private System.Windows.Forms.TextBox txtAlbumYear;
        private System.Windows.Forms.Label lblAlbumYear;
        private System.Windows.Forms.TextBox txtAlbumArtist;
        private System.Windows.Forms.Label lblAlbumArtist;
        private System.Windows.Forms.TextBox txtAlbumName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSongs;
    }
}