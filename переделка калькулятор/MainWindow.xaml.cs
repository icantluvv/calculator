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

namespace переделка_калькулятор
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Window2 NewWindow;
        public string D;
        public bool flag;
        public string N1;
        int mxlen = 10;
        double result = 0;
        public Window firstWindow;
        public MainWindow()
        {
            flag = false;
            InitializeComponent();           
        }
                        // программа запускается с 0 в поле (стринг). Как только нажимаю кнопку, 0 заменяется (если не 0, то добавляется в строку)
                        // когда нажимаю + - * /, строка из панели идет в переменную, панель очищается, туда заполняется новая строка
                        // как только жму =, переменная с первым числом идет в DN1, строка из панели идет в DN2, счет => результат => панель

        private void Button_Click(object sender, EventArgs e) // when we click button with number
        {
            
            if (flag)
            {
                flag = false; //if i enter a new number after number i don't learn this in new variable
                pole.Text = "0";
            }
            pole.FontSize = 30;
            if (pole.Text.Length > mxlen)
            {
                pole.Text = pole.Text.Remove(pole.Text.Length - 1);
            }

            string B = ((Button)sender).Content.ToString();
            if (pole.Text == "0") //if panel's text = 0 then if we click button with number we change 0 to number or plus number like string
            {
                pole.Text = B; 
            }
            else
            {
                pole.Text += B;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //when we click button C
        {
            pole.Text = "0";
            N1 = "0";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) //when we start the program panel's text = 0
        {
            pole.Text = "0";
            pole.FontSize = 30;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //when we click button with + - * /
        {
            D = ((Button)sender).Content.ToString();
            N1 = pole.Text;
            //pole.Text = "";
            flag = true; //flag says that we learn a new number in 2nd variable
        }

        public void Button_Click_3(object sender, RoutedEventArgs e)
        {

            double DN1, DN2;
            double res = 0; // result
            DN1 = Convert.ToDouble(N1); //learn 1st number in 1st variable
            DN2 = Convert.ToDouble(pole.Text); //learn 2nd number in 2nd variable

            if (pole.Text == "")
            {
                if(D == "+" || D == "-" || D == "/" || D == "X" || D == "=")
                {
                    pole.Text = DN1.ToString();
                    
                }
            }
            
            
            if (D == "+")
            {
                res = DN1 + DN2;
  
            }
            if (D == "-")
            {
                res = DN1 - DN2;

            }
            if (D == "X")
            {
                res = DN1 * DN2;

            }
            if (D == "/")
            {
                
                res = DN1 / DN2;

            }

            if (D == "=" && DN2 == 0)
            {
                pole.Text = "Error";
            }

            D = "=";
            if (DN2 == 0) res = 0;
            pole.Text = res.ToString();
            flag = true;
            result = res;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(pole.Text);
            pole.Text = (a / 100).ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(pole.Text);
            pole.Text = (Math.Pow(x, 2)).ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(pole.Text);
            pole.Text = (Math.Pow(x, 3)).ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(pole.Text);
            if(x >= 0)
            {
                pole.Text = (Math.Sqrt(x)).ToString();
            }
            else
            {
                pole.Text = "0";
            }

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if(pole.Text == "0")
            {
                pole.Text = "0";
            }
            else
            {
                double x = Convert.ToDouble(pole.Text);
                pole.Text = (1 / x).ToString();
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            double znak = Convert.ToDouble(pole.Text);
            pole.Text = (znak * -1).ToString();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            if (pole.Text.Contains(','))
            {
                pole.Text = pole.Text;
            }
            else
            {
                string nov = ((Button)sender).Content.ToString();
                pole.Text += nov;
            }
            
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" '±' may change sine of your number. 'MATR' openes the 2nd calculator with matrices. '1/X' counts the fraction 1/'your number'.", "Instruction", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public bool okno = false;
        void Button_Click_12(object sender, RoutedEventArgs e)
        {
            
            if (okno == false)
            {
                NewWindow = new Window2();
                NewWindow.Show();
                okno = true;
            }
            else
            {
                okno = false;
                NewWindow.Close();
                //NewWindow.Activate();
                //MessageBox.Show("PROGRAMM ALLREADY OPENED");
            }
        }

        private void close_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        public void off_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        public void Button_Click_13(object sender, RoutedEventArgs e)
        {
            if (pole.Text.Length == 2 && pole.Text[0] == '-')
            {
                pole.Text = "0";
            }
            if (result != 0)
            {
                pole.Text = "0";
            }
            if (pole.Text != "0")
            {
                if (pole.Text.Length == 1) pole.Text = "0";
                else pole.Text = pole.Text.Remove(pole.Text.Length -1,  1) ;
            }
            else pole.Text = "0";
        }
    }
}
