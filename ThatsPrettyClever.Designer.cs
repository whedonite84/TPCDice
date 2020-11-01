namespace TPCDice
{
    partial class ThatsPrettyClever
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThatsPrettyClever));
            this.txtYellow = new System.Windows.Forms.TextBox();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.txtOrange = new System.Windows.Forms.TextBox();
            this.txtPurple = new System.Windows.Forms.TextBox();
            this.txtWhite = new System.Windows.Forms.TextBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblRollNum = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RbTPC = new System.Windows.Forms.RadioButton();
            this.RbTwice = new System.Windows.Forms.RadioButton();
            this.BtnDieBack = new System.Windows.Forms.Button();
            this.BtnScore = new System.Windows.Forms.Button();
            this.GrdPlayers = new System.Windows.Forms.DataGridView();
            this.ColPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PicPlayerLock = new System.Windows.Forms.PictureBox();
            this.PicPlatter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrdPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayerLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlatter)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYellow
            // 
            this.txtYellow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtYellow.BackColor = System.Drawing.Color.Yellow;
            this.txtYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYellow.Location = new System.Drawing.Point(183, 22);
            this.txtYellow.Name = "txtYellow";
            this.txtYellow.ReadOnly = true;
            this.txtYellow.Size = new System.Drawing.Size(83, 83);
            this.txtYellow.TabIndex = 0;
            this.txtYellow.Text = "6";
            this.txtYellow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYellow.Click += new System.EventHandler(this.txtDie_Click);
            // 
            // txtBlue
            // 
            this.txtBlue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBlue.BackColor = System.Drawing.Color.Blue;
            this.txtBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlue.Location = new System.Drawing.Point(272, 22);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.ReadOnly = true;
            this.txtBlue.Size = new System.Drawing.Size(83, 83);
            this.txtBlue.TabIndex = 1;
            this.txtBlue.Text = "6";
            this.txtBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBlue.Click += new System.EventHandler(this.txtDie_Click);
            // 
            // txtGreen
            // 
            this.txtGreen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGreen.Location = new System.Drawing.Point(361, 22);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.ReadOnly = true;
            this.txtGreen.Size = new System.Drawing.Size(83, 83);
            this.txtGreen.TabIndex = 2;
            this.txtGreen.Text = "6";
            this.txtGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGreen.Click += new System.EventHandler(this.txtDie_Click);
            // 
            // txtOrange
            // 
            this.txtOrange.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtOrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrange.Location = new System.Drawing.Point(183, 111);
            this.txtOrange.Name = "txtOrange";
            this.txtOrange.ReadOnly = true;
            this.txtOrange.Size = new System.Drawing.Size(83, 83);
            this.txtOrange.TabIndex = 3;
            this.txtOrange.Text = "6";
            this.txtOrange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOrange.Click += new System.EventHandler(this.txtDie_Click);
            // 
            // txtPurple
            // 
            this.txtPurple.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPurple.BackColor = System.Drawing.Color.Purple;
            this.txtPurple.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurple.Location = new System.Drawing.Point(272, 111);
            this.txtPurple.Name = "txtPurple";
            this.txtPurple.ReadOnly = true;
            this.txtPurple.Size = new System.Drawing.Size(83, 83);
            this.txtPurple.TabIndex = 4;
            this.txtPurple.Text = "6";
            this.txtPurple.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPurple.Click += new System.EventHandler(this.txtDie_Click);
            // 
            // txtWhite
            // 
            this.txtWhite.AllowDrop = true;
            this.txtWhite.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtWhite.BackColor = System.Drawing.Color.White;
            this.txtWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWhite.Location = new System.Drawing.Point(361, 111);
            this.txtWhite.Name = "txtWhite";
            this.txtWhite.ReadOnly = true;
            this.txtWhite.Size = new System.Drawing.Size(83, 83);
            this.txtWhite.TabIndex = 5;
            this.txtWhite.Text = "6";
            this.txtWhite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWhite.Click += new System.EventHandler(this.txtDie_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRoll.Location = new System.Drawing.Point(537, 204);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 8;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReset.Location = new System.Drawing.Point(456, 204);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblRollNum
            // 
            this.lblRollNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRollNum.AutoSize = true;
            this.lblRollNum.Location = new System.Drawing.Point(180, 6);
            this.lblRollNum.Name = "lblRollNum";
            this.lblRollNum.Size = new System.Drawing.Size(63, 13);
            this.lblRollNum.TabIndex = 9;
            this.lblRollNum.Text = "Roll #X of 3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Capture";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RbTPC
            // 
            this.RbTPC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RbTPC.AutoSize = true;
            this.RbTPC.Checked = true;
            this.RbTPC.Location = new System.Drawing.Point(448, 22);
            this.RbTPC.Name = "RbTPC";
            this.RbTPC.Size = new System.Drawing.Size(120, 17);
            this.RbTPC.TabIndex = 11;
            this.RbTPC.TabStop = true;
            this.RbTPC.Text = "That\'s Pretty Clever!";
            this.RbTPC.UseVisualStyleBackColor = true;
            this.RbTPC.CheckedChanged += new System.EventHandler(this.RbTPC_CheckedChanged);
            // 
            // RbTwice
            // 
            this.RbTwice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RbTwice.AutoSize = true;
            this.RbTwice.Location = new System.Drawing.Point(448, 46);
            this.RbTwice.Name = "RbTwice";
            this.RbTwice.Size = new System.Drawing.Size(105, 17);
            this.RbTwice.TabIndex = 12;
            this.RbTwice.Text = "Twice As Clever!";
            this.RbTwice.UseVisualStyleBackColor = true;
            this.RbTwice.CheckedChanged += new System.EventHandler(this.RbTwice_CheckedChanged);
            // 
            // BtnDieBack
            // 
            this.BtnDieBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDieBack.Location = new System.Drawing.Point(528, 444);
            this.BtnDieBack.Name = "BtnDieBack";
            this.BtnDieBack.Size = new System.Drawing.Size(75, 23);
            this.BtnDieBack.TabIndex = 13;
            this.BtnDieBack.Text = "Die Back";
            this.BtnDieBack.UseVisualStyleBackColor = true;
            this.BtnDieBack.Click += new System.EventHandler(this.BtnDieBack_Click);
            // 
            // BtnScore
            // 
            this.BtnScore.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnScore.Location = new System.Drawing.Point(537, 175);
            this.BtnScore.Name = "BtnScore";
            this.BtnScore.Size = new System.Drawing.Size(75, 23);
            this.BtnScore.TabIndex = 14;
            this.BtnScore.Text = "Score";
            this.BtnScore.UseVisualStyleBackColor = true;
            this.BtnScore.Click += new System.EventHandler(this.BtnScore_Click);
            // 
            // GrdPlayers
            // 
            this.GrdPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GrdPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColPlayer});
            this.GrdPlayers.Location = new System.Drawing.Point(12, 6);
            this.GrdPlayers.Name = "GrdPlayers";
            this.GrdPlayers.Size = new System.Drawing.Size(145, 209);
            this.GrdPlayers.TabIndex = 15;
            this.GrdPlayers.SelectionChanged += new System.EventHandler(this.GrdPlayers_SelectionChanged);
            // 
            // ColPlayer
            // 
            this.ColPlayer.HeaderText = "Players";
            this.ColPlayer.Name = "ColPlayer";
            this.ColPlayer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PicPlayerLock
            // 
            this.PicPlayerLock.Image = ((System.Drawing.Image)(resources.GetObject("PicPlayerLock.Image")));
            this.PicPlayerLock.Location = new System.Drawing.Point(14, 8);
            this.PicPlayerLock.Name = "PicPlayerLock";
            this.PicPlayerLock.Size = new System.Drawing.Size(19, 19);
            this.PicPlayerLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPlayerLock.TabIndex = 16;
            this.PicPlayerLock.TabStop = false;
            this.PicPlayerLock.Click += new System.EventHandler(this.PicPlayerLock_Click);
            // 
            // PicPlatter
            // 
            this.PicPlatter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicPlatter.Image = global::TPCDice.Properties.Resources.Platter;
            this.PicPlatter.Location = new System.Drawing.Point(12, 229);
            this.PicPlatter.Name = "PicPlatter";
            this.PicPlatter.Size = new System.Drawing.Size(603, 255);
            this.PicPlatter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicPlatter.TabIndex = 0;
            this.PicPlatter.TabStop = false;
            // 
            // ThatsPrettyClever
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 477);
            this.Controls.Add(this.PicPlayerLock);
            this.Controls.Add(this.GrdPlayers);
            this.Controls.Add(this.BtnScore);
            this.Controls.Add(this.BtnDieBack);
            this.Controls.Add(this.RbTwice);
            this.Controls.Add(this.RbTPC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblRollNum);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.txtWhite);
            this.Controls.Add(this.txtPurple);
            this.Controls.Add(this.txtOrange);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.txtYellow);
            this.Controls.Add(this.PicPlatter);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThatsPrettyClever";
            this.Text = "That\'s Pretty Clever!";
            ((System.ComponentModel.ISupportInitialize)(this.GrdPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayerLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlatter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtYellow;
        public System.Windows.Forms.TextBox txtBlue;
        public System.Windows.Forms.TextBox txtGreen;
        public System.Windows.Forms.TextBox txtOrange;
        public System.Windows.Forms.TextBox txtPurple;
        public System.Windows.Forms.TextBox txtWhite;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox PicPlatter;
        private System.Windows.Forms.Label lblRollNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton RbTPC;
        private System.Windows.Forms.RadioButton RbTwice;
        private System.Windows.Forms.Button BtnDieBack;
        private System.Windows.Forms.Button BtnScore;
        public System.Windows.Forms.DataGridView GrdPlayers;
        public System.Windows.Forms.PictureBox PicPlayerLock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPlayer;
    }
}

