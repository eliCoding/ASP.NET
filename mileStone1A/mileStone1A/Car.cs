using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mileStone1A
{

    class Car
    {
        public const int MAX = 160;
        public const int MIN = 0;
        public const int SpeedUp = 5;
        public const int SpeedDown = 5;

        private int _yearModel;
        private string _make;
        private int _speed;

        public Car()
        {
            _yearModel = 0;
            _make = "";
            _speed = 0;

        }

        public Car(int yearModel_, string make_)
        {
            _yearModel = yearModel_;
            _make = make_;
            _speed = 0;
        }

        public int YearModel
        {
            get
            {
                return _yearModel;
            }

            set
            {

                _yearModel = value;
            }
        }

        public string Make
        {
            get
            {
                return _make;
            }

            set
            {

                _make = value;
            }
        }

        public int Speed
        {
            get
            {
                return _speed;
            }

            set
            {

                _speed = value;
            }
        }

        public bool Accelerate()
        {
            if (_speed < MIN || _speed > MAX)
            {

                throw new ArgumentOutOfRangeException("speed", "Out of Range Speed");
            }
            else
            {
                _speed += SpeedUp;
                return true;
            }
        }

        public bool Brake()
        {
            if (_speed < MIN || _speed > MAX)
            {

                throw new ArgumentOutOfRangeException("speed", "Out of Range Speed");
            }
            else
            {
                _speed -= SpeedUp;
                return true;
            }
        }
    }
}
