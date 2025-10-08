using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Regular_RPG_Progect.Entities.Characters;

namespace Regular_RPG_Progect.Controls
{
    public partial class GameControl : UserControl
    {
        public event Action OnExit;

        public GameControl()
        {
            InitializeComponent();

            

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

        private void button2_Click(object sender, EventArgs e)
        {
            Player player = new Player("Alex", PlayerClass.Paladin, 5, 3, 2, 4);

            player.AddExpirience(100);
        }
    }
}
