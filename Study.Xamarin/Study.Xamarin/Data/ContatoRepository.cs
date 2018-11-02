using System;
using System.Collections.Generic;
using System.Text;
using Study.Xamarin.Entities;

namespace Study.Xamarin.Data
{
    public class ContatoRepository : IContatoRepository
    {
        public void AdicionaContato(Contato contato)
        {
            App.BD.Insert(contato);
        }

        public List<Contato> ListaContatos()
        {
            var dadosTabela = App.BD.Table<Contato>();

            return (from contato in dadosTabela
                                   orderby contato.Nome
                                   select contato).ToList();
        }

        public void RemoveContato(Contato contato)
        {
            App.BD.Delete(contato);
        }
    }
}
