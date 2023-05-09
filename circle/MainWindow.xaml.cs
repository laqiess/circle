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

namespace Circle
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CircleClass t1;//является полем класса MainWindow 
        public MainWindow()
        {
            InitializeComponent();
            t1 = new CircleClass();//указатель на объект
        }

        public void set_argument()
        {
            // проверка на исключительные ситуации
            try
            {
                //проверка окошка куда вводим данные
                t1.setradius(double.Parse(TextBox_radius.Text));
            }
            catch (ArgumentException er)
            {
                //выводит ошибку ,есливведены некоректные данные
                Label_error.Content = er.Message;
            }
        }

        //получаем данные в результате вычислений
        public void set_answer()
        {
            try
            {

                TextBox_1.Text = t1.get_area().ToString("0.00");//выводит значения с ограниечением в 2 знака после запятой
                TextBox_2.Text =  t1.get_circum().ToString("0.00");//выводит значения с ограниечением в 2 знака после запятой
                TextBox_3.Text = Convert.ToString(t1.get_diameter());
            }
            catch (ArgumentException er)
            {
                //выводит ошибку ,есливведены некоректные данные
                Label_error.Content = er.Message;
            }
        }
             
        //действие программы при нажатии на кнопку запуск
            private void Button_Click(object sender, RoutedEventArgs e)
        {
            set_argument();//запускает функцию
            set_answer();//запускает функцию
            labal.Content = t1.ToString();//ввыводит данные на экран в лейболе
        }

    }
}
