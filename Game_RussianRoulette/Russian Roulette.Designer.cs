namespace Game_RussianRoulette
{
    partial class RouletteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouletteForm));
            this.LoadBtn = new System.Windows.Forms.Button();
            this.Fire1 = new System.Windows.Forms.Button();
            this.SpinBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fire2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Shots = new System.Windows.Forms.TextBox();
            this.Points = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.Statement = new System.Windows.Forms.TextBox();
            this.Welcome = new System.Windows.Forms.TextBox();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.Picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.Color.Olive;
            this.LoadBtn.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoadBtn.Location = new System.Drawing.Point(12, 459);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(148, 54);
            this.LoadBtn.TabIndex = 6;
            this.LoadBtn.Text = "Load Bullet";
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // Fire1
            // 
            this.Fire1.BackColor = System.Drawing.Color.Olive;
            this.Fire1.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fire1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Fire1.Location = new System.Drawing.Point(387, 459);
            this.Fire1.Name = "Fire1";
            this.Fire1.Size = new System.Drawing.Size(215, 54);
            this.Fire1.TabIndex = 7;
            this.Fire1.Text = "Fire at Yourself!";
            this.Fire1.UseVisualStyleBackColor = false;
            this.Fire1.Click += new System.EventHandler(this.Fire1_Click);
            // 
            // SpinBtn
            // 
            this.SpinBtn.BackColor = System.Drawing.Color.Olive;
            this.SpinBtn.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpinBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SpinBtn.Location = new System.Drawing.Point(206, 459);
            this.SpinBtn.Name = "SpinBtn";
            this.SpinBtn.Size = new System.Drawing.Size(157, 54);
            this.SpinBtn.TabIndex = 10;
            this.SpinBtn.Text = "Spin Chamber";
            this.SpinBtn.UseVisualStyleBackColor = false;
            this.SpinBtn.Click += new System.EventHandler(this.SpinBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Shots";
            // 
            // fire2
            // 
            this.fire2.BackColor = System.Drawing.Color.Olive;
            this.fire2.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fire2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fire2.Location = new System.Drawing.Point(643, 459);
            this.fire2.Name = "fire2";
            this.fire2.Size = new System.Drawing.Size(165, 54);
            this.fire2.TabIndex = 13;
            this.fire2.Text = "Fire in Air!";
            this.fire2.UseVisualStyleBackColor = false;
            this.fire2.Click += new System.EventHandler(this.fire2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Points";
            // 
            // Shots
            // 
            this.Shots.Location = new System.Drawing.Point(122, 409);
            this.Shots.Name = "Shots";
            this.Shots.Size = new System.Drawing.Size(104, 22);
            this.Shots.TabIndex = 16;
            // 
            // Points
            // 
            this.Points.Location = new System.Drawing.Point(367, 409);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(119, 22);
            this.Points.TabIndex = 17;
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.Color.Red;
            this.Result.Location = new System.Drawing.Point(500, 161);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(255, 25);
            this.Result.TabIndex = 18;
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Statement
            // 
            this.Statement.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statement.Location = new System.Drawing.Point(500, 274);
            this.Statement.Name = "Statement";
            this.Statement.Size = new System.Drawing.Size(255, 25);
            this.Statement.TabIndex = 19;
            this.Statement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Welcome
            // 
            this.Welcome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.Color.Red;
            this.Welcome.Location = new System.Drawing.Point(500, 39);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(255, 25);
            this.Welcome.TabIndex = 20;
            this.Welcome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_Exit.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Exit.Location = new System.Drawing.Point(731, 377);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(139, 54);
            this.Btn_Exit.TabIndex = 21;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // btn_Restart
            // 
            this.btn_Restart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Restart.Font = new System.Drawing.Font("Monotype Corsiva", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Restart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Restart.Location = new System.Drawing.Point(549, 377);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(139, 54);
            this.btn_Restart.TabIndex = 22;
            this.btn_Restart.Text = "Restart";
            this.btn_Restart.UseVisualStyleBackColor = false;
            this.btn_Restart.Click += new System.EventHandler(this.btn_Restart_Click);
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.Color.Olive;
            this.Picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Picture.BackgroundImage")));
            this.Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Picture.Location = new System.Drawing.Point(12, 12);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(446, 352);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            // 
            // RouletteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.btn_Restart);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.Statement);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.Shots);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fire2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpinBtn);
            this.Controls.Add(this.Fire1);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.Picture);
            this.Name = "RouletteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Russian Roulette";
            this.Load += new System.EventHandler(this.RouletteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button Fire1;
        private System.Windows.Forms.Button SpinBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fire2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Shots;
        private System.Windows.Forms.TextBox Points;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.TextBox Statement;
        private System.Windows.Forms.TextBox Welcome;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button btn_Restart;
    }
}

