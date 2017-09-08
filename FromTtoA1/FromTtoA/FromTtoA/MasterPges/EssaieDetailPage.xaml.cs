using FromTtoA.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FromTtoA.MasterPges
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EssaieDetailPage : ContentPage
    {
        public EssaieDetailPage()
        {
            InitializeComponent();
            Title = "Dtails";
        }
        async void PaClicked(object sender , ElementEventArgs e)
        {
            await Navigation.PushAsync(new PatientFirstpge());
        }

        async void DoClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new DocLogin());
        }
    }
}