using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FromTtoA.Models
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DocLogin : ContentPage
    {
        public DocLogin()
        {
            InitializeComponent();
        }
        
        async void Buttn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DocDeprt());
        }
        
    }
}