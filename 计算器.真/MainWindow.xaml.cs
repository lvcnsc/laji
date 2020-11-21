using DynamicExpresso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

namespace 计算器.真
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string _formula = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _formula += ".";
            label1.Content = _formula;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button7_Click_1(object sender, RoutedEventArgs e)
        {
            _formula += "7";
            label1.Content = _formula;
        }

        private void Button8_Click_1(object sender, RoutedEventArgs e)
        {
            _formula += "8";
            label1.Content = _formula;
        }

        private void Button9_Click_1(object sender, RoutedEventArgs e)
        {
            _formula += "9";
            label1.Content = _formula;
        }

        private void Button6_Click_1(object sender, RoutedEventArgs e)
        {
            _formula += "6";
            label1.Content = _formula;
        }

        private void Button5_Click_1(object sender, RoutedEventArgs e)
        {
            _formula += "5";
            label1.Content = _formula;
        }

        private void Button4_Click_1(object sender, RoutedEventArgs e)
        {
            _formula += "4";
            label1.Content = _formula;
        }

        private void Button3_Click_1(object sender, RoutedEventArgs e)
        {
            _formula += "3";
            label1.Content = _formula;
        }

        private void Button2_Click_1(object sender, RoutedEventArgs e)
        {
            _formula += "2";
            label1.Content = _formula;
        }

        private void Button1_Click_1(object sender, RoutedEventArgs e)
        {
            _formula += "1";
            label1.Content = _formula;
        }

        private void Button0_Click_1(object sender, RoutedEventArgs e)
        {
            _formula += "0";
            label1.Content = _formula;
        }

        private void Button_add_Click_1(object sender, RoutedEventArgs e)
        {
            _formula += "+";
            label1.Content = _formula;
        }

        private void Button_sub_Click_1(object sender, RoutedEventArgs e)
        {
            _formula += "-";
            label1.Content = _formula;
        }

        private void Button_mul_Click_1(object sender, RoutedEventArgs e)
        {
            _formula += "*";
            label1.Content = _formula;
        }

        private void Button_div_Click_1(object sender, RoutedEventArgs e)
        {
            _formula += "/";
            label1.Content = _formula;
        }

        private void Button_equ_Click_1(object sender, RoutedEventArgs e)
        {
            var interpreter = new Interpreter();
            var result = interpreter.Eval(_formula);
            label1.Content = result;
        }
    }
}
