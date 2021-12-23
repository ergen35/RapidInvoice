using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidInvoice.Extensions
{
    public interface IInvoice
    {
        public string InvoiceID { get; }
        public string InvoiceName { get; }
        public string InvoiceDescription { get; }

        public string Authors { get; }

        public string IconImageFilePath { get; }
        public string SampleImageFilePath { get; }



        public void Save();
        public void Print();
    }
}
