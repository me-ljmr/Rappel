using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Data;
namespace RemindKitty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ReminderList rlist;
        TaskList tlist;
        public MainWindow()
        {
            
            InitializeComponent();
            rlist = new ReminderList();
            lstReminders.DataContext = rlist;
            
        }

        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
          
        }

        private void lstReminders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //long selremid = long.Parse(lblSelectedReminder.Tag.ToString());
            tlist = new TaskList(1);
            lstTasks.DataContext = tlist;

        }



        private void btnAction_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
                

            
        }

        private void btnAction_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("gotcha");
        }
    }
    
}
