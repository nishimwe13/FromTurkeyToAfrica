using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FromTtoA.ListViewsPges
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DepartmentsListView1 : ContentPage
    {
        public DepartmentsListView1()
        {
            InitializeComponent();
            DepListView.ItemsSource = new List<string>
            {
                "Internal Medicine","Pediatric","Gynecology","Cardiology","Pulmonology"
            };
        }
    }
}