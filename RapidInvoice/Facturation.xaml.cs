using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace RapidInvoice
{
    /// <summary>
    /// Interaction logic for Facturation.xaml
    /// </summary>
    public partial class Facturation : MetroWindow
    {

        public Invoice GInvoice = new Invoice();

        public double InvoiceTotal
        {
            get { return this.GInvoice.Total; }
        }

        public Facturation()
        {
            InitializeComponent();

            GInvoice.InvoiceElementsCollection.Add(new InvoiceElement() { Designation = "Savon", PU = 2500, Quantite = 3 });
            GInvoice.InvoiceElementsCollection.Add(new InvoiceElement() { Designation = "Pain", PU = 663, Quantite = 23 });
            GInvoice.InvoiceElementsCollection.Add(new InvoiceElement() { Designation = "Viande", PU = 1202, Quantite = 6.5 });
            GInvoice.InvoiceElementsCollection.Add(new InvoiceElement() { Designation = "Cochon", PU = 891, Quantite = 32 });

            this.FactureDataGrid.ItemsSource = GInvoice.InvoiceElementsCollection;


        }



        private void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            //Close this window, then show the parent window
            this.Close();
            Application.Current.MainWindow.Activate();
            
        }

        private void FactureNumber_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double?> e)
        {
            if (FactureNumber.Value == null)
                FactureNumber.Value = FactureNumber.Minimum;
        }

        private void btn_AddToInvoice_Click(object sender, RoutedEventArgs e)
        {
            InvoiceElement IE = new InvoiceElement() { Designation = this.ProductName_txtb.Text.ToString(), PU = Convert.ToDouble(this.PU.Value), Quantite = Convert.ToDouble(this.Qte.Value) };

            GInvoice.InvoiceElementsCollection.Add(IE);
            
            //Add to the Invoice DataGrid
            this.FactureDataGrid.ItemsSource = this.GInvoice.InvoiceElementsCollection;
        }

        private void DeleteSelectedItem_btn_Click(object sender, RoutedEventArgs e)
        {
            if (this.FactureDataGrid.SelectedIndex >= 0)
            {
                InvoiceElement SelectedSale = (this.FactureDataGrid.SelectedItem as InvoiceElement);

                if (SelectedSale != null)
                {
                    this.GInvoice.InvoiceElementsCollection.Remove(SelectedSale);
                }

            }

            this.FactureDataGrid.ItemsSource = this.GInvoice.InvoiceElementsCollection;
        }

        private void RefreshDataGrid_btn_Click(object sender, RoutedEventArgs e)
        {   
            // Refresh...
            this.FactureDataGrid.ItemsSource = this.GInvoice.InvoiceElementsCollection;
        }

        private void SaveInvoice_btn_Click(object sender, RoutedEventArgs e)
        {
            //Select PDF
        }

    }

    public class PUxQte_ValueConverter : IMultiValueConverter
    {

        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double Sum = 1;
            for (int i = 0; i < values.Length; i++)
			{
                if (values[i] != null)
                {
                    Sum = Sum * (double)values[i];
                }
			}

            return Sum.ToString();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            object[] Tableau = {0,0};

            return Tableau;
        }
    }
}
