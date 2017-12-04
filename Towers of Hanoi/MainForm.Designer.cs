namespace Towers_of_Hanoi
{
    partial class MainForm
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
            this.txtMoves = new System.Windows.Forms.TextBox();
            this.lblDisk1 = new System.Windows.Forms.Label();
            this.lblDisk2 = new System.Windows.Forms.Label();
            this.lblDisk3 = new System.Windows.Forms.Label();
            this.lblDisk4 = new System.Windows.Forms.Label();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.lblPeg1 = new System.Windows.Forms.Label();
            this.lblPeg2 = new System.Windows.Forms.Label();
            this.lblPeg3 = new System.Windows.Forms.Label();
            this.lblMoves = new System.Windows.Forms.Label();
            this.lblYourMoves = new System.Windows.Forms.Label();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAnimate = new System.Windows.Forms.Button();
            this.tmr = new System.Timers.Timer();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tmr)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMoves
            // 
            this.txtMoves.Location = new System.Drawing.Point(655, 102);
            this.txtMoves.Multiline = true;
            this.txtMoves.Name = "txtMoves";
            this.txtMoves.Size = new System.Drawing.Size(140, 261);
            this.txtMoves.TabIndex = 17;
            // 
            // lblDisk1
            // 
            this.lblDisk1.BackColor = System.Drawing.Color.Lime;
            this.lblDisk1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisk1.Location = new System.Drawing.Point(98, 219);
            this.lblDisk1.Name = "lblDisk1";
            this.lblDisk1.Size = new System.Drawing.Size(48, 24);
            this.lblDisk1.TabIndex = 16;
            this.lblDisk1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblDisk1_MouseDown);
            // 
            // lblDisk2
            // 
            this.lblDisk2.BackColor = System.Drawing.Color.Lime;
            this.lblDisk2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisk2.Location = new System.Drawing.Point(82, 243);
            this.lblDisk2.Name = "lblDisk2";
            this.lblDisk2.Size = new System.Drawing.Size(80, 24);
            this.lblDisk2.TabIndex = 15;
            this.lblDisk2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblDisk1_MouseDown);
            // 
            // lblDisk3
            // 
            this.lblDisk3.BackColor = System.Drawing.Color.Lime;
            this.lblDisk3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisk3.Location = new System.Drawing.Point(66, 267);
            this.lblDisk3.Name = "lblDisk3";
            this.lblDisk3.Size = new System.Drawing.Size(112, 24);
            this.lblDisk3.TabIndex = 14;
            this.lblDisk3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblDisk1_MouseDown);
            // 
            // lblDisk4
            // 
            this.lblDisk4.BackColor = System.Drawing.Color.Lime;
            this.lblDisk4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisk4.Location = new System.Drawing.Point(50, 291);
            this.lblDisk4.Name = "lblDisk4";
            this.lblDisk4.Size = new System.Drawing.Size(144, 24);
            this.lblDisk4.TabIndex = 13;
            this.lblDisk4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblDisk1_MouseDown);
            // 
            // pnlBase
            // 
            this.pnlBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlBase.Location = new System.Drawing.Point(13, 315);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(584, 48);
            this.pnlBase.TabIndex = 9;
            // 
            // lblPeg1
            // 
            this.lblPeg1.AllowDrop = true;
            this.lblPeg1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblPeg1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPeg1.Location = new System.Drawing.Point(109, 187);
            this.lblPeg1.Name = "lblPeg1";
            this.lblPeg1.Size = new System.Drawing.Size(24, 144);
            this.lblPeg1.TabIndex = 10;
            this.lblPeg1.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblPeg1_DragDrop);
            this.lblPeg1.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblPeg1_DragEnter);
            // 
            // lblPeg2
            // 
            this.lblPeg2.AllowDrop = true;
            this.lblPeg2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblPeg2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPeg2.Location = new System.Drawing.Point(289, 187);
            this.lblPeg2.Name = "lblPeg2";
            this.lblPeg2.Size = new System.Drawing.Size(24, 144);
            this.lblPeg2.TabIndex = 11;
            this.lblPeg2.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblPeg1_DragDrop);
            this.lblPeg2.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblPeg1_DragEnter);
            // 
            // lblPeg3
            // 
            this.lblPeg3.AllowDrop = true;
            this.lblPeg3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblPeg3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPeg3.Location = new System.Drawing.Point(469, 187);
            this.lblPeg3.Name = "lblPeg3";
            this.lblPeg3.Size = new System.Drawing.Size(24, 144);
            this.lblPeg3.TabIndex = 12;
            this.lblPeg3.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblPeg1_DragDrop);
            this.lblPeg3.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblPeg1_DragEnter);
            // 
            // lblMoves
            // 
            this.lblMoves.AutoSize = true;
            this.lblMoves.Location = new System.Drawing.Point(782, 57);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(13, 13);
            this.lblMoves.TabIndex = 18;
            this.lblMoves.Text = "0";
            // 
            // lblYourMoves
            // 
            this.lblYourMoves.AutoSize = true;
            this.lblYourMoves.Location = new System.Drawing.Point(652, 57);
            this.lblYourMoves.Name = "lblYourMoves";
            this.lblYourMoves.Size = new System.Drawing.Size(94, 13);
            this.lblYourMoves.TabIndex = 19;
            this.lblYourMoves.Text = "Your Total Moves:";
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGame,
            this.mnuHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(808, 24);
            this.mnuMain.TabIndex = 20;
            this.mnuMain.Text = "Main menu";
            // 
            // mnuGame
            // 
            this.mnuGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReset,
            this.mnuSave,
            this.mnuLoad,
            this.mnuExit});
            this.mnuGame.Name = "mnuGame";
            this.mnuGame.Size = new System.Drawing.Size(50, 20);
            this.mnuGame.Text = "Game";
            // 
            // mnuReset
            // 
            this.mnuReset.Name = "mnuReset";
            this.mnuReset.Size = new System.Drawing.Size(102, 22);
            this.mnuReset.Text = "Reset";
            this.mnuReset.Click += new System.EventHandler(this.mnuReset_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(102, 22);
            this.mnuSave.Text = "Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuLoad
            // 
            this.mnuLoad.Name = "mnuLoad";
            this.mnuLoad.Size = new System.Drawing.Size(102, 22);
            this.mnuLoad.Text = "Load";
            this.mnuLoad.Click += new System.EventHandler(this.mnuLoad_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(102, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            this.mnuHelp.Click += new System.EventHandler(this.mnuHelp_Click);
            // 
            // btnAnimate
            // 
            this.btnAnimate.Location = new System.Drawing.Point(655, 73);
            this.btnAnimate.Name = "btnAnimate";
            this.btnAnimate.Size = new System.Drawing.Size(75, 23);
            this.btnAnimate.TabIndex = 21;
            this.btnAnimate.Text = "Animate";
            this.btnAnimate.UseVisualStyleBackColor = true;
            this.btnAnimate.Click += new System.EventHandler(this.btnAnimate_Click);
            // 
            // tmr
            // 
            this.tmr.Interval = 1000D;
            this.tmr.SynchronizingObject = this;
            this.tmr.Elapsed += new System.Timers.ElapsedEventHandler(this.tmr_Elapsed);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 464);
            this.Controls.Add(this.btnAnimate);
            this.Controls.Add(this.lblYourMoves);
            this.Controls.Add(this.lblMoves);
            this.Controls.Add(this.txtMoves);
            this.Controls.Add(this.lblDisk1);
            this.Controls.Add(this.lblDisk2);
            this.Controls.Add(this.lblDisk3);
            this.Controls.Add(this.lblDisk4);
            this.Controls.Add(this.pnlBase);
            this.Controls.Add(this.lblPeg1);
            this.Controls.Add(this.lblPeg2);
            this.Controls.Add(this.lblPeg3);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "MainForm";
            this.Text = "The Towers of Hanoi";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tmr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMoves;
        private System.Windows.Forms.Label lblDisk1;
        private System.Windows.Forms.Label lblDisk2;
        private System.Windows.Forms.Label lblDisk3;
        private System.Windows.Forms.Label lblDisk4;
        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.Label lblPeg1;
        private System.Windows.Forms.Label lblPeg2;
        private System.Windows.Forms.Label lblPeg3;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.Label lblYourMoves;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuGame;
        private System.Windows.Forms.ToolStripMenuItem mnuReset;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuLoad;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.Button btnAnimate;
        private System.Timers.Timer tmr;
    }
}

