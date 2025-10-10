namespace Regular_RPG_Progect.Controls
{
    partial class ChooseHeroControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnMage = new Regular_RPG_Progect.Controls.Components.ImageButton();
            this.btnRogue = new Regular_RPG_Progect.Controls.Components.ImageButton();
            this.btnTank = new Regular_RPG_Progect.Controls.Components.ImageButton();
            this.imageButton1 = new Regular_RPG_Progect.Controls.Components.ImageButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTank);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(15, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(50, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRogue);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Location = new System.Drawing.Point(310, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 400);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(50, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 290);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMage);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Location = new System.Drawing.Point(605, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 400);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(50, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(180, 290);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // btnMage
            // 
            this.btnMage.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnMage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMage.Icon = null;
            this.btnMage.Location = new System.Drawing.Point(50, 330);
            this.btnMage.Name = "btnMage";
            this.btnMage.PlayerClass = Regular_RPG_Progect.Entities.Characters.PlayerClass.Mage;
            this.btnMage.Size = new System.Drawing.Size(180, 50);
            this.btnMage.TabIndex = 1;
            this.btnMage.Text = "Маг";
            this.btnMage.TextColor = System.Drawing.Color.White;
            // 
            // btnRogue
            // 
            this.btnRogue.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnRogue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRogue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRogue.Icon = null;
            this.btnRogue.Location = new System.Drawing.Point(50, 330);
            this.btnRogue.Name = "btnRogue";
            this.btnRogue.PlayerClass = Regular_RPG_Progect.Entities.Characters.PlayerClass.Rogue;
            this.btnRogue.Size = new System.Drawing.Size(180, 50);
            this.btnRogue.TabIndex = 1;
            this.btnRogue.Text = "Шукач Скарбів";
            this.btnRogue.TextColor = System.Drawing.Color.White;
            // 
            // btnTank
            // 
            this.btnTank.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnTank.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTank.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTank.Icon = null;
            this.btnTank.Location = new System.Drawing.Point(50, 330);
            this.btnTank.Name = "btnTank";
            this.btnTank.PlayerClass = Regular_RPG_Progect.Entities.Characters.PlayerClass.Paladin;
            this.btnTank.Size = new System.Drawing.Size(180, 50);
            this.btnTank.TabIndex = 1;
            this.btnTank.Text = "Паладін";
            this.btnTank.TextColor = System.Drawing.Color.White;
            // 
            // imageButton1
            // 
            this.imageButton1.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.imageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.imageButton1.Icon = null;
            this.imageButton1.Location = new System.Drawing.Point(50, 330);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.PlayerClass = Regular_RPG_Progect.Entities.Characters.PlayerClass.Paladin;
            this.imageButton1.Size = new System.Drawing.Size(180, 50);
            this.imageButton1.TabIndex = 1;
            this.imageButton1.Text = "imageButton1";
            this.imageButton1.TextColor = System.Drawing.Color.White;
            // 
            // ChooseHeroControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChooseHeroControl";
            this.Size = new System.Drawing.Size(900, 600);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Components.ImageButton btnTank;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Components.ImageButton btnRogue;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Components.ImageButton btnMage;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Components.ImageButton imageButton1;
    }
}
