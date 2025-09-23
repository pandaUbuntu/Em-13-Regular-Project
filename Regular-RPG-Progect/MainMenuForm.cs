using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Regular_RPG_Progect.Controls;

namespace Regular_RPG_Progect
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            ShowMainMenu();
        }

        private void ShowMainMenu()
        {
            var menu = new MainMenuControl();
            menu.Dock = DockStyle.Fill;
            menu.OnStartGame += () => ShowGame();
            menu.OnOpenSettings += () => ShowSettings();

            this.Controls.Clear();
            this.Controls.Add(menu);
        }

        private void ShowGame()
        {
            var game = new GameControl();
            game.Dock = DockStyle.Fill;
            game.OnExit += () => ShowMainMenu();

            this.Controls.Clear();
            this.Controls.Add(game);
        }

        private void ShowSettings()
        {
            var settings = new SettingsControl();
            settings.Dock = DockStyle.Fill;
            settings.OnExit += () => ShowMainMenu();

            this.Controls.Clear();
            this.Controls.Add(settings);
        }
    }
}
