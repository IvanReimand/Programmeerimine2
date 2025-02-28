using Koliprojekt.WpfApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Kooliprojekt.WpfApp1.Api;
using WpfApp1;

namespace kooliProjekt.WpfApp1;

public partial class MainWindow : Window
{
    private readonly MainWindowViewModel _viewModel;
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var viewModel. = new mainWindowModel(new IApiClient());
            DataContext = viewModel;
            await viewModel.Load();
        }
    }
}