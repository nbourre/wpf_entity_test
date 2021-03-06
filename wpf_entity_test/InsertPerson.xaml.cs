﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace wpf_entity_test
{
    /// <summary>
    /// Interaction logic for InsertPerson.xaml
    /// </summary>
    public partial class InsertPerson : Window, INotifyPropertyChanged
    {
        PhoneBookContext _db = new PhoneBookContext();
        private Person currentPerson;

        public Person CurrentPerson { 
            get => currentPerson;
            set { 
                currentPerson = value;
                OnPropertyChanged();
            }
        }

        public InsertPerson()
        {
            InitializeComponent();
            CurrentPerson = new Person();
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            _db.People.Add(CurrentPerson);
            _db.SaveChanges();

            this.DialogResult = true;
            this.Hide();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
