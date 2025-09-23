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
    public partial class GameControl : UserControl
    {
        public event Action OnExit;

        public GameControl()
        {
            InitializeComponent();

            

            this.btnBack.Click += (s, e) => OnExit?.Invoke();

        }
    }
}
