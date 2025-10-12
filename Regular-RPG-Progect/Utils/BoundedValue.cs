using System;

namespace Regular_RPG_Progect.Utils
{
    public class BoundedValue
    {
        private int _min;
        private int _max;
        private int _currentValue;

        public int Min { get { return _min; } }
        public int Max { get { return _max; } }
        public int Value { get { return _currentValue; } }

        public BoundedValue(int min = 0, int max = 100, bool currentZero = false)
        {
            if (min > max)
                throw new ArgumentException("Min cannot be greater than Max.");

            _min = min;
            if(currentZero)
            {
                _currentValue = 0;
                _max = max;
            } else
            {
                _max = _currentValue = max;
            }
                
        }

        private int ChangeValue(int amount, bool isIncrease = true)
        {
            if (amount < 0)
                throw new ArgumentException("Amount must be non-negative.");

            _currentValue += amount * (isIncrease ? 1 : -1);

            if (_currentValue > _max)
                _currentValue = _max;

            return _currentValue;
        }

        public int Increase(int amount)
        {
            return this.ChangeValue(amount);
        }

        public int Decrease(int amount)
        {
            return this.ChangeValue(amount, false);
        }

        public void ResetValue(int max, bool firtsZero = false)
        {
            if (firtsZero)
            {
                _min = 0;
                _max = max;
            }
            else
            {
                _max = _currentValue = max;
            }    
        }
    }
}
