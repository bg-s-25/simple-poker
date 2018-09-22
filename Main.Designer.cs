namespace Simple_Poker
{
    partial class Main
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
            this.b_Start = new System.Windows.Forms.Button();
            this.l_StartingAmnt = new System.Windows.Forms.Label();
            this.nud_StartingAmnt = new System.Windows.Forms.NumericUpDown();
            this.pb_Card1 = new System.Windows.Forms.PictureBox();
            this.pb_Card2 = new System.Windows.Forms.PictureBox();
            this.pb_Card3 = new System.Windows.Forms.PictureBox();
            this.pb_Card4 = new System.Windows.Forms.PictureBox();
            this.pb_Card5 = new System.Windows.Forms.PictureBox();
            this.gb_Controls = new System.Windows.Forms.GroupBox();
            this.b_RaiseBet = new System.Windows.Forms.Button();
            this.b_LowerBet = new System.Windows.Forms.Button();
            this.b_Deal = new System.Windows.Forms.Button();
            this.l_CurBet = new System.Windows.Forms.Label();
            this.l_Credit = new System.Windows.Forms.Label();
            this.l_Win = new System.Windows.Forms.Label();
            this.t_Deal = new System.Windows.Forms.Timer(this.components);
            this.pb_PointsTable = new System.Windows.Forms.PictureBox();
            this.l_Held1 = new System.Windows.Forms.Label();
            this.l_Held2 = new System.Windows.Forms.Label();
            this.l_Held3 = new System.Windows.Forms.Label();
            this.l_Held4 = new System.Windows.Forms.Label();
            this.l_Held5 = new System.Windows.Forms.Label();
            this.l_Hand = new System.Windows.Forms.Label();
            this.t_ShowHand = new System.Windows.Forms.Timer(this.components);
            this.rb_2Turns = new System.Windows.Forms.RadioButton();
            this.rb_3Turns = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nud_StartingAmnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card5)).BeginInit();
            this.gb_Controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PointsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // b_Start
            // 
            this.b_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Start.Location = new System.Drawing.Point(978, 12);
            this.b_Start.Name = "b_Start";
            this.b_Start.Size = new System.Drawing.Size(94, 40);
            this.b_Start.TabIndex = 0;
            this.b_Start.Text = "Start Game";
            this.b_Start.UseVisualStyleBackColor = true;
            this.b_Start.Click += new System.EventHandler(this.b_Start_Click);
            // 
            // l_StartingAmnt
            // 
            this.l_StartingAmnt.AutoSize = true;
            this.l_StartingAmnt.BackColor = System.Drawing.Color.Transparent;
            this.l_StartingAmnt.Location = new System.Drawing.Point(778, 18);
            this.l_StartingAmnt.Name = "l_StartingAmnt";
            this.l_StartingAmnt.Size = new System.Drawing.Size(117, 13);
            this.l_StartingAmnt.TabIndex = 1;
            this.l_StartingAmnt.Text = "Starting Amount (USD):";
            // 
            // nud_StartingAmnt
            // 
            this.nud_StartingAmnt.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_StartingAmnt.Location = new System.Drawing.Point(899, 14);
            this.nud_StartingAmnt.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_StartingAmnt.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_StartingAmnt.Name = "nud_StartingAmnt";
            this.nud_StartingAmnt.Size = new System.Drawing.Size(72, 20);
            this.nud_StartingAmnt.TabIndex = 2;
            this.nud_StartingAmnt.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // pb_Card1
            // 
            this.pb_Card1.BackColor = System.Drawing.Color.White;
            this.pb_Card1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Card1.Location = new System.Drawing.Point(155, 260);
            this.pb_Card1.Name = "pb_Card1";
            this.pb_Card1.Size = new System.Drawing.Size(150, 200);
            this.pb_Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Card1.TabIndex = 3;
            this.pb_Card1.TabStop = false;
            this.pb_Card1.Visible = false;
            this.pb_Card1.Click += new System.EventHandler(this.CenterCardsPB_Click);
            // 
            // pb_Card2
            // 
            this.pb_Card2.BackColor = System.Drawing.Color.White;
            this.pb_Card2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Card2.Location = new System.Drawing.Point(311, 260);
            this.pb_Card2.Name = "pb_Card2";
            this.pb_Card2.Size = new System.Drawing.Size(150, 200);
            this.pb_Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Card2.TabIndex = 4;
            this.pb_Card2.TabStop = false;
            this.pb_Card2.Visible = false;
            this.pb_Card2.Click += new System.EventHandler(this.CenterCardsPB_Click);
            // 
            // pb_Card3
            // 
            this.pb_Card3.BackColor = System.Drawing.Color.White;
            this.pb_Card3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Card3.Location = new System.Drawing.Point(467, 260);
            this.pb_Card3.Name = "pb_Card3";
            this.pb_Card3.Size = new System.Drawing.Size(150, 200);
            this.pb_Card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Card3.TabIndex = 5;
            this.pb_Card3.TabStop = false;
            this.pb_Card3.Visible = false;
            this.pb_Card3.Click += new System.EventHandler(this.CenterCardsPB_Click);
            // 
            // pb_Card4
            // 
            this.pb_Card4.BackColor = System.Drawing.Color.White;
            this.pb_Card4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Card4.Location = new System.Drawing.Point(623, 260);
            this.pb_Card4.Name = "pb_Card4";
            this.pb_Card4.Size = new System.Drawing.Size(150, 200);
            this.pb_Card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Card4.TabIndex = 6;
            this.pb_Card4.TabStop = false;
            this.pb_Card4.Visible = false;
            this.pb_Card4.Click += new System.EventHandler(this.CenterCardsPB_Click);
            // 
            // pb_Card5
            // 
            this.pb_Card5.BackColor = System.Drawing.Color.White;
            this.pb_Card5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Card5.Location = new System.Drawing.Point(779, 260);
            this.pb_Card5.Name = "pb_Card5";
            this.pb_Card5.Size = new System.Drawing.Size(150, 200);
            this.pb_Card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Card5.TabIndex = 7;
            this.pb_Card5.TabStop = false;
            this.pb_Card5.Visible = false;
            this.pb_Card5.Click += new System.EventHandler(this.CenterCardsPB_Click);
            // 
            // gb_Controls
            // 
            this.gb_Controls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Controls.BackColor = System.Drawing.Color.Transparent;
            this.gb_Controls.Controls.Add(this.b_RaiseBet);
            this.gb_Controls.Controls.Add(this.b_LowerBet);
            this.gb_Controls.Controls.Add(this.b_Deal);
            this.gb_Controls.Controls.Add(this.l_CurBet);
            this.gb_Controls.Controls.Add(this.l_Credit);
            this.gb_Controls.Controls.Add(this.l_Win);
            this.gb_Controls.Location = new System.Drawing.Point(12, 561);
            this.gb_Controls.Name = "gb_Controls";
            this.gb_Controls.Size = new System.Drawing.Size(1060, 188);
            this.gb_Controls.TabIndex = 8;
            this.gb_Controls.TabStop = false;
            this.gb_Controls.Visible = false;
            // 
            // b_RaiseBet
            // 
            this.b_RaiseBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_RaiseBet.Location = new System.Drawing.Point(608, 59);
            this.b_RaiseBet.Name = "b_RaiseBet";
            this.b_RaiseBet.Size = new System.Drawing.Size(106, 119);
            this.b_RaiseBet.TabIndex = 16;
            this.b_RaiseBet.Text = "Raise Bet";
            this.b_RaiseBet.UseVisualStyleBackColor = true;
            this.b_RaiseBet.Click += new System.EventHandler(this.b_RaiseBet_Click);
            // 
            // b_LowerBet
            // 
            this.b_LowerBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_LowerBet.Location = new System.Drawing.Point(346, 59);
            this.b_LowerBet.Name = "b_LowerBet";
            this.b_LowerBet.Size = new System.Drawing.Size(106, 119);
            this.b_LowerBet.TabIndex = 15;
            this.b_LowerBet.Text = "Lower Bet";
            this.b_LowerBet.UseVisualStyleBackColor = true;
            this.b_LowerBet.Click += new System.EventHandler(this.b_LowerBet_Click);
            // 
            // b_Deal
            // 
            this.b_Deal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Deal.Location = new System.Drawing.Point(458, 59);
            this.b_Deal.Name = "b_Deal";
            this.b_Deal.Size = new System.Drawing.Size(144, 119);
            this.b_Deal.TabIndex = 14;
            this.b_Deal.Text = "Deal";
            this.b_Deal.UseVisualStyleBackColor = true;
            this.b_Deal.Click += new System.EventHandler(this.b_Deal_Click);
            // 
            // l_CurBet
            // 
            this.l_CurBet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_CurBet.BackColor = System.Drawing.Color.Transparent;
            this.l_CurBet.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_CurBet.ForeColor = System.Drawing.Color.LimeGreen;
            this.l_CurBet.Location = new System.Drawing.Point(368, 14);
            this.l_CurBet.Name = "l_CurBet";
            this.l_CurBet.Size = new System.Drawing.Size(325, 40);
            this.l_CurBet.TabIndex = 13;
            this.l_CurBet.Text = "BET 1 credit";
            this.l_CurBet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l_CurBet.Visible = false;
            // 
            // l_Credit
            // 
            this.l_Credit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_Credit.BackColor = System.Drawing.Color.Transparent;
            this.l_Credit.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Credit.ForeColor = System.Drawing.Color.RoyalBlue;
            this.l_Credit.Location = new System.Drawing.Point(768, 16);
            this.l_Credit.Name = "l_Credit";
            this.l_Credit.Size = new System.Drawing.Size(282, 162);
            this.l_Credit.TabIndex = 12;
            this.l_Credit.Text = "CREDIT\r\n0 credits\r\n$0.00";
            this.l_Credit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.l_Credit.Visible = false;
            // 
            // l_Win
            // 
            this.l_Win.BackColor = System.Drawing.Color.Transparent;
            this.l_Win.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Win.ForeColor = System.Drawing.Color.Gold;
            this.l_Win.Location = new System.Drawing.Point(11, 16);
            this.l_Win.Name = "l_Win";
            this.l_Win.Size = new System.Drawing.Size(282, 162);
            this.l_Win.TabIndex = 11;
            this.l_Win.Text = "WIN\r\n0 credits\r\n$0.00";
            this.l_Win.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.l_Win.Visible = false;
            // 
            // t_Deal
            // 
            this.t_Deal.Interval = 200;
            this.t_Deal.Tick += new System.EventHandler(this.t_Deal_Tick);
            // 
            // pb_PointsTable
            // 
            this.pb_PointsTable.BackColor = System.Drawing.Color.Transparent;
            this.pb_PointsTable.Location = new System.Drawing.Point(12, 12);
            this.pb_PointsTable.Name = "pb_PointsTable";
            this.pb_PointsTable.Size = new System.Drawing.Size(960, 170);
            this.pb_PointsTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_PointsTable.TabIndex = 9;
            this.pb_PointsTable.TabStop = false;
            // 
            // l_Held1
            // 
            this.l_Held1.BackColor = System.Drawing.Color.Transparent;
            this.l_Held1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Held1.ForeColor = System.Drawing.Color.DarkOrange;
            this.l_Held1.Location = new System.Drawing.Point(155, 463);
            this.l_Held1.Name = "l_Held1";
            this.l_Held1.Size = new System.Drawing.Size(150, 30);
            this.l_Held1.TabIndex = 10;
            this.l_Held1.Text = "HELD";
            this.l_Held1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_Held1.Visible = false;
            // 
            // l_Held2
            // 
            this.l_Held2.BackColor = System.Drawing.Color.Transparent;
            this.l_Held2.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Held2.ForeColor = System.Drawing.Color.DarkOrange;
            this.l_Held2.Location = new System.Drawing.Point(311, 463);
            this.l_Held2.Name = "l_Held2";
            this.l_Held2.Size = new System.Drawing.Size(150, 30);
            this.l_Held2.TabIndex = 11;
            this.l_Held2.Text = "HELD";
            this.l_Held2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_Held2.Visible = false;
            // 
            // l_Held3
            // 
            this.l_Held3.BackColor = System.Drawing.Color.Transparent;
            this.l_Held3.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Held3.ForeColor = System.Drawing.Color.DarkOrange;
            this.l_Held3.Location = new System.Drawing.Point(467, 463);
            this.l_Held3.Name = "l_Held3";
            this.l_Held3.Size = new System.Drawing.Size(150, 30);
            this.l_Held3.TabIndex = 12;
            this.l_Held3.Text = "HELD";
            this.l_Held3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_Held3.Visible = false;
            // 
            // l_Held4
            // 
            this.l_Held4.BackColor = System.Drawing.Color.Transparent;
            this.l_Held4.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Held4.ForeColor = System.Drawing.Color.DarkOrange;
            this.l_Held4.Location = new System.Drawing.Point(623, 463);
            this.l_Held4.Name = "l_Held4";
            this.l_Held4.Size = new System.Drawing.Size(150, 30);
            this.l_Held4.TabIndex = 13;
            this.l_Held4.Text = "HELD";
            this.l_Held4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_Held4.Visible = false;
            // 
            // l_Held5
            // 
            this.l_Held5.BackColor = System.Drawing.Color.Transparent;
            this.l_Held5.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Held5.ForeColor = System.Drawing.Color.DarkOrange;
            this.l_Held5.Location = new System.Drawing.Point(779, 463);
            this.l_Held5.Name = "l_Held5";
            this.l_Held5.Size = new System.Drawing.Size(150, 30);
            this.l_Held5.TabIndex = 14;
            this.l_Held5.Text = "HELD";
            this.l_Held5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.l_Held5.Visible = false;
            // 
            // l_Hand
            // 
            this.l_Hand.BackColor = System.Drawing.Color.RoyalBlue;
            this.l_Hand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l_Hand.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Hand.ForeColor = System.Drawing.Color.Gold;
            this.l_Hand.Location = new System.Drawing.Point(254, 316);
            this.l_Hand.Name = "l_Hand";
            this.l_Hand.Size = new System.Drawing.Size(577, 91);
            this.l_Hand.TabIndex = 15;
            this.l_Hand.Text = "(HAND)";
            this.l_Hand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l_Hand.Visible = false;
            // 
            // t_ShowHand
            // 
            this.t_ShowHand.Tick += new System.EventHandler(this.t_ShowHand_Tick);
            // 
            // rb_2Turns
            // 
            this.rb_2Turns.AutoSize = true;
            this.rb_2Turns.Checked = true;
            this.rb_2Turns.Location = new System.Drawing.Point(781, 35);
            this.rb_2Turns.Name = "rb_2Turns";
            this.rb_2Turns.Size = new System.Drawing.Size(57, 17);
            this.rb_2Turns.TabIndex = 16;
            this.rb_2Turns.TabStop = true;
            this.rb_2Turns.Text = "2 turns";
            this.rb_2Turns.UseVisualStyleBackColor = true;
            // 
            // rb_3Turns
            // 
            this.rb_3Turns.AutoSize = true;
            this.rb_3Turns.Location = new System.Drawing.Point(841, 35);
            this.rb_3Turns.Name = "rb_3Turns";
            this.rb_3Turns.Size = new System.Drawing.Size(57, 17);
            this.rb_3Turns.TabIndex = 17;
            this.rb_3Turns.TabStop = true;
            this.rb_3Turns.Text = "3 turns";
            this.rb_3Turns.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.Controls.Add(this.rb_3Turns);
            this.Controls.Add(this.rb_2Turns);
            this.Controls.Add(this.l_Hand);
            this.Controls.Add(this.gb_Controls);
            this.Controls.Add(this.nud_StartingAmnt);
            this.Controls.Add(this.l_StartingAmnt);
            this.Controls.Add(this.b_Start);
            this.Controls.Add(this.pb_PointsTable);
            this.Controls.Add(this.pb_Card5);
            this.Controls.Add(this.pb_Card4);
            this.Controls.Add(this.pb_Card3);
            this.Controls.Add(this.pb_Card2);
            this.Controls.Add(this.pb_Card1);
            this.Controls.Add(this.l_Held5);
            this.Controls.Add(this.l_Held4);
            this.Controls.Add(this.l_Held3);
            this.Controls.Add(this.l_Held2);
            this.Controls.Add(this.l_Held1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Poker - by BGG - v0.1";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_StartingAmnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card5)).EndInit();
            this.gb_Controls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_PointsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Start;
        private System.Windows.Forms.Label l_StartingAmnt;
        private System.Windows.Forms.NumericUpDown nud_StartingAmnt;
        private System.Windows.Forms.PictureBox pb_Card1;
        private System.Windows.Forms.PictureBox pb_Card2;
        private System.Windows.Forms.PictureBox pb_Card3;
        private System.Windows.Forms.PictureBox pb_Card4;
        private System.Windows.Forms.PictureBox pb_Card5;
        private System.Windows.Forms.GroupBox gb_Controls;
        private System.Windows.Forms.Timer t_Deal;
        private System.Windows.Forms.PictureBox pb_PointsTable;
        private System.Windows.Forms.Label l_Held1;
        private System.Windows.Forms.Label l_Held2;
        private System.Windows.Forms.Label l_Held3;
        private System.Windows.Forms.Label l_Held4;
        private System.Windows.Forms.Label l_Held5;
        private System.Windows.Forms.Label l_Credit;
        private System.Windows.Forms.Label l_Win;
        private System.Windows.Forms.Button b_RaiseBet;
        private System.Windows.Forms.Button b_LowerBet;
        private System.Windows.Forms.Button b_Deal;
        private System.Windows.Forms.Label l_CurBet;
        private System.Windows.Forms.Label l_Hand;
        private System.Windows.Forms.Timer t_ShowHand;
        private System.Windows.Forms.RadioButton rb_2Turns;
        private System.Windows.Forms.RadioButton rb_3Turns;
    }
}

