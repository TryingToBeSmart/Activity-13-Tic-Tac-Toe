namespace Activity_13_Tic_Tac_Toe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gamePictureBox = new System.Windows.Forms.PictureBox();
            this.topMiddlePictureBox = new System.Windows.Forms.PictureBox();
            this.topLeftPictureBox = new System.Windows.Forms.PictureBox();
            this.middleMiddlePictureBox = new System.Windows.Forms.PictureBox();
            this.bottomMiddlePictureBox = new System.Windows.Forms.PictureBox();
            this.middleLeftPictureBox = new System.Windows.Forms.PictureBox();
            this.bottomLeftPictureBox = new System.Windows.Forms.PictureBox();
            this.bottomRightPictureBox = new System.Windows.Forms.PictureBox();
            this.middleRightPictureBox = new System.Windows.Forms.PictureBox();
            this.topRightPictureBox = new System.Windows.Forms.PictureBox();
            this.NewGameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gamePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topMiddlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleMiddlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomMiddlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleLeftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleRightPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRightPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gamePictureBox
            // 
            this.gamePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gamePictureBox.BackgroundImage")));
            this.gamePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gamePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gamePictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("gamePictureBox.InitialImage")));
            this.gamePictureBox.Location = new System.Drawing.Point(5, 2);
            this.gamePictureBox.Name = "gamePictureBox";
            this.gamePictureBox.Size = new System.Drawing.Size(960, 689);
            this.gamePictureBox.TabIndex = 0;
            this.gamePictureBox.TabStop = false;
            // 
            // topMiddlePictureBox
            // 
            this.topMiddlePictureBox.BackgroundImage = global::Activity_13_Tic_Tac_Toe.Properties.Resources.blank;
            this.topMiddlePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.topMiddlePictureBox.Cursor = System.Windows.Forms.Cursors.No;
            this.topMiddlePictureBox.Location = new System.Drawing.Point(381, 68);
            this.topMiddlePictureBox.Name = "topMiddlePictureBox";
            this.topMiddlePictureBox.Size = new System.Drawing.Size(239, 185);
            this.topMiddlePictureBox.TabIndex = 2;
            this.topMiddlePictureBox.TabStop = false;
            this.topMiddlePictureBox.Tag = "01";
            this.topMiddlePictureBox.Click += new System.EventHandler(this.topMiddlePictureBox_Click);
            // 
            // topLeftPictureBox
            // 
            this.topLeftPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topLeftPictureBox.BackgroundImage")));
            this.topLeftPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.topLeftPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topLeftPictureBox.Location = new System.Drawing.Point(130, 68);
            this.topLeftPictureBox.Name = "topLeftPictureBox";
            this.topLeftPictureBox.Size = new System.Drawing.Size(239, 185);
            this.topLeftPictureBox.TabIndex = 3;
            this.topLeftPictureBox.TabStop = false;
            this.topLeftPictureBox.Tag = "00";
            this.topLeftPictureBox.Click += new System.EventHandler(this.topLeftPictureBox_Click);
            // 
            // middleMiddlePictureBox
            // 
            this.middleMiddlePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("middleMiddlePictureBox.BackgroundImage")));
            this.middleMiddlePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.middleMiddlePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.middleMiddlePictureBox.Location = new System.Drawing.Point(381, 275);
            this.middleMiddlePictureBox.Name = "middleMiddlePictureBox";
            this.middleMiddlePictureBox.Size = new System.Drawing.Size(239, 185);
            this.middleMiddlePictureBox.TabIndex = 4;
            this.middleMiddlePictureBox.TabStop = false;
            this.middleMiddlePictureBox.Tag = "11";
            this.middleMiddlePictureBox.Click += new System.EventHandler(this.middleMiddlePictureBox_Click);
            // 
            // bottomMiddlePictureBox
            // 
            this.bottomMiddlePictureBox.BackgroundImage = global::Activity_13_Tic_Tac_Toe.Properties.Resources.blank;
            this.bottomMiddlePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bottomMiddlePictureBox.Cursor = System.Windows.Forms.Cursors.No;
            this.bottomMiddlePictureBox.Location = new System.Drawing.Point(381, 481);
            this.bottomMiddlePictureBox.Name = "bottomMiddlePictureBox";
            this.bottomMiddlePictureBox.Size = new System.Drawing.Size(239, 185);
            this.bottomMiddlePictureBox.TabIndex = 5;
            this.bottomMiddlePictureBox.TabStop = false;
            this.bottomMiddlePictureBox.Tag = "21";
            this.bottomMiddlePictureBox.Click += new System.EventHandler(this.bottomMiddlePictureBox_Click);
            // 
            // middleLeftPictureBox
            // 
            this.middleLeftPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("middleLeftPictureBox.BackgroundImage")));
            this.middleLeftPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.middleLeftPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.middleLeftPictureBox.Location = new System.Drawing.Point(130, 275);
            this.middleLeftPictureBox.Name = "middleLeftPictureBox";
            this.middleLeftPictureBox.Size = new System.Drawing.Size(239, 185);
            this.middleLeftPictureBox.TabIndex = 6;
            this.middleLeftPictureBox.TabStop = false;
            this.middleLeftPictureBox.Tag = "10";
            this.middleLeftPictureBox.Click += new System.EventHandler(this.middleLeftPictureBox_Click);
            // 
            // bottomLeftPictureBox
            // 
            this.bottomLeftPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bottomLeftPictureBox.BackgroundImage")));
            this.bottomLeftPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bottomLeftPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bottomLeftPictureBox.Location = new System.Drawing.Point(130, 481);
            this.bottomLeftPictureBox.Name = "bottomLeftPictureBox";
            this.bottomLeftPictureBox.Size = new System.Drawing.Size(239, 185);
            this.bottomLeftPictureBox.TabIndex = 7;
            this.bottomLeftPictureBox.TabStop = false;
            this.bottomLeftPictureBox.Tag = "20";
            this.bottomLeftPictureBox.Click += new System.EventHandler(this.bottomLeftPictureBox_Click);
            // 
            // bottomRightPictureBox
            // 
            this.bottomRightPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bottomRightPictureBox.BackgroundImage")));
            this.bottomRightPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bottomRightPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bottomRightPictureBox.Location = new System.Drawing.Point(631, 481);
            this.bottomRightPictureBox.Name = "bottomRightPictureBox";
            this.bottomRightPictureBox.Size = new System.Drawing.Size(239, 185);
            this.bottomRightPictureBox.TabIndex = 8;
            this.bottomRightPictureBox.TabStop = false;
            this.bottomRightPictureBox.Tag = "22";
            this.bottomRightPictureBox.Click += new System.EventHandler(this.bottomRightPictureBox_Click);
            // 
            // middleRightPictureBox
            // 
            this.middleRightPictureBox.BackgroundImage = global::Activity_13_Tic_Tac_Toe.Properties.Resources.blank;
            this.middleRightPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.middleRightPictureBox.Cursor = System.Windows.Forms.Cursors.No;
            this.middleRightPictureBox.Location = new System.Drawing.Point(631, 275);
            this.middleRightPictureBox.Name = "middleRightPictureBox";
            this.middleRightPictureBox.Size = new System.Drawing.Size(239, 185);
            this.middleRightPictureBox.TabIndex = 9;
            this.middleRightPictureBox.TabStop = false;
            this.middleRightPictureBox.Tag = "12";
            this.middleRightPictureBox.Click += new System.EventHandler(this.middleRightPictureBox_Click);
            // 
            // topRightPictureBox
            // 
            this.topRightPictureBox.BackgroundImage = global::Activity_13_Tic_Tac_Toe.Properties.Resources.blank;
            this.topRightPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.topRightPictureBox.Cursor = System.Windows.Forms.Cursors.No;
            this.topRightPictureBox.Location = new System.Drawing.Point(631, 68);
            this.topRightPictureBox.Name = "topRightPictureBox";
            this.topRightPictureBox.Size = new System.Drawing.Size(239, 185);
            this.topRightPictureBox.TabIndex = 10;
            this.topRightPictureBox.TabStop = false;
            this.topRightPictureBox.Tag = "02";
            this.topRightPictureBox.Click += new System.EventHandler(this.topRightPictureBox_Click);
            // 
            // NewGameButton
            // 
            this.NewGameButton.BackColor = System.Drawing.Color.Black;
            this.NewGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewGameButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.NewGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewGameButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NewGameButton.Location = new System.Drawing.Point(130, 674);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(740, 74);
            this.NewGameButton.TabIndex = 0;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = false;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(29F, 55F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.topRightPictureBox);
            this.Controls.Add(this.middleRightPictureBox);
            this.Controls.Add(this.bottomRightPictureBox);
            this.Controls.Add(this.bottomLeftPictureBox);
            this.Controls.Add(this.middleLeftPictureBox);
            this.Controls.Add(this.bottomMiddlePictureBox);
            this.Controls.Add(this.middleMiddlePictureBox);
            this.Controls.Add(this.topLeftPictureBox);
            this.Controls.Add(this.topMiddlePictureBox);
            this.Controls.Add(this.gamePictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gamePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topMiddlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleMiddlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomMiddlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleLeftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleRightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRightPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gamePictureBox;
        private System.Windows.Forms.PictureBox topMiddlePictureBox;
        private System.Windows.Forms.PictureBox topLeftPictureBox;
        private System.Windows.Forms.PictureBox middleMiddlePictureBox;
        private System.Windows.Forms.PictureBox bottomMiddlePictureBox;
        private System.Windows.Forms.PictureBox middleLeftPictureBox;
        private System.Windows.Forms.PictureBox bottomLeftPictureBox;
        private System.Windows.Forms.PictureBox bottomRightPictureBox;
        private System.Windows.Forms.PictureBox middleRightPictureBox;
        private System.Windows.Forms.PictureBox topRightPictureBox;
        private System.Windows.Forms.Button NewGameButton;
    }
}

