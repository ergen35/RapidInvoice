using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            

        }

        private void Btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Tile_Invoice_Click(object sender, RoutedEventArgs e)
        {
            Facturation FW = new Facturation();
            FW.ShowDialog();
        }

        private void Tile_Settings_Click(object sender, RoutedEventArgs e)
        {
            Parametres PM = new Parametres();
            PM.ShowDialog();
        }

        private void Tile_Consult_invoices_Click(object sender, RoutedEventArgs e)
        {
            ListeFactures LF = new ListeFactures();
            LF.ShowDialog();
        }

        private void CreatorLink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
            e.Handled = true;
        }



    }
}
