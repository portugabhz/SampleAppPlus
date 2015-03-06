﻿using System.Windows;

namespace SampleAppPlus
{
    /// <summary>
    /// Interaction logic for AddText.xaml
    /// </summary>
    public partial class EditText : Window
    {
        public EditText()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
