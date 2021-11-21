﻿using PM2E12513.Controller;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TomaFotografica
{
    public partial class App : Application
    {

        static BaseSQLite basedatos;

        public static BaseSQLite Basedatos02
        {
            get
            {

                if (basedatos == null)
                {
                    basedatos = new BaseSQLite(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TomarFotografica.db3"));
                }

                return basedatos;

            }


        }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
