using System;
using System.Windows.Forms;
using Regular_RPG_Progect.Controls.Components;
using Regular_RPG_Progect.Entities.Characters;
using Regular_RPG_Progect.Utils;

namespace Regular_RPG_Progect.Controls
{
    public partial class GameControl : UserControl
    {
        public event Action OnExit;

        public GameControl()
        {
            InitializeComponent();

            this.UpdateScreen(Singleton.GetInstance().Player);
            this.lblPlayerName.Text = Singleton.GetInstance().Player.Name;

            this.btnBack.Click += (s, e) => OnExit?.Invoke();
        }

        private int health = 0;
        public int Health
        {
            get { return health; }
            set
            {
                health = value;
            }
        }

        private void UpdateBoundedValue(BoundedValue boundedValue, AdvancedProgressBar bar)
        {
            bar.MaxValue = boundedValue.Max;
            bar.CurrentValue = boundedValue.Value;
        }

        public void UpdateExpValue(Player player)
        {
            if (player == null)
                throw new Exception("Player not found");

            UpdateBoundedValue(player.Expirience, expirienceBar);
        }

        public void UpdateBoundedValues(Player player)
        {
            if (player == null)
                throw new Exception("Player not found");

            UpdateBoundedValue(player.Health, playerHealthBar);
            UpdateBoundedValue(player.Mana, playerManaBar);
        }

        public void UpdatePlayerLbl(Player player)
        {
            if (player == null)
                throw new Exception("Player not found");

            this.lblClass.Text = player.Class.ToString();
            this.lblLevel.Text = player.Level.ToString();

            this.lblStrenght.Text = player.Strength.ToString();
            this.lblIntelligence.Text = player.Intelligence.ToString();
            this.lblEndurance.Text = player.Endurance.ToString();
            this.lblAgility.Text = player.Agility.ToString();

            this.lblMoney.Text = player.Money.ToString();
        }

        public void UpdateScreen(Player player)
        {
            if (player == null)
                throw new Exception("Player not found");

            this.UpdateBoundedValues(player);
            this.UpdateExpValue(player);
            this.UpdatePlayerLbl(player);

            MessageBox.Show($"Final {playerHealthBar.CurrentValue} {playerHealthBar.MaxValue}");
        }
    }
}
