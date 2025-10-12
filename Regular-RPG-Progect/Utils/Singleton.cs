using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Regular_RPG_Progect.Entities.Characters;

namespace Regular_RPG_Progect.Utils
{
    public sealed class Singleton
    {
        private Player _player = null;

        public Player Player
        {
            get { return _player; }
            set
            {
                _player = value;
            }
        }

        private Singleton() { }

        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }


    }
}
