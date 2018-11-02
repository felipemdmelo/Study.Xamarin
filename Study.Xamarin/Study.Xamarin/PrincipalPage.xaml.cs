using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Study.Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrincipalPage : MasterDetailPage
    {
        public PrincipalPage()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as PrincipalPageMenuItem;
            if (item == null)
                return;

            switch(item.Id)
            {
                case 1:
                    Detail = new NavigationPage(new ConfigPage());

                    break;
                default:
                    var page = (Page)Activator.CreateInstance(item.TargetType);
                    page.Title = item.Title;
                    Detail = new NavigationPage(page);

                    break;
            }
            
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}