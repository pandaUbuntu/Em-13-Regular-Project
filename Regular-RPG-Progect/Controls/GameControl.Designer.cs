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
            this.playerManaBar = new Regular_RPG_Progect.Controls.Components.AdvancedProgressBar();
            this.playerHealthBar = new Regular_RPG_Progect.Controls.Components.AdvancedProgressBar();
            this.grpExpirience = new System.Windows.Forms.GroupBox();
            this.grpCharacteristics = new System.Windows.Forms.GroupBox();
            this.expirienceBar = new Regular_RPG_Progect.Controls.Components.AdvancedProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblStrenght = new System.Windows.Forms.Label();
            this.lblAgility = new System.Windows.Forms.Label();
            this.lblIntelligence = new System.Windows.Forms.Label();
            this.lblEndurance = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpExpirience.SuspendLayout();
            this.grpCharacteristics.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.playerManaBar);
            this.groupBox1.Controls.Add(this.playerHealthBar);
            this.groupBox1.Location = new System.Drawing.Point(10, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // playerManaBar
            // 
            this.playerManaBar.BarColor = System.Drawing.Color.SkyBlue;
            this.playerManaBar.CurrentValue = 100;
            this.playerManaBar.Location = new System.Drawing.Point(8, 62);
            this.playerManaBar.Margin = new System.Windows.Forms.Padding(6);
            this.playerManaBar.MaxValue = 200;
            this.playerManaBar.MinValue = 0;
            this.playerManaBar.Name = "playerManaBar";
            this.playerManaBar.Size = new System.Drawing.Size(412, 30);
            this.playerManaBar.TabIndex = 1;
            // 
            // playerHealthBar
            // 
            this.playerHealthBar.BarColor = System.Drawing.Color.Crimson;
            this.playerHealthBar.CurrentValue = 100;
            this.playerHealthBar.Location = new System.Drawing.Point(8, 24);
            this.playerHealthBar.Margin = new System.Windows.Forms.Padding(6);
            this.playerHealthBar.MaxValue = 200;
            this.playerHealthBar.MinValue = 0;
            this.playerHealthBar.Name = "playerHealthBar";
            this.playerHealthBar.Size = new System.Drawing.Size(412, 30);
            this.playerHealthBar.TabIndex = 0;
            // 
            // grpExpirience
            // 
            this.grpExpirience.Controls.Add(this.expirienceBar);
            this.grpExpirience.Location = new System.Drawing.Point(446, 57);
            this.grpExpirience.Name = "grpExpirience";
            this.grpExpirience.Size = new System.Drawing.Size(430, 81);
            this.grpExpirience.TabIndex = 5;
            this.grpExpirience.TabStop = false;
            this.grpExpirience.Text = "Рівень";
            // 
            // grpCharacteristics
            // 
            this.grpCharacteristics.Controls.Add(this.lblMoney);
            this.grpCharacteristics.Controls.Add(this.lblEndurance);
            this.grpCharacteristics.Controls.Add(this.lblIntelligence);
            this.grpCharacteristics.Controls.Add(this.lblAgility);
            this.grpCharacteristics.Controls.Add(this.lblStrenght);
            this.grpCharacteristics.Controls.Add(this.lblClass);
            this.grpCharacteristics.Controls.Add(this.lblLevel);
            this.grpCharacteristics.Controls.Add(this.label7);
            this.grpCharacteristics.Controls.Add(this.label6);
            this.grpCharacteristics.Controls.Add(this.label5);
            this.grpCharacteristics.Controls.Add(this.label4);
            this.grpCharacteristics.Controls.Add(this.label3);
            this.grpCharacteristics.Controls.Add(this.label2);
            this.grpCharacteristics.Controls.Add(this.label1);
            this.grpCharacteristics.Location = new System.Drawing.Point(446, 144);
            this.grpCharacteristics.Name = "grpCharacteristics";
            this.grpCharacteristics.Size = new System.Drawing.Size(430, 276);
            this.grpCharacteristics.TabIndex = 6;
            this.grpCharacteristics.TabStop = false;
            this.grpCharacteristics.Text = "Характеристики";
            // 
            // expirienceBar
            // 
            this.expirienceBar.BarColor = System.Drawing.Color.YellowGreen;
            this.expirienceBar.CurrentValue = 0;
            this.expirienceBar.Location = new System.Drawing.Point(9, 36);
            this.expirienceBar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.expirienceBar.MaxValue = 100;
            this.expirienceBar.MinValue = 0;
            this.expirienceBar.Name = "expirienceBar";
            this.expirienceBar.Size = new System.Drawing.Size(412, 30);
            this.expirienceBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клас:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сила:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Витривалість:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Інтелект:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Рівень:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Спритність:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Гроші:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(159, 41);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(24, 26);
            this.lblLevel.TabIndex = 7;
            this.lblLevel.Text = "0";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(159, 67);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(24, 26);
            this.lblClass.TabIndex = 8;
            this.lblClass.Text = "0";
            // 
            // lblStrenght
            // 
            this.lblStrenght.AutoSize = true;
            this.lblStrenght.Location = new System.Drawing.Point(159, 93);
            this.lblStrenght.Name = "lblStrenght";
            this.lblStrenght.Size = new System.Drawing.Size(24, 26);
            this.lblStrenght.TabIndex = 9;
            this.lblStrenght.Text = "0";
            // 
            // lblAgility
            // 
            this.lblAgility.AutoSize = true;
            this.lblAgility.Location = new System.Drawing.Point(159, 119);
            this.lblAgility.Name = "lblAgility";
            this.lblAgility.Size = new System.Drawing.Size(24, 26);
            this.lblAgility.TabIndex = 10;
            this.lblAgility.Text = "0";
            // 
            // lblIntelligence
            // 
            this.lblIntelligence.AutoSize = true;
            this.lblIntelligence.Location = new System.Drawing.Point(159, 145);
            this.lblIntelligence.Name = "lblIntelligence";
            this.lblIntelligence.Size = new System.Drawing.Size(24, 26);
            this.lblIntelligence.TabIndex = 11;
            this.lblIntelligence.Text = "0";
            // 
            // lblEndurance
            // 
            this.lblEndurance.AutoSize = true;
            this.lblEndurance.Location = new System.Drawing.Point(159, 171);
            this.lblEndurance.Name = "lblEndurance";
            this.lblEndurance.Size = new System.Drawing.Size(24, 26);
            this.lblEndurance.TabIndex = 12;
            this.lblEndurance.Text = "0";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(159, 197);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(24, 26);
            this.lblMoney.TabIndex = 13;
            this.lblMoney.Text = "0";
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
            this.groupBox1.ResumeLayout(false);
            this.grpExpirience.ResumeLayout(false);
            this.grpCharacteristics.ResumeLayout(false);
            this.grpCharacteristics.PerformLayout();
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
        private Components.AdvancedProgressBar playerManaBar;
        private Components.AdvancedProgressBar playerHealthBar;
        private Components.AdvancedProgressBar expirienceBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblEndurance;
        private System.Windows.Forms.Label lblIntelligence;
        private System.Windows.Forms.Label lblAgility;
        private System.Windows.Forms.Label lblStrenght;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblLevel;
    }
}
