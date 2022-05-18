using System;
using System.Collections.Generic;
using System.Data;
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

namespace WPF_HW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        } // end Main

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = "";
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += " + ";
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += " - ";
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += " * ";
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += " / ";
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text.Contains("*") || txtDisplay.Text.Contains("/"))
            {
                // the only issue is you can't multiply 10 * 10 for example
                // figured it out - use StartsWith instead of Contains
                if (txtDisplay.Text.StartsWith("0"))
                {
                    txtDisplay.Text = "Error";
                }
                else
                {
                    DataTable calculate = new DataTable();
                    var equals = calculate.Compute(txtDisplay.Text, "");
                    txtDisplay.Text += "= " + equals + " ";
                }
            }
            else
            {
                DataTable calculate = new DataTable();
                var equals = calculate.Compute(txtDisplay.Text, "");
                txtDisplay.Text += "= " + equals + " ";
            }
        }

    } // end class
} // end namespace
