using System;

namespace MusicalInstrumentStore2
{
    [Serializable]
    public class EstoqueItem
    {
        private string nbr;
        private string cat;
        private string tp;
        private string nm;
        private double prc;

        public string ItemNumber
        {
            get { return nbr; }
            set { nbr = value; }
        }

        public string Category
        {
            get { return cat; }
            set { cat = value; }
        }

        public string Type
        {
            get { return tp; }
            set { tp = value; }
        }

        public string ItemName
        {
            get { return nm; }
            set { nm = value; }
        }

        public double UnitPrice
        {
            get { return prc; }
            set { prc = value; }
        }

        public virtual bool Equals(EstoqueItem same)
        {
            if ((nbr == same.nbr) &&
                (cat == same.cat) &&
                (tp == same.tp) &&
                (nm == same.nm) &&
                (prc == same.prc))
                return true;
            else
                return false;
        }

        public EstoqueItem()
        {
            nbr = "000000";
            cat = "Acessorios";
            tp = "Acessorios";
            nm = "Nihil";
            prc = 0.00;
        }

        public EstoqueItem(string itmNumber)
        {
            nbr = itmNumber;
            cat = "Acessorios";
            tp = "Acessorios";
            nm = "Nihil";
            prc = 0.00;
        }

        public EstoqueItem(string itmNumber, string category,
                  string type, string name, double price)
        {
            nbr = itmNumber;
            cat = category;
            tp = type;
            nm = name;
            prc = price;
        }
    }
}
