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

namespace WPF_OOP3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Employee> myEmployeesList = new List<Employee>();
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Employee myEmployee = new Employee(txtFirstName.Text, txtLastName.Text, Convert.ToDouble(txtSalary.Text));
          
            myEmployeesList.Add(myEmployee);
            lbResult.ItemsSource = null;
            lbResult.ItemsSource = myEmployeesList;
        }
    }
}
