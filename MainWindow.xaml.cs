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

namespace StudentForm
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

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            if(rdbtn_others.IsChecked == true)
            {
                txtbox_nationality.IsEnabled= true;
                txtbox_nationality.Text = "";
                
            }
            else if(rdbtn_india.IsChecked== true)
            {
                txtbox_nationality.IsEnabled= false;
                txtbox_nationality.Text= rdbtn_india.Content.ToString();
            }
        }

        private void btn_sumbit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Succesfully Submitted", "Submission", MessageBoxButton.OK);
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            RadioButton rdbtn = (RadioButton)sender;
            MessageBox.Show(Convert.ToString(rdbtn.Content), "Skills", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }
    }
}
