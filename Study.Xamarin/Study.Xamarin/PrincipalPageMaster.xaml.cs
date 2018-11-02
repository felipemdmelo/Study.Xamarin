using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Study.Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrincipalPageMaster : ContentPage
    {
        public ListView ListView;

        public PrincipalPageMaster()
        {
            InitializeComponent();

            BindingContext = new PrincipalPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class PrincipalPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<PrincipalPageMenuItem> MenuItems { get; set; }
            
            public PrincipalPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<PrincipalPageMenuItem>(new[]
                {
                    new PrincipalPageMenuItem { Id = 0, Title = "Contatos" },
                    new PrincipalPageMenuItem { Id = 1, Title = "Configurações" },
                    new PrincipalPageMenuItem { Id = 2, Title = "Sobre" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}