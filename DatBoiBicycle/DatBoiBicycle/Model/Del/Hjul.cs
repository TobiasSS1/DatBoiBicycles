using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatBoiBicycle.Model
{
    class Hjul : Del
    {
        public string HjulStørrelse { get; set; }

        public Hjul(string id, double pris, string hjulstørrel) :base(id, pris)
        {
            this.HjulStørrelse = hjulstørrel;
        }


        public override string DelType()
        {
            return "Hjul";
        }
    }
}
