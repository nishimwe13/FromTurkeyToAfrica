using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FromTtoA.MasterPges
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PatientFirstpge : ContentPage
	{
		public PatientFirstpge ()
		{
			InitializeComponent ();
		}

    
    private void pickerOnChanged(object sender, EventArgs e)
    {
        Picker pckr = (Picker)sender;
        string selected = pckr.Items[pckr.SelectedIndex];

        DisplayAlert("Picker", selected, "Ok", "Cancel");
    }
}
}