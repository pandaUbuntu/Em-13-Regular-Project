using System;
using System.Windows.Forms;

namespace Regular_RPG_Progect.Controls
{
    public partial class MainMenuControl : UserControl
    {
        public event Action OnStartGame;
        public event Action OnOpenSettings;

        public MainMenuControl()
        {
            InitializeComponent();

            Button btnGame = new Button { Text = "Гра", Dock = DockStyle.Top, Height = 40 };
            Button btnSettings = new Button { Text = "Налаштування", Dock = DockStyle.Top, Height = 40 };

            btnGame.Click += (s, e) => OnStartGame?.Invoke();
            btnSettings.Click += (s, e) => OnOpenSettings?.Invoke();

            this.Controls.Add(btnSettings);
            this.Controls.Add(btnGame);
        }
    }
}
