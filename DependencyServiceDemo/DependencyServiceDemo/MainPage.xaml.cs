﻿using DependencyServiceDemo.DependencyServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace DependencyServiceDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var service = DependencyService.Get<IPlatformMessage>();
            var message = service.GetMessage();
            await DisplayAlert("Service", message, "OK");
        }

        private void TextToSpeech_OnClicked(object sender, EventArgs e)
        {
            var service = DependencyService.Get<ITextToSpeech>();

            service.Speak(texto.Text);
        }


    }
}
