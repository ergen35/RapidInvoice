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
using Window = MahApps.Metro.Controls.MetroWindow;
using GalaSoft.MvvmLight.Command;

namespace RapidInvoice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ICommand ExitCommand => new RelayCommand(ExitApp);
        public ICommand OpenSettingsCommand => new RelayCommand(OpenSettings);
        public ICommand AboutCommand => new RelayCommand(ShowAboutDialog);
        public ICommand ViewInvoicesCommand => new RelayCommand(ViewInvoices);
        public ICommand NewInvoiceCommand => new RelayCommand(NewInvoice);


        public MainWindow()
        {
            InitializeComponent();
        }


        private void NewInvoice()
        {

        }

        private void ViewInvoices()
        {
            
        }

        private void ShowAboutDialog() 
        {
            
        }

        private void OpenSettings()
        {
            var pm = new Parametres();
            pm.ShowDialog();
        }
        private void CreatorLink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
            e.Handled = true;
        }
        private void ExitApp()
        {
            Close();
        }
    }
}
