using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adjuster
{
    class AdjusterBase
    {

        private double _valueHour;
        private int _qtdDays;

        public double valueHour
        {
            set
            {
                if (value > 220)
                {
                    _valueHour = 220;
                }
                else if (value < 40)
                    _valueHour = 40;
                else
                    _valueHour = value;
            }
            get
            {
                return _valueHour;
            }
        }

        public int qtdDays
        {
            set
            {
                if (value > 40)
                {
                    _qtdDays = 40;
                }
                else if (value < 16)
                {
                    _qtdDays = 16;
                }
                else
                    _qtdDays = value;
            }
            get
            {
                return _qtdDays;
            }
        }
        public double salCalc
        {
            get
            {
                return qtdDays * valueHour * 2.5f;
            }
        }


        public void readjusterValue(double x)
        {
           valueHour += valueHour * x / 100;
        }

        public AdjusterBase()
        {
           qtdDays = 16;
           valueHour = 40;
        }
        public AdjusterBase(int qtdD, double vlH)
        {
           qtdDays = qtdD;
           valueHour = vlH;
        }

    }
}
