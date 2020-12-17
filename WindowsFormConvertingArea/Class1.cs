using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormConvertingArea
{
    class ConvertEaria
    {
        private string name;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public double getname()
        {
            return Name.Length;
        }

        private double buttons;

        public double Buttons
        {
            set { buttons = value; }
            get { return buttons; }
        }
        public double AddButtons()
        {
            return buttons += buttons;
        }



        private double cm, m, hectar, km;

        public double Cm
        {
            set { cm = value; }
            get { return cm; }
        }
        public double cmToinch()
        {
            return Cm * 0.1550;
        }

        public double M
        {
            set { m = value; }
            get { return m; }
        }
        public double mToyard()
        {
            return m * 1.960;
        }

        public double Hectar
        {
            set { hectar = value; }
            get { return  hectar; }
        }
        public double hectarToacres()
        {
            return hectar * 2.4711;

        }

        public double Km
        {

            set { km = value; }
            get { return km; }
        }
        public double kmTomile()
        {
            return km * 0.3861;
        }
    }
}
