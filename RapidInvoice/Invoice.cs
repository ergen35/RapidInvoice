using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using System.ComponentModel;

namespace RapidInvoice
{   
    [Serializable]
    public class Invoice : INotifyPropertyChanged
    {
        private ObservableCollection<InvoiceElement> _InvoiceElementsCollection;
        double _total = 0;

        public Invoice() 
        {
            this._InvoiceElementsCollection = new ObservableCollection<InvoiceElement>();
        }

        public ObservableCollection<InvoiceElement> InvoiceElementsCollection
        {
            get { return _InvoiceElementsCollection; }

            set {
                    if (this._InvoiceElementsCollection != value)
                    {
                        this._InvoiceElementsCollection = value;
                        this.NotifyPropertyChanged("InvoiceElementsCollection");
                    }
                }
        }

        public double Total
        {   
            get {
                    if (this._InvoiceElementsCollection != null)
                    {
                        foreach (InvoiceElement IE in this._InvoiceElementsCollection)
                        {
                            if (IE != null) { this._total += IE.Montant;}
                        }
                    }

                    return this._total;
                }
        }


        //NotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string Name)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(Name));
            }
        }

    }
}
