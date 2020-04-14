using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalTermsPage : ContentPage
    {
        public ModalTermsPage()
        {
            InitializeComponent();
        }

        private async void OnClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        
    }
}