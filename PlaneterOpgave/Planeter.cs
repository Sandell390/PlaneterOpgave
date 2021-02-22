using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneterOpgave
{
    class Planeter
    {
        //Opg 1
        private string _Navn { get; set; }
        

        private double _Diamenter { get; set; }


        private double _Gravity { get; set; }

        private double _Temperature { get; set; }


        public string Navn 
        {
            get => _Navn;
            set => _Navn = value;
        }

        public double Diamenter
        {
            get => _Diamenter;
            set => _Diamenter = value;
        }

        public double Gravity
        {
            get => _Gravity;
            set => _Gravity = value;
        }

        public double Temperature
        {
            get => _Temperature;
            set => _Temperature = value;
        }

    }
}
