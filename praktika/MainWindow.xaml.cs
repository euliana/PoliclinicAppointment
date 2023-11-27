using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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

namespace praktika
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        internal class Class1
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public Class1(int id, string Name, string Description)
            {
                this.Id = id;
                this.Name = Name;
                this.Description = Description;

            }
        }

        public MainWindow()
            {
                List<Class1> ser = new List<Class1>();

                InitializeComponent();
                lv_Service.ItemsSource = ser;
                ser.Add(new Class1(1, "МРТ", "Это полезно"));
                ser.Add(new Class1(2, "Пункция", "Это полезно"));
                ser.Add(new Class1(3, "Консультация", "Это полезно"));
            }

        private void btn_Order_Click(object sender, RoutedEventArgs e)
        {
            var i = lv_Service.SelectedItem;
            if (i != null)
            {
                MessageBox.Show("Вы записаны на услугу!");
            }
        }
    }
    }

