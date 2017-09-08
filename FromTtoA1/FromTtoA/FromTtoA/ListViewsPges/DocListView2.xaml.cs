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
    public partial class DocListView2 : ContentPage
    {
        public DocListView2()
        {
            InitializeComponent();
            DocListView.ItemsSource = new List<DocAndDepartment>
            {
                new DocAndDepartment
                {
                    Docname = "Dr. Ibrahim Kivanc",
                    DocDepartment= "Internal Medicine"
                },
                new DocAndDepartment
                {
                    Docname = "Dr. Behice Funda",
                    DocDepartment= "Gynecology"
                },
                new DocAndDepartment
                {
                    Docname = "Dr. Hasret Soysal",
                    DocDepartment= "Pediatric"
                },
                new DocAndDepartment
                {
                    Docname = "Dr. Leila Nishimwe",
                    DocDepartment= "Cardiology"
                },
                new DocAndDepartment
                {
                    Docname = "Dr. Gildas Djecadjevi",
                    DocDepartment= "Pulmonology"
                },
            };
        }
    }
}