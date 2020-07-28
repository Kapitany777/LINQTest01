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

namespace LINQTest01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Person> persons;

        public MainWindow()
        {
            InitializeComponent();

            persons = Person.GetSampleData();
        }

        private void ButtonAll_Click(object sender, RoutedEventArgs e)
        {
            var result =
                from person in persons
                orderby person.FirstName,
                        person.LastName
                select person;

            GridResult.ItemsSource = result;
        }

        private void ButtonFilterFirstName_Click(object sender, RoutedEventArgs e)
        {
            var result =
                from person in persons
                where person.FirstName.ToUpper().Contains(TextBoxFirstName.Text.ToUpper())
                orderby person.FirstName,
                        person.LastName
                select person;

            GridResult.ItemsSource = result;
        }

        private void ButtonFilterLastName_Click(object sender, RoutedEventArgs e)
        {
            var result =
                persons
                .Where(person => person.LastName.ToUpper().Contains(TextBoxLastName.Text.ToUpper()))
                .OrderBy(person => person.FirstName)
                .ThenBy(person => person.LastName);

            GridResult.ItemsSource = result;
        }

        private void ButtonFilter_Click(object sender, RoutedEventArgs e)
        {
            var result =
                from person in persons
                where person.FirstName.ToUpper().Contains(TextBoxFirstName.Text.ToUpper())
                   && person.LastName.ToUpper().Contains(TextBoxLastName.Text.ToUpper())
                orderby person.FirstName,
                        person.LastName
                select person;

            GridResult.ItemsSource = result;
        }
    }
}
