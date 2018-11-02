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
	public partial class ConfigPage : ContentPage
	{
        public ConfigPage ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CarregarConfig();
        }

        private void CarregarConfig()
        {
            exibirNomeESobrenomeSwt.IsToggled = RecuperaExibirNomeESobrenomeConfig();
        }

        private void ExibirNomeESobrenomeSwt_Toggled(object sender, ToggledEventArgs e)
        {
            var exibirNomeESobrenome = exibirNomeESobrenomeSwt.IsToggled;

            SalvaExibirNomeESobrenomeConfig(exibirNomeESobrenome);
        }

        private void SalvaExibirNomeESobrenomeConfig(bool exibirNomeESobrenome)
        {
            if (Application.Current.Properties.ContainsKey("ExibirNomeESobrenome"))
                Application.Current.Properties["ExibirNomeESobrenome"] = exibirNomeESobrenome;
            else
                Application.Current.Properties.Add("ExibirNomeESobrenome", exibirNomeESobrenome);
        }

        private bool RecuperaExibirNomeESobrenomeConfig()
        {
            var rtn = false;
            if (Application.Current.Properties.ContainsKey("ExibirNomeESobrenome"))
                Boolean.TryParse(Application.Current.Properties["ExibirNomeESobrenome"].ToString(), out rtn);

            return rtn;
        }
    }
}