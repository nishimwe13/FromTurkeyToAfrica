using FromTtoA.ListViewsPges;
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
    public partial class MyMenu : ContentPage
    {
        public MyMenu()
        {
            InitializeComponent();
        }

        async void DeprtmntsView(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DepartmentsListView1());
        }
        async void DctorsView(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DocListView2());
        }
    }
}