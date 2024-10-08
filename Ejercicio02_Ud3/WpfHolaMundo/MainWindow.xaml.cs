﻿using ClasesSharp;
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

namespace WpfHolaMundo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento asociado al botón saludar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClsPersona pers = new ClsPersona();

            String nombre = txtNombre.Text;

            if (nombre != null && !nombre.Equals(""))
            {      
                pers.Nombre = nombre;
                MessageBox.Show("Hola " + pers.Nombre);
                lbError.Visibility = Visibility.Hidden;
            }
            else
            {
                lbError.Visibility = Visibility.Visible;
            }
        }
    }
}