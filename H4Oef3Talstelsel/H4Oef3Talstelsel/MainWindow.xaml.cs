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

        StringBuilder sb = new StringBuilder();

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
            int outputDecimal;

            for (int placeOfNumberOrLetter = 1; placeOfNumberOrLetter <= inputHexadecimal.Length; placeOfNumberOrLetter++)
            {
                outputDecimal = int.Parse(inputHexadecimal, System.Globalization.NumberStyles.HexNumber);
                sb.Append(outputDecimal);
            }
            
            decimalTextBox.Text = sb.ToString;
        }
    }
}