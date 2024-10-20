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

namespace H4Oef3Talstelsel
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

        private void againButton_Click(object sender, RoutedEventArgs e)
        {
            hexadecimalTextBox.Clear();
            decimalTextBox.Clear();
        }

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            string inputHexadecimal = hexadecimalTextBox.Text;
            int outputDecimal = 0;

            for (int placeOfNumberOrLetter = 1; placeOfNumberOrLetter <= inputHexadecimal.Length; placeOfNumberOrLetter++)
            {
                outputDecimal = int.Parse(inputHexadecimal, System.Globalization.NumberStyles.HexNumber);               
            }
            decimalTextBox.Text = $"{outputDecimal}";
        }

        private void hexadecimalTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string inputHexadecimal = hexadecimalTextBox.Text;
                int outputDecimal = 0;

                if (inputHexadecimal.Contains("A") || inputHexadecimal.Contains("B") || inputHexadecimal.Contains("C") || inputHexadecimal.Contains("D") || inputHexadecimal.Contains("E") || inputHexadecimal.Contains("F") || inputHexadecimal.Contains("1") || inputHexadecimal.Contains("2") || inputHexadecimal.Contains("3") || inputHexadecimal.Contains("4") || inputHexadecimal.Contains("5") || inputHexadecimal.Contains("6") || inputHexadecimal.Contains("7") || inputHexadecimal.Contains("8") || inputHexadecimal.Contains("9") || inputHexadecimal.Contains("0") || inputHexadecimal.Contains(" "))
                {
                    for (int placeOfNumberOrLetter = 1; placeOfNumberOrLetter <= inputHexadecimal.Length; placeOfNumberOrLetter++)
                    {
                        outputDecimal = int.Parse(inputHexadecimal, System.Globalization.NumberStyles.HexNumber);
                    }
                    decimalTextBox.Text = $"{outputDecimal}";
                }
                else
                {
                    decimalTextBox.Text = "Foutieve waarde ingegeven; mag enkel 0123456789ABCDEF bevatten";
                }               
            }
        }
    }
}