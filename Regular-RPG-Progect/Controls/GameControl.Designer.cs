namespace Regular_RPG_Progect.Controls
{
    partial class GameControl
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LogTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpExpirience = new System.Windows.Forms.GroupBox();
            this.grpCharacteristics = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(6, 7);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(400, 21);
            this.lblPlayerName.Margin = new System.Windows.Forms.Padding(0);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(116, 26);
            this.lblPlayerName.TabIndex = 1;
            this.lblPlayerName.Text = "PlayerName";
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(900, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Наступний хід";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(3, 426);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(894, 128);
            this.LogTextBox.TabIndex = 3;
            this.LogTextBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(10, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // grpExpirience
            // 
            this.grpExpirience.Location = new System.Drawing.Point(446, 57);
            this.grpExpirience.Name = "grpExpirience";
            this.grpExpirience.Size = new System.Drawing.Size(430, 100);
            this.grpExpirience.TabIndex = 5;
            this.grpExpirience.TabStop = false;
            this.grpExpirience.Text = "Рівень";
            // 
            // grpCharacteristics
            // 
            this.grpCharacteristics.Location = new System.Drawing.Point(446, 163);
            this.grpCharacteristics.Name = "grpCharacteristics";
            this.grpCharacteristics.Size = new System.Drawing.Size(430, 242);
            this.grpCharacteristics.TabIndex = 6;
            this.grpCharacteristics.TabStop = false;
            this.grpCharacteristics.Text = "Характеристики";
            // 
            // GameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.grpCharacteristics);
            this.Controls.Add(this.grpExpirience);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "GameControl";
            this.Size = new System.Drawing.Size(900, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox LogTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpExpirience;
        private System.Windows.Forms.GroupBox grpCharacteristics;
    }
}
