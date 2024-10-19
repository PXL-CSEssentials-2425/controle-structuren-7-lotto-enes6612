using System.Security.Cryptography;
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

namespace lotto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            Random randomNumberGenerator = new Random();

            int number1 = randomNumberGenerator.Next(1, 46);
            int number2 = randomNumberGenerator.Next(1, 46);
            int number3 = randomNumberGenerator.Next(1, 46);
            int number4 = randomNumberGenerator.Next(1, 46);
            int number5 = randomNumberGenerator.Next(1, 46);
            int number6 = randomNumberGenerator.Next(1, 46);

            resultLabel.Content = $@"Getal 1: {number1}

Getal 2: {number2}

Getal 3: {number3}

Getal 4: {number4}

Getal 5: {number5}

Getal 6: {number6}";
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = @"Getal 1: 

Getal 2: 

Getal 3: 

Getal 4: 

Getal 5: 

Getal 6: ";
        }
    }
}