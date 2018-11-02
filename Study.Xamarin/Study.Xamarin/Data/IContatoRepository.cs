using Study.Xamarin.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Study.Xamarin.Data
{
    public interface IContatoRepository
    {
        void AdicionaContato(Contato contato);
        void RemoveContato(Contato contato);
        List<Contato> ListaContatos();
    }
}
