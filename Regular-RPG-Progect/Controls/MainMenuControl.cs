using System;
using System.Windows.Forms;

namespace Regular_RPG_Progect.Controls
{
    public partial class MainMenuControl : UserControl
    {
        public event Action OnStartGame;
        public event Action OnOpenSettings;
        public event Action OnLoadGame;

        public MainMenuControl()
        {
            InitializeComponent();

            Button btnGame = new Button { Text = "Нова Гра", Dock = DockStyle.Top, Height = 40 };
            Button btnLoadGame = new Button { Text = "Завантажити Гру", Dock = DockStyle.Top, Height = 40 };
            Button btnSettings = new Button { Text = "Налаштування", Dock = DockStyle.Top, Height = 40 };
            Button btnExit = new Button { Text = "Вихід", Dock = DockStyle.Top, Height = 40 };


            btnGame.Click += (s, e) => OnStartGame?.Invoke();
            btnSettings.Click += (s, e) => OnOpenSettings?.Invoke();
            btnLoadGame.Click += (s, e) => OnLoadGame?.Invoke(); // TO DO load object from file
            btnExit.Click += (s, e) => Application.Exit();

            this.Controls.Add(btnExit);
            this.Controls.Add(btnSettings);
            this.Controls.Add(btnLoadGame);
            this.Controls.Add(btnGame);
        }
    }
}
