﻿using System;
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

namespace ArgunovaAngelikaKod1._4
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
       
        public AddEditPage()
        {
            InitializeComponent();
            ComboMaterial.ItemsSource = Entities.GetContext().Material.ToList();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}