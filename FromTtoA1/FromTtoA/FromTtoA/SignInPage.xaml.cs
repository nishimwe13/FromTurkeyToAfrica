using FromTtoA.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FromTtoA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();
        }
        
        async void Button_Clicked(object sender, EventArgs e)
        { 

            await Navigation.PushAsync(new DctorPatientCl1());
        }
        async void SignUpEvnt(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }
        async void OnRootPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}