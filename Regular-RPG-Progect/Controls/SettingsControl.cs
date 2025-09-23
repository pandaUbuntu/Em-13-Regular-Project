using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regular_RPG_Progect.Controls
{
    public partial class SettingsControl : UserControl
    {
        public event Action OnExit;

        public SettingsControl()
        {
            InitializeComponent();

            Label lbl = new Label { Text = "Налаштування ⚙️", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter };
            Button btnBack = new Button { Text = "Назад у меню", Dock = DockStyle.Bottom, Height = 40 };

            btnBack.Click += (s, e) => OnExit?.Invoke();

            this.Controls.Add(lbl);
            this.Controls.Add(btnBack);
        }
    }
}
