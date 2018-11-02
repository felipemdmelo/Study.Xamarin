using Study.Xamarin.Data;
using Study.Xamarin.Entities;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Study.Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AdicionarContatoPage : ContentPage
	{
        private readonly IContatoRepository _contatoRepository;

        public AdicionarContatoPage ()
		{
			InitializeComponent ();

            _contatoRepository = new ContatoRepository();
        }

        private async Task CadastrarContato_Clicked(object sender, EventArgs e)
        {
            var contato = new Contato
            {
                Nome = txtNome.Text,
                Sobrenome = txtSobrenome.Text,
                DDD = txtDDD.Text,
                Telefone = txtTelefone.Text
            };

            _contatoRepository.AdicionaContato(contato);

            await Navigation.PopAsync();
        }
    }
}