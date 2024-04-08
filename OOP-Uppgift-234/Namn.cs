using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uppgift_2
{
    internal class Namn
    {
        private string förnamn;
        private string efternamn;
        private DateTime datum;
        private float vikt;
        private float höjd;

        public Namn(string fn, string en, DateTime dat, float vk, float hj)
        {
            förnamn = fn;
            efternamn = en;
            datum = dat;
            vikt = vk;
            höjd = hj;
        }

        public string SetNamn
        {
            get { return förnamn + " " + efternamn; }
            set { förnamn = value.Split(" ")[0]; efternamn = value.Split(" ")[1]; }
        }

        public DateTime setDatum
        {
            get { return datum; }
            set { datum = value; }
        }

        public bool KontrolleraDatum()
        {
            if (datum < DateTime.Now.AddYears(-18))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public float SetHöjd
        {
            get { return höjd; }
            set { höjd = value; }
        }

        public float SetVikt
        {
            get { return vikt; }
            set { vikt = value; }
        }

        public float BMI()
        {
            höjd /= 100;
            return vikt / (höjd * höjd);
        }
    }
}