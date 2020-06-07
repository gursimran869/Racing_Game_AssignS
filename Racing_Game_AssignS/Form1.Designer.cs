namespace Racing_Game_AssignS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PB_Rat1 = new System.Windows.Forms.PictureBox();
            this.Pbrat2 = new System.Windows.Forms.PictureBox();
            this.PBrat3 = new System.Windows.Forms.PictureBox();
            this.PBrat4 = new System.Windows.Forms.PictureBox();
            this.setBet = new System.Windows.Forms.Button();
            this.StartRace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Sahil = new System.Windows.Forms.CheckBox();
            this.Higor = new System.Windows.Forms.CheckBox();
            this.Dashmesh = new System.Windows.Forms.CheckBox();
            this.Rat1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Rat2 = new System.Windows.Forms.CheckBox();
            this.Rat3 = new System.Windows.Forms.CheckBox();
            this.Rat4 = new System.Windows.Forms.CheckBox();
            this.lblSahil = new System.Windows.Forms.Label();
            this.lblDashmesh = new System.Windows.Forms.Label();
            this.lblHigor = new System.Windows.Forms.Label();
            this.nmBet = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Rat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbrat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBrat3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBrat4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBet)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Rat1
            // 
            this.PB_Rat1.Image = global::Racing_Game_AssignS.Properties.Resources.rat1;
            this.PB_Rat1.Location = new System.Drawing.Point(0, 188);
            this.PB_Rat1.Name = "PB_Rat1";
            this.PB_Rat1.Size = new System.Drawing.Size(113, 65);
            this.PB_Rat1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Rat1.TabIndex = 0;
            this.PB_Rat1.TabStop = false;
            // 
            // Pbrat2
            // 
            this.Pbrat2.Image = global::Racing_Game_AssignS.Properties.Resources.rat2;
            this.Pbrat2.Location = new System.Drawing.Point(0, 276);
            this.Pbrat2.Name = "Pbrat2";
            this.Pbrat2.Size = new System.Drawing.Size(113, 62);
            this.Pbrat2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbrat2.TabIndex = 1;
            this.Pbrat2.TabStop = false;
            // 
            // PBrat3
            // 
            this.PBrat3.Image = global::Racing_Game_AssignS.Properties.Resources.rat3;
            this.PBrat3.Location = new System.Drawing.Point(0, 369);
            this.PBrat3.Name = "PBrat3";
            this.PBrat3.Size = new System.Drawing.Size(113, 58);
            this.PBrat3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBrat3.TabIndex = 2;
            this.PBrat3.TabStop = false;
            // 
            // PBrat4
            // 
            this.PBrat4.Image = global::Racing_Game_AssignS.Properties.Resources.rat4;
            this.PBrat4.Location = new System.Drawing.Point(0, 447);
            this.PBrat4.Name = "PBrat4";
            this.PBrat4.Size = new System.Drawing.Size(113, 52);
            this.PBrat4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBrat4.TabIndex = 3;
            this.PBrat4.TabStop = false;
            // 
            // setBet
            // 
            this.setBet.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.setBet.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setBet.Location = new System.Drawing.Point(663, 12);
            this.setBet.Name = "setBet";
            this.setBet.Size = new System.Drawing.Size(131, 45);
            this.setBet.TabIndex = 4;
            this.setBet.Text = "Bett";
            this.setBet.UseVisualStyleBackColor = false;
            this.setBet.Click += new System.EventHandler(this.setBet_Click);
            // 
            // StartRace
            // 
            this.StartRace.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.StartRace.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartRace.Location = new System.Drawing.Point(663, 90);
            this.StartRace.Name = "StartRace";
            this.StartRace.Size = new System.Drawing.Size(131, 45);
            this.StartRace.TabIndex = 5;
            this.StartRace.Text = "Run";
            this.StartRace.UseVisualStyleBackColor = false;
            this.StartRace.Click += new System.EventHandler(this.StartRace_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Player Select";
            // 
            // Sahil
            // 
            this.Sahil.AutoSize = true;
            this.Sahil.Location = new System.Drawing.Point(33, 52);
            this.Sahil.Name = "Sahil";
            this.Sahil.Size = new System.Drawing.Size(120, 17);
            this.Sahil.TabIndex = 7;
            this.Sahil.Text = "Sahil has 100 Dollar";
            this.Sahil.UseVisualStyleBackColor = true;
            this.Sahil.CheckedChanged += new System.EventHandler(this.Sahil_CheckedChanged);
            // 
            // Higor
            // 
            this.Higor.AutoSize = true;
            this.Higor.Location = new System.Drawing.Point(33, 129);
            this.Higor.Name = "Higor";
            this.Higor.Size = new System.Drawing.Size(122, 17);
            this.Higor.TabIndex = 9;
            this.Higor.Text = "Higor has 110 Dollar";
            this.Higor.UseVisualStyleBackColor = true;
            // 
            // Dashmesh
            // 
            this.Dashmesh.AutoSize = true;
            this.Dashmesh.Location = new System.Drawing.Point(33, 90);
            this.Dashmesh.Name = "Dashmesh";
            this.Dashmesh.Size = new System.Drawing.Size(141, 17);
            this.Dashmesh.TabIndex = 10;
            this.Dashmesh.Text = "Dashmesh has 90 Dollar";
            this.Dashmesh.UseVisualStyleBackColor = true;
            // 
            // Rat1
            // 
            this.Rat1.AutoSize = true;
            this.Rat1.Location = new System.Drawing.Point(227, 52);
            this.Rat1.Name = "Rat1";
            this.Rat1.Size = new System.Drawing.Size(55, 17);
            this.Rat1.TabIndex = 11;
            this.Rat1.Text = "Rat 1 ";
            this.Rat1.UseVisualStyleBackColor = true;
            this.Rat1.CheckedChanged += new System.EventHandler(this.Rat1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select Rat";
            // 
            // Rat2
            // 
            this.Rat2.AutoSize = true;
            this.Rat2.Location = new System.Drawing.Point(227, 90);
            this.Rat2.Name = "Rat2";
            this.Rat2.Size = new System.Drawing.Size(52, 17);
            this.Rat2.TabIndex = 13;
            this.Rat2.Text = "Rat 2";
            this.Rat2.UseVisualStyleBackColor = true;
            this.Rat2.CheckedChanged += new System.EventHandler(this.Rat2_CheckedChanged);
            // 
            // Rat3
            // 
            this.Rat3.AutoSize = true;
            this.Rat3.Location = new System.Drawing.Point(227, 118);
            this.Rat3.Name = "Rat3";
            this.Rat3.Size = new System.Drawing.Size(52, 17);
            this.Rat3.TabIndex = 14;
            this.Rat3.Text = "Rat 3";
            this.Rat3.UseVisualStyleBackColor = true;
            this.Rat3.CheckedChanged += new System.EventHandler(this.Rat3_CheckedChanged);
            // 
            // Rat4
            // 
            this.Rat4.AutoSize = true;
            this.Rat4.Location = new System.Drawing.Point(227, 152);
            this.Rat4.Name = "Rat4";
            this.Rat4.Size = new System.Drawing.Size(52, 17);
            this.Rat4.TabIndex = 15;
            this.Rat4.Text = "Rat 4";
            this.Rat4.UseVisualStyleBackColor = true;
            this.Rat4.CheckedChanged += new System.EventHandler(this.Rat4_CheckedChanged);
            // 
            // lblSahil
            // 
            this.lblSahil.AutoSize = true;
            this.lblSahil.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSahil.Location = new System.Drawing.Point(288, 52);
            this.lblSahil.Name = "lblSahil";
            this.lblSahil.Size = new System.Drawing.Size(175, 16);
            this.lblSahil.TabIndex = 16;
            this.lblSahil.Text = "Print Message here any ";
            this.lblSahil.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDashmesh
            // 
            this.lblDashmesh.AutoSize = true;
            this.lblDashmesh.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashmesh.Location = new System.Drawing.Point(288, 90);
            this.lblDashmesh.Name = "lblDashmesh";
            this.lblDashmesh.Size = new System.Drawing.Size(175, 16);
            this.lblDashmesh.TabIndex = 17;
            this.lblDashmesh.Text = "Print Message here any ";
            // 
            // lblHigor
            // 
            this.lblHigor.AutoSize = true;
            this.lblHigor.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHigor.Location = new System.Drawing.Point(288, 129);
            this.lblHigor.Name = "lblHigor";
            this.lblHigor.Size = new System.Drawing.Size(175, 16);
            this.lblHigor.TabIndex = 18;
            this.lblHigor.Text = "Print Message here any ";
            // 
            // nmBet
            // 
            this.nmBet.Location = new System.Drawing.Point(524, 13);
            this.nmBet.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmBet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmBet.Name = "nmBet";
            this.nmBet.Size = new System.Drawing.Size(120, 20);
            this.nmBet.TabIndex = 19;
            this.nmBet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(376, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Bet Amount";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(873, 500);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nmBet);
            this.Controls.Add(this.lblHigor);
            this.Controls.Add(this.lblDashmesh);
            this.Controls.Add(this.lblSahil);
            this.Controls.Add(this.Rat4);
            this.Controls.Add(this.Rat3);
            this.Controls.Add(this.Rat2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Rat1);
            this.Controls.Add(this.Dashmesh);
            this.Controls.Add(this.Higor);
            this.Controls.Add(this.Sahil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartRace);
            this.Controls.Add(this.setBet);
            this.Controls.Add(this.PBrat4);
            this.Controls.Add(this.PBrat3);
            this.Controls.Add(this.Pbrat2);
            this.Controls.Add(this.PB_Rat1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Rat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbrat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBrat3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBrat4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Rat1;
        private System.Windows.Forms.PictureBox Pbrat2;
        private System.Windows.Forms.PictureBox PBrat3;
        private System.Windows.Forms.PictureBox PBrat4;
        private System.Windows.Forms.Button setBet;
        private System.Windows.Forms.Button StartRace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Sahil;
        private System.Windows.Forms.CheckBox Higor;
        private System.Windows.Forms.CheckBox Dashmesh;
        private System.Windows.Forms.CheckBox Rat1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Rat2;
        private System.Windows.Forms.CheckBox Rat3;
        private System.Windows.Forms.CheckBox Rat4;
        private System.Windows.Forms.Label lblSahil;
        private System.Windows.Forms.Label lblDashmesh;
        private System.Windows.Forms.Label lblHigor;
        private System.Windows.Forms.NumericUpDown nmBet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
    }
}

