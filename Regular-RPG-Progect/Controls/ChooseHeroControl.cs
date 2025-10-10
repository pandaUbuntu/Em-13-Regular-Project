using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Regular_RPG_Progect.Utils;

namespace Regular_RPG_Progect.Controls
{
    public partial class ChooseHeroControl : UserControl
    {
        public event Action OnExit;
        public event Action<Entities.Characters.PlayerClass> OnClassSelected;

        public ChooseHeroControl()
        {
            InitializeComponent();

            this.pictureBox1.Image = AssetManager.LoadImage("tank.png");
            this.pictureBox2.Image = AssetManager.LoadImage("thief.png");
            this.pictureBox3.Image = AssetManager.LoadImage("mage.png");

            this.btnTank.Icon = AssetManager.LoadImage("shield.png");
            this.btnRogue.Icon = AssetManager.LoadImage("dagger.png");
            this.btnMage.Icon = AssetManager.LoadImage("tome.png");

            this.btnTank.Click += (s, e) => OnClassSelected?.Invoke(btnTank.PlayerClass);
            this.btnRogue.Click += (s, e) => OnClassSelected?.Invoke(btnRogue.PlayerClass);
            this.btnMage.Click += (s, e) => OnClassSelected?.Invoke(btnMage.PlayerClass);


            Button btnBack = new Button { Text = "Назад у меню", Dock = DockStyle.Bottom, Height = 40 };


            btnBack.Click += (s, e) => OnExit?.Invoke();

            
            this.Controls.Add(btnBack);
        }
    }
}
