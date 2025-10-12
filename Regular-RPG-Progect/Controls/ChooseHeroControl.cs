using System;
using System.Windows.Forms;
using Regular_RPG_Progect.Controls.Components;
using Regular_RPG_Progect.Utils;

namespace Regular_RPG_Progect.Controls
{
    public partial class ChooseHeroControl : UserControl
    {
        public event Action OnExit;
        public event Action OnClassSelected;

        public ChooseHeroControl()
        {
            InitializeComponent();

            this.pictureBox1.Image = AssetManager.LoadImage("tank.png");
            this.pictureBox2.Image = AssetManager.LoadImage("thief.png");
            this.pictureBox3.Image = AssetManager.LoadImage("mage.png");

            this.btnTank.Icon = AssetManager.LoadImage("shield.png");
            this.btnRogue.Icon = AssetManager.LoadImage("dagger.png");
            this.btnMage.Icon = AssetManager.LoadImage("tome.png");

            this.btnTank.Click += BtnBack_Click;
            this.btnRogue.Click += BtnBack_Click;
            this.btnMage.Click += BtnBack_Click;

            Button btnBack = new Button { Text = "Назад у меню", Dock = DockStyle.Bottom, Height = 40 };
            btnBack.Click += (s, e) => OnExit?.Invoke();

            this.Controls.Add(btnBack);
        }

        protected void BtnBack_Click(object sender, EventArgs e)
        {
            ImageButton btn = sender as ImageButton;

            if (this.txtBoxName.Text.Trim().Length == 0)
            {
                MessageBoxHelper.WarningPopup("Заповніть ім'я персонажа!");
            } else {
                if (Singleton.GetInstance().Player != null)
                {
                    DialogResult result = MessageBoxHelper.InfoPopupDialog("У вас уже є створений персонаж, замінити?");

                    if (result == DialogResult.OK)
                    {
                        Singleton.GetInstance().Player = CreatePlayerHelper.CreatePlayer(this.txtBoxName.Text.Trim(), btn.PlayerClass);
                        OnClassSelected?.Invoke();
                    }
                    else
                    {
                        OnExit?.Invoke();
                    }
                }
                else
                {
                    Singleton.GetInstance().Player = CreatePlayerHelper.CreatePlayer(this.txtBoxName.Text.Trim(), btn.PlayerClass);
                    OnClassSelected?.Invoke();
                }
            }
        }
    }


}
