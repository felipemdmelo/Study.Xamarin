using Study.Xamarin.Storage;

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
            exibirNomeESobrenomeSwt.IsToggled = ConfigStorage.RecuperaExibirNomeESobrenomeConfig();
            exibirDDDSwt.IsToggled = ConfigStorage.RecuperaExibirDDDConfig();
        }

        private void ExibirNomeESobrenomeSwt_Toggled(object sender, ToggledEventArgs e)
        {
            var exibirNomeESobrenome = exibirNomeESobrenomeSwt.IsToggled;

            ConfigStorage.SalvaExibirNomeESobrenomeConfig(exibirNomeESobrenome);
        }

        private void ExibirDDDSwt_Toggled(object sender, ToggledEventArgs e)
        {
            var exibirDDD = exibirDDDSwt.IsToggled;

            ConfigStorage.SalvaExibirDDDConfig(exibirDDD);
        }
    }
}