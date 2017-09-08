using FromTtoA.MasterPges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FromTtoA.Views
{
    public class DctorPatientCl1: MasterDetailPage
    {
        public DctorPatientCl1()
        {
            Master = new MyMenu();
            Detail = new NavigationPage(new EssaieDetailPage());

        }
    }
}
