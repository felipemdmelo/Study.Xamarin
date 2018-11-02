using SQLite;
using Study.Xamarin.Storage;

namespace Study.Xamarin.Entities
{
    [Table("Contato")]
    public class Contato
    {
        [Column("id"), PrimaryKey(), AutoIncrement()]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("sobrenome")]
        public string Sobrenome { get; set; }

        [Column("ddd")]
        public string DDD { get; set; }

        [Column("telefone")]
        public string Telefone { get; set; }

        #region PROPRIEDADES IGNORADAS..
        [Ignore]
        public string Identificacao
        {
            get
            {
                var exibirNomeESobrenomeConfig = ConfigStorage.RecuperaExibirNomeESobrenomeConfig();
                if(exibirNomeESobrenomeConfig)
                    return $"{Nome} {Sobrenome}";

                return $"{Nome}";
            }
        }

        [Ignore]
        public string ContatoTelefone
        {
            get
            {
                var exibirDDDConfig = ConfigStorage.RecuperaExibirDDDConfig();
                if (exibirDDDConfig)
                    return $"{DDD} {Telefone}";

                return $"{Telefone}";
            }
        }
        #endregion
    }
}
