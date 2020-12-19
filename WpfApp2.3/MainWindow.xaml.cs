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

namespace WpfApp2._3
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Высокий уровень
            try
            {
                int a = int.Parse(count1.Text);
                int b = int.Parse(count2.Text);
                int c = int.Parse(count3.Text);
                int count = 0;
                if (a > 3 || b > 3 || c > 3)
                {
                    result.Text = "Некорректное значение";
                    goto oshibka;
                }
                switch (a)
                {
                    case 1:
                        count += 0;
                        break;
                    case 2:
                        count += 2;
                        break;
                    case 3:
                        count += 0;
                        break;
                }
                switch (b)
                {
                    case 1:
                        count += 2;
                        break;
                    case 2:
                        count += 0;
                        break;
                    case 3:
                        count += 0;
                        break;
                }
                switch (c)
                {
                    case 1:
                        count += 0;
                        break;
                    case 2:
                        count += 0;
                        break;
                    case 3:
                        count += 1;
                        break;
                }
                result.Text = $"Результат теста {count}/5";
            oshibka: return;
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
