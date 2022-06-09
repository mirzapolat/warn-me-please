namespace Warn_Me_Please
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbShallDo = new MaterialSkin.Controls.MaterialCheckBox();
            this.tmrDoThat = new System.Windows.Forms.Timer(this.components);
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.cbWarnMe = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnRiotGamesServer = new MaterialSkin.Controls.MaterialFlatButton();
            this.tbAdress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.lbPing = new System.Windows.Forms.Label();
            this.notIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbSettings.SuspendLayout();
            this.gbOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbShallDo
            // 
            this.cbShallDo.AutoSize = true;
            this.cbShallDo.Depth = 0;
            this.cbShallDo.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbShallDo.Location = new System.Drawing.Point(10, 27);
            this.cbShallDo.Margin = new System.Windows.Forms.Padding(0);
            this.cbShallDo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbShallDo.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbShallDo.Name = "cbShallDo";
            this.cbShallDo.Ripple = true;
            this.cbShallDo.Size = new System.Drawing.Size(121, 30);
            this.cbShallDo.TabIndex = 3;
            this.cbShallDo.Text = "Check my Ping";
            this.cbShallDo.UseVisualStyleBackColor = true;
            this.cbShallDo.CheckedChanged += new System.EventHandler(this.cbShallDo_CheckedChanged);
            // 
            // tmrDoThat
            // 
            this.tmrDoThat.Enabled = true;
            this.tmrDoThat.Interval = 1000;
            this.tmrDoThat.Tick += new System.EventHandler(this.tmrDoThat_Tick);
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.cbWarnMe);
            this.gbSettings.Controls.Add(this.btnRiotGamesServer);
            this.gbSettings.Controls.Add(this.cbShallDo);
            this.gbSettings.Controls.Add(this.tbAdress);
            this.gbSettings.Location = new System.Drawing.Point(12, 12);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(444, 102);
            this.gbSettings.TabIndex = 4;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // cbWarnMe
            // 
            this.cbWarnMe.AutoSize = true;
            this.cbWarnMe.Checked = true;
            this.cbWarnMe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWarnMe.Depth = 0;
            this.cbWarnMe.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbWarnMe.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.cbWarnMe.Location = new System.Drawing.Point(10, 60);
            this.cbWarnMe.Margin = new System.Windows.Forms.Padding(0);
            this.cbWarnMe.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbWarnMe.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbWarnMe.Name = "cbWarnMe";
            this.cbWarnMe.Ripple = true;
            this.cbWarnMe.Size = new System.Drawing.Size(193, 30);
            this.cbWarnMe.TabIndex = 5;
            this.cbWarnMe.Text = "Warn me if my ping is high";
            this.cbWarnMe.UseVisualStyleBackColor = true;
            this.cbWarnMe.CheckedChanged += new System.EventHandler(this.cbWarnMe_CheckedChanged);
            // 
            // btnRiotGamesServer
            // 
            this.btnRiotGamesServer.AutoSize = true;
            this.btnRiotGamesServer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRiotGamesServer.Depth = 0;
            this.btnRiotGamesServer.Location = new System.Drawing.Point(384, 23);
            this.btnRiotGamesServer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRiotGamesServer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRiotGamesServer.Name = "btnRiotGamesServer";
            this.btnRiotGamesServer.Primary = false;
            this.btnRiotGamesServer.Size = new System.Drawing.Size(41, 36);
            this.btnRiotGamesServer.TabIndex = 4;
            this.btnRiotGamesServer.Text = "EUW";
            this.btnRiotGamesServer.UseVisualStyleBackColor = true;
            this.btnRiotGamesServer.Click += new System.EventHandler(this.btnRiotGamesServer_Click);
            // 
            // tbAdress
            // 
            this.tbAdress.Depth = 0;
            this.tbAdress.Hint = "Hostname";
            this.tbAdress.Location = new System.Drawing.Point(157, 29);
            this.tbAdress.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.PasswordChar = '\0';
            this.tbAdress.SelectedText = "";
            this.tbAdress.SelectionLength = 0;
            this.tbAdress.SelectionStart = 0;
            this.tbAdress.Size = new System.Drawing.Size(220, 23);
            this.tbAdress.TabIndex = 2;
            this.tbAdress.UseSystemPasswordChar = false;
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.pictureBox1);
            this.gbOutput.Controls.Add(this.lbPing);
            this.gbOutput.Location = new System.Drawing.Point(12, 120);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(444, 127);
            this.gbOutput.TabIndex = 5;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Output";
            // 
            // lbPing
            // 
            this.lbPing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPing.Font = new System.Drawing.Font("Comfortaa", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPing.Location = new System.Drawing.Point(3, 16);
            this.lbPing.Name = "lbPing";
            this.lbPing.Size = new System.Drawing.Size(438, 108);
            this.lbPing.TabIndex = 7;
            this.lbPing.Text = "Ping...";
            this.lbPing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notIcon
            // 
            this.notIcon.ContextMenuStrip = this.contextMenu;
            this.notIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notIcon.Icon")));
            this.notIcon.Text = "Warn Me Please";
            this.notIcon.DoubleClick += new System.EventHandler(this.notIcon_DoubleClick);
            // 
            // contextMenu
            // 
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Warn_Me_Please.Properties.Resources.errorYellow;
            this.pictureBox1.Location = new System.Drawing.Point(333, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 259);
            this.Controls.Add(this.gbOutput);
            this.Controls.Add(this.gbSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Warn Me Please by mirza";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.gbOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialCheckBox cbShallDo;
        private System.Windows.Forms.Timer tmrDoThat;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.Label lbPing;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbAdress;
        private MaterialSkin.Controls.MaterialFlatButton btnRiotGamesServer;
        private MaterialSkin.Controls.MaterialCheckBox cbWarnMe;
        private System.Windows.Forms.NotifyIcon notIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

