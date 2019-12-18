namespace _2048SolitaireCPT
{
    partial class frmGame
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileRules = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUserScore = new System.Windows.Forms.Label();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picHandArrow = new System.Windows.Forms.PictureBox();
            this.picStar3 = new System.Windows.Forms.PictureBox();
            this.picStar2 = new System.Windows.Forms.PictureBox();
            this.picStar1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picColumnArrow = new System.Windows.Forms.PictureBox();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblStartGame = new System.Windows.Forms.Label();
            this.lblFinalScore = new System.Windows.Forms.Label();
            this.lblPlayAgain = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHandArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColumnArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(675, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNewGame,
            this.mnuFileExit,
            this.mnuFileRules});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuFileNewGame
            // 
            this.mnuFileNewGame.Name = "mnuFileNewGame";
            this.mnuFileNewGame.Size = new System.Drawing.Size(132, 22);
            this.mnuFileNewGame.Text = "New Game";
            this.mnuFileNewGame.Click += new System.EventHandler(this.mnuFileNewGame_Click);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(132, 22);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuFileRules
            // 
            this.mnuFileRules.Name = "mnuFileRules";
            this.mnuFileRules.Size = new System.Drawing.Size(132, 22);
            this.mnuFileRules.Text = "Rules";
            this.mnuFileRules.Click += new System.EventHandler(this.mnuFileRules_Click);
            // 
            // lblUserScore
            // 
            this.lblUserScore.AutoSize = true;
            this.lblUserScore.Font = new System.Drawing.Font("SketchFlow Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserScore.Location = new System.Drawing.Point(282, 46);
            this.lblUserScore.Name = "lblUserScore";
            this.lblUserScore.Size = new System.Drawing.Size(115, 51);
            this.lblUserScore.TabIndex = 2;
            this.lblUserScore.Text = "000";
            // 
            // btnDiscard
            // 
            this.btnDiscard.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscard.Location = new System.Drawing.Point(491, 574);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(162, 38);
            this.btnDiscard.TabIndex = 7;
            this.btnDiscard.Text = "DISCARD";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SketchFlow Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 724);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hand";
            // 
            // picHandArrow
            // 
            this.picHandArrow.BackgroundImage = global::_2048SolitaireCPT.Graphic.down_arrow;
            this.picHandArrow.Location = new System.Drawing.Point(370, 585);
            this.picHandArrow.Name = "picHandArrow";
            this.picHandArrow.Size = new System.Drawing.Size(30, 30);
            this.picHandArrow.TabIndex = 12;
            this.picHandArrow.TabStop = false;
            this.picHandArrow.Visible = false;
            // 
            // picStar3
            // 
            this.picStar3.BackgroundImage = global::_2048SolitaireCPT.Graphic.StarRed;
            this.picStar3.Location = new System.Drawing.Point(575, 682);
            this.picStar3.Name = "picStar3";
            this.picStar3.Size = new System.Drawing.Size(78, 76);
            this.picStar3.TabIndex = 6;
            this.picStar3.TabStop = false;
            // 
            // picStar2
            // 
            this.picStar2.BackgroundImage = global::_2048SolitaireCPT.Graphic.StarRed;
            this.picStar2.Location = new System.Drawing.Point(491, 682);
            this.picStar2.Name = "picStar2";
            this.picStar2.Size = new System.Drawing.Size(78, 76);
            this.picStar2.TabIndex = 5;
            this.picStar2.TabStop = false;
            // 
            // picStar1
            // 
            this.picStar1.BackgroundImage = global::_2048SolitaireCPT.Graphic.StarRed;
            this.picStar1.Location = new System.Drawing.Point(538, 612);
            this.picStar1.Name = "picStar1";
            this.picStar1.Size = new System.Drawing.Size(78, 76);
            this.picStar1.TabIndex = 4;
            this.picStar1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::_2048SolitaireCPT.Graphic.DottedLine;
            this.pictureBox1.Image = global::_2048SolitaireCPT.Graphic.DottedLine;
            this.pictureBox1.Location = new System.Drawing.Point(-80, 435);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 115);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // picColumnArrow
            // 
            this.picColumnArrow.BackgroundImage = global::_2048SolitaireCPT.Graphic.down_arrow;
            this.picColumnArrow.Location = new System.Drawing.Point(57, 105);
            this.picColumnArrow.Name = "picColumnArrow";
            this.picColumnArrow.Size = new System.Drawing.Size(30, 30);
            this.picColumnArrow.TabIndex = 17;
            this.picColumnArrow.TabStop = false;
            this.picColumnArrow.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::_2048SolitaireCPT.Graphic.DottedLine;
            this.pictureBox2.Image = global::_2048SolitaireCPT.Graphic.DottedLine;
            this.pictureBox2.Location = new System.Drawing.Point(649, 435);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 115);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // lblStartGame
            // 
            this.lblStartGame.AutoSize = true;
            this.lblStartGame.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartGame.Location = new System.Drawing.Point(113, 246);
            this.lblStartGame.Name = "lblStartGame";
            this.lblStartGame.Size = new System.Drawing.Size(456, 60);
            this.lblStartGame.TabIndex = 19;
            this.lblStartGame.Text = "Press \'R\' To Begin";
            // 
            // lblFinalScore
            // 
            this.lblFinalScore.AutoSize = true;
            this.lblFinalScore.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalScore.Location = new System.Drawing.Point(169, 246);
            this.lblFinalScore.Name = "lblFinalScore";
            this.lblFinalScore.Size = new System.Drawing.Size(329, 60);
            this.lblFinalScore.TabIndex = 20;
            this.lblFinalScore.Text = "Final Score:";
            this.lblFinalScore.Visible = false;
            // 
            // lblPlayAgain
            // 
            this.lblPlayAgain.AutoSize = true;
            this.lblPlayAgain.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayAgain.Location = new System.Drawing.Point(47, 348);
            this.lblPlayAgain.Name = "lblPlayAgain";
            this.lblPlayAgain.Size = new System.Drawing.Size(589, 60);
            this.lblPlayAgain.TabIndex = 21;
            this.lblPlayAgain.Text = "Press \'R\' To Play Again";
            this.lblPlayAgain.Visible = false;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 749);
            this.Controls.Add(this.lblPlayAgain);
            this.Controls.Add(this.lblFinalScore);
            this.Controls.Add(this.lblStartGame);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picColumnArrow);
            this.Controls.Add(this.picHandArrow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.picStar3);
            this.Controls.Add(this.picStar2);
            this.Controls.Add(this.picStar1);
            this.Controls.Add(this.lblUserScore);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048 Solitaire";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHandArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColumnArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNewGame;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuFileRules;
        private System.Windows.Forms.Label lblUserScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picStar1;
        private System.Windows.Forms.PictureBox picStar2;
        private System.Windows.Forms.PictureBox picStar3;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picHandArrow;
        private System.Windows.Forms.PictureBox picColumnArrow;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblStartGame;
        private System.Windows.Forms.Label lblFinalScore;
        private System.Windows.Forms.Label lblPlayAgain;
    }
}

