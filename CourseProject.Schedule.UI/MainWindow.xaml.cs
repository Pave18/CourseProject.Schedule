using CourseProject.Schedule.BAL;
using CourseProject.Schedule.BAL.Interfaces;
using System.Windows;
using System.Windows.Controls;

namespace CourseProject.Schedule.UI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IBaseService service;

        public MainWindow()
        {
            InitializeComponent();

            service = new ScheduleBAL();

            foreach (var item in service.GetGroups())
            {
                comboBoxGroups.Items.Add(item.ToString());
            }
        }


        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var schedules = service.GetSchedules(comboBoxGroups.SelectedItem.ToString());

            dataGridSchedule.ItemsSource = schedules;
        }
    }
}
