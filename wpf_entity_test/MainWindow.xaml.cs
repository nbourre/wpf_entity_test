using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

namespace wpf_entity_test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        PhoneBookContext _db = new PhoneBookContext();
        private ObservableCollection<Person> people;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Person> People 
        { 
            get => people;
            set
            {
                people = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        public MainWindow()
        {
            InitializeComponent();
            InitValues();
        }

        private void InitValues()
        {
            People = new ObservableCollection<Person>(_db.People.ToList());
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            InsertPerson insertPerson = new InsertPerson();
            var result = insertPerson.ShowDialog();

            if (result == true)
                People.Add(_db.People.ToList().Last());
        }


        protected override void OnDeactivated(EventArgs e)
        {

            base.OnDeactivated(e);
        }
    }
}
