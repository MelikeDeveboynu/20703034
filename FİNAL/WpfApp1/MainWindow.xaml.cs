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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CLİ(object sender, MouseButtonEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Add(textBox1.Text + "                          " + textBox2.Text + "                          " + textBox3.Text);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.Items.IndexOf(listBox1.SelectedItem));
            textBox4.Clear();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Insert(index, textBox4.Text);
            }
            textBox4.Clear();
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                textBox4.Text = listBox1.SelectedItem.ToString();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
