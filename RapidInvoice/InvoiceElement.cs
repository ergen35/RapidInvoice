using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidInvoice
{
    [Serializable]
    public class InvoiceElement
    {
        private double _Price;
        private double _Quantity;

        public InvoiceElement() { }

        public String Designation { get; set; } //Desigantion

        public double PU             //PU
        {
            get { return _Price; }
            set { _Price = value; }
        }

        public double Quantite         //Quantite
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }

        public double Montant
        {
            get { return this._Price * this._Quantity; }
        }
        
    }
}
