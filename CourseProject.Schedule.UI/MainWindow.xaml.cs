using CourseProject.Schedule.BAL;
using CourseProject.Schedule.BAL.Interfaces;
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

namespace CourseProject.Schedule.UI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //ScheduleBAL BS = new ScheduleBAL();
            //foreach (var item in BS.Get())
            //{
            //    comboBoxGroups.Items.Add("");
            //}
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }


        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
