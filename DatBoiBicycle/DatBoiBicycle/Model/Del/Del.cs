using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatBoiBicycle.Model
{
    abstract class Del
    {
        public string Id { get; set; }
        public double Pris { get; set; }

        public Del()
        {
            
        }

        public Del(string id, double pris)
        {
            Id = id;
            Pris = pris;
        }

        public abstract string DelType();

    }
}
