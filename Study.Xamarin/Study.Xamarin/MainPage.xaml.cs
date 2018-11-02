using Study.Xamarin.Data;
using Study.Xamarin.Entities;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Study.Xamarin
{
    public partial class MainPage : ContentPage
    {
        private readonly IContatoRepository _contatoRepository;

        public MainPage()
        {
            InitializeComponent();

            _contatoRepository = new ContatoRepository();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CarregaContatos();
        }

        public void CarregaContatos()
        {
            listaContato.ItemsSource = _contatoRepository.ListaContatos();
        }

        private async Task ListaContato_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contatoSelecionado = e.SelectedItem as Contato;
            var resposta = await DisplayAlert("Remover?", $"Tem certeza que deseja remover {contatoSelecionado.Nome}", "Sim", "Não");
            if(resposta)
            {
                _contatoRepository.RemoveContato(contatoSelecionado);
                CarregaContatos();
            }
        }

        private async Task AdicionarContatoBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdicionarContatoPage());
        }
    }
}
