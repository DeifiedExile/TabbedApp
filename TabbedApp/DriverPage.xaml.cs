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
    public partial class DriverPage : ContentPage
    {
        public DriverPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            int age = Convert.ToInt16(ageEntry.Text);
            if (age >= 16)
            {
                outputLabel.Text = "You have been able to drive for up to " + (age - 16).ToString() + " years.";

            }
            else
            {
                outputLabel.Text = "You cant drive yet.";
            }

        }
    }
}