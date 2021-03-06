﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreditsPage : ContentPage
    {
        public CreditsPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var termsModal = new ModalTermsPage();

            await Navigation.PushModalAsync(termsModal);
        }
    }
}