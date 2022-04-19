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
using System.Windows.Shapes;

namespace переделка_калькулятор
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //проверка на пустоту в матрице

            tb2.Text = "";
            tb3.Text = "";
            

            if (a_11.Text == "" || a_12.Text == "" || a_13.Text == "" || a_21.Text == "" ||
                a_22.Text == "" || a_23.Text == "" || a_31.Text == "" || a_32.Text == "" || a_33.Text == "")
            {
                MessageBox.Show("WRONG!!!");
                // button1.Background = Brushes.Red;
                

            }
            else
            {
                //A1

                //считывания

                int a11 = int.Parse(a_11.Text);
                //Console.WriteLine(a11);
                int a22 = int.Parse(a_22.Text);
                //Console.WriteLine(a22);
                int a33 = int.Parse(a_33.Text);
                //Console.WriteLine(a33);
                //Console.WriteLine(a11 * (a22*a33));
                int a23 = int.Parse(a_23.Text);
                int a32 = int.Parse(a_32.Text);
                

                int A1 = a11 * (a22 * a33 - a23 * a32); //счёт
                Console.WriteLine("A1 = " + A1);

                //A2

                int a12 = int.Parse(a_12.Text);
                int a21 = int.Parse(a_21.Text);
                //int a23 = int.Parse(a_23.Text);
                int a31 = int.Parse(a_31.Text);
                //int a33 = int.Parse(a_33.Text);

                int A2 = a12 * (a21 * a33 - a23 * a31);
                Console.WriteLine("A2 = " + A2);

                //A3


                int a13 = int.Parse(a_13.Text);
                //int a21 = int.Parse(a_21.Text);
                //int a23 = int.Parse(a_23.Text);
                //int a22 = int.Parse(a_32.Text);
                //int a31 = int.Parse(a_33.Text);
                //int a32 = int.Parse(a_32.Text);

                int A3 = a13 * (a21 * a32 - a22 * a31);
                Console.WriteLine("A3 = " + A3);

                int DET_A = A1 - A2 + A3;

                string txt = DET_A.ToString();
                tb2.Text = "DET A = " + txt;

                string A111 = A1.ToString();
                string A222 = A2.ToString();
                string A333 = A3.ToString();
                tb3.Text = "A1 = " + A111 + "; " + "A2 = " + A222 + "; " + "A3 = " + A333 + ";";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //проверка на пустоту в матрице
            if (b_11.Text == "" || b_12.Text == "" || b_13.Text == "" || b_21.Text == "" ||
                b_22.Text == "" || b_23.Text == "" || b_31.Text == "" || b_32.Text == "" || b_33.Text == "")
            {
                MessageBox.Show("WRONG!!!");

            }
            else
            {
                //B1

                int b11 = int.Parse(b_11.Text);
                //Console.WriteLine(a11);
                int b22 = int.Parse(b_22.Text);
                //Console.WriteLine(a22);
                int b33 = int.Parse(b_33.Text);
                //Console.WriteLine(b33);
                //Console.WriteLine(b11 * (b22*b33));
                int b23 = int.Parse(b_23.Text);
                int b32 = int.Parse(b_32.Text);

                int B1 = b11 * (b22 * b33 - b23 * b32);
                Console.WriteLine("B1 = " + B1);

                //B2

                int b12 = int.Parse(b_12.Text);
                int b21 = int.Parse(b_21.Text);
                //int b23 = int.Parse(b_23.Text);
                int b31 = int.Parse(b_31.Text);
                //int b33 = int.Parse(b_33.Text);

                int B2 = b12 * (b21 * b33 - b23 * b31);
                Console.WriteLine("B2 = " + B2);

                //B3


                int b13 = int.Parse(b_13.Text);
                //int b21 = int.Parse(b_21.Text);
                //int b23 = int.Parse(b_23.Text);
                //int b22 = int.Parse(b_32.Text);
                //int b31 = int.Parse(b_33.Text);
                //int b32 = int.Parse(b_32.Text);

                int B3 = b13 * (b21 * b32 - b22 * b31);
                Console.WriteLine("B3 = " + B3);

                int DET_B = B1 - B2 + B3;

                string txt = DET_B.ToString();
                tb2.Text = "DET B = " + txt;

                string B111 = B1.ToString();
                string B222 = B2.ToString();
                string B333 = B3.ToString();
                tb3.Text = "B1 = " + B111 + "; " + "B2 = " + B222 + "; " + "B3 = " + B333 + ";";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //проверка на пустоту в ячейках матриц
            if (a_11.Text != "" && a_12.Text != "" && a_13.Text != "" && a_21.Text != "" && a_22.Text != "" && a_23.Text != "" &&
                a_31.Text != "" && a_32.Text != "" && a_33.Text != "" &&
                b_11.Text != "" && b_12.Text != "" && b_13.Text != "" && b_21.Text != "" && b_22.Text != "" && b_23.Text != "" &&
                b_31.Text != "" && b_32.Text != "" && b_33.Text != "")
            {
                // считываю все значения в матрицах
                int a11 = int.Parse(a_11.Text);
                int a12 = int.Parse(a_12.Text);
                int a13 = int.Parse(a_13.Text);
                int a21 = int.Parse(a_21.Text);
                int a22 = int.Parse(a_22.Text);
                int a23 = int.Parse(a_23.Text);
                int a31 = int.Parse(a_31.Text);
                int a32 = int.Parse(a_32.Text);
                int a33 = int.Parse(a_33.Text);

                int b11 = int.Parse(b_11.Text);
                int b12 = int.Parse(b_12.Text);
                int b13 = int.Parse(b_13.Text);
                int b21 = int.Parse(b_21.Text);
                int b22 = int.Parse(b_22.Text);
                int b23 = int.Parse(b_23.Text);
                int b31 = int.Parse(b_31.Text);
                int b32 = int.Parse(b_32.Text);
                int b33 = int.Parse(b_33.Text);

                //Сохраняю суммы элементов матриц в массив, делаю новую матрицу 
               /* int[,] SUMM = {
                    {a11 + b11, a12 + b12, a13 + b13},
                    {a21 + b21, a22 + b22, a23 + b23},
                    {a31 + b31, a32 + b32, a33 + b33}
                };

                int height = SUMM.GetLength(0); //строки
                int width = SUMM.GetLength(1); //столбы

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write(SUMM[i, j] + "\t"); //вывод строк 
                    }
                    Console.WriteLine(); // вывод в столбы
                }*/
                c_11.Text = (a11 + b11).ToString();
                c_12.Text = (a12 + b12).ToString();
                c_13.Text = (a13 + b13).ToString();
                c_21.Text = (a21 + b21).ToString();
                c_22.Text = (a22 + b22).ToString();
                c_23.Text = (a23 + b23).ToString();
                c_31.Text = (a31 + b31).ToString();
                c_32.Text = (a32 + b32).ToString();
                c_33.Text = (a33 + b33).ToString();


                //  tb.Text = // как сделать вывод в тб матрицей, а не строкой?
            }
            else
            {
                MessageBox.Show("WRONG!!!");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //проверка на пустоту в ячейках матриц
            if (a_11.Text != "" && a_12.Text != "" && a_13.Text != "" && a_21.Text != "" && a_22.Text != "" && a_23.Text != "" &&
                a_31.Text != "" && a_32.Text != "" && a_33.Text != "" &&
                b_11.Text != "" && b_12.Text != "" && b_13.Text != "" && b_21.Text != "" && b_22.Text != "" && b_23.Text != "" &&
                b_31.Text != "" && b_32.Text != "" && b_33.Text != "")
            {
                // считываю все значения в матрицах
                int a11 = int.Parse(a_11.Text);
                int a12 = int.Parse(a_12.Text);
                int a13 = int.Parse(a_13.Text);
                int a21 = int.Parse(a_21.Text);
                int a22 = int.Parse(a_22.Text);
                int a23 = int.Parse(a_23.Text);
                int a31 = int.Parse(a_31.Text);
                int a32 = int.Parse(a_32.Text);
                int a33 = int.Parse(a_33.Text);

                int b11 = int.Parse(b_11.Text);
                int b12 = int.Parse(b_12.Text);
                int b13 = int.Parse(b_13.Text);
                int b21 = int.Parse(b_21.Text);
                int b22 = int.Parse(b_22.Text);
                int b23 = int.Parse(b_23.Text);
                int b31 = int.Parse(b_31.Text);
                int b32 = int.Parse(b_32.Text);
                int b33 = int.Parse(b_33.Text);

                int c11 = a11 * b11 + a12 * b21 + a13 * b31;
                int c21 = a21 * b11 + a22 * b21 + a23 * b31;
                int c31 = a31 * b11 + a32 * b21 + a33 * b31;

                int c12 = a11 * b12 + a12 * b22 + a13 * b32;
                int c22 = a21 * b12 + a22 * b22 + a23 * b32;
                int c32 = a31 * b12 + a32 * b22 + a33 * b32;

                int c13 = a11 * b13 + a12 * b23 + a13 * b33;
                int c23 = a21 * b13 + a22 * b23 + a23 * b33;
                int c33 = a31 * b13 + a32 * b23 + a33 * b33;

                int[,] MasC = {
                    {c11, c12, c13},
                    {c21, c22, c23},
                    {c31, c32, c33}

                };

                c_11.Text = c11.ToString();
                c_12.Text = c12.ToString();
                c_13.Text = c13.ToString();
                c_21.Text = c21.ToString();
                c_22.Text = c22.ToString();
                c_23.Text = c23.ToString();
                c_31.Text = c31.ToString();
                c_32.Text = c32.ToString();
                c_33.Text = c33.ToString();

                /*int height = MasC.GetLength(0);
                int width = MasC.GetLength(1);

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write(MasC[i, j] + "\t");
                    }

                    Console.WriteLine();

                }*/
            }
            else
            {
                MessageBox.Show("WRONG");
            }
        }

       private void close_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void off_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Rec_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
       // public bool flag;
        private void window_matrica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D0 || e.Key == Key.D1 || e.Key == Key.D2 || e.Key == Key.D3 || e.Key == Key.D4 || 
                e.Key == Key.D5 || e.Key == Key.D6 || e.Key == Key.D7 || e.Key == Key.D8 || e.Key == Key.D9 || 
                e.Key == Key.OemMinus || e.Key == Key.OemComma || e.Key == Key.Tab || e.Key == Key.LeftShift || e.Key == Key.RightShift)
            {
             //   flag = false;

            }
            else
            {
               // flag = true;
                
                MessageBox.Show("DELETE THE LETTER OR SYMBOL. IF YOU WILL NOT DELETE THIS, PROGRAMM WILL BE CRASHED.");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            tb2.Text = "";
            tb3.Text = "";
            c_11.Text = "";
            c_12.Text = "";
            c_13.Text = "";
            c_21.Text = "";
            c_22.Text = "";
            c_23.Text = "";
            c_31.Text = "";
            c_32.Text = "";
            c_33.Text = "";
        }
    }
}
