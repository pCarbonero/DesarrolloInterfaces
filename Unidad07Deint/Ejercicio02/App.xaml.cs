﻿using Ejercicio02.Views;

namespace Ejercicio02
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Pagina1());
        }
    }
}
