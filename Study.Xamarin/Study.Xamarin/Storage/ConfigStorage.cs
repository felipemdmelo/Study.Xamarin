using System;
using Xamarin.Forms;

namespace Study.Xamarin.Storage
{
    public class ConfigStorage
    {

        private static readonly string ExibirNomeESobrenomeConfigTag = "ExibirNomeESobrenome";

        public static void SalvaExibirNomeESobrenomeConfig(bool exibirNomeESobrenome)
        {
            if (Application.Current.Properties.ContainsKey(ExibirNomeESobrenomeConfigTag))
                Application.Current.Properties[ExibirNomeESobrenomeConfigTag] = exibirNomeESobrenome;
            else
                Application.Current.Properties.Add(ExibirNomeESobrenomeConfigTag, exibirNomeESobrenome);
        }

        public static bool RecuperaExibirNomeESobrenomeConfig()
        {
            var rtn = false;
            if (Application.Current.Properties.ContainsKey(ExibirNomeESobrenomeConfigTag))
                Boolean.TryParse(Application.Current.Properties[ExibirNomeESobrenomeConfigTag].ToString(), out rtn);

            return rtn;
        }

        private static readonly string ExibirDDDConfigTag = "ExibirDDD";

        public static void SalvaExibirDDDConfig(bool exibirDDD)
        {
            if (Application.Current.Properties.ContainsKey(ExibirDDDConfigTag))
                Application.Current.Properties[ExibirDDDConfigTag] = exibirDDD;
            else
                Application.Current.Properties.Add(ExibirDDDConfigTag, exibirDDD);
        }

        public static bool RecuperaExibirDDDConfig()
        {
            var rtn = false;
            if (Application.Current.Properties.ContainsKey(ExibirDDDConfigTag))
                Boolean.TryParse(Application.Current.Properties[ExibirDDDConfigTag].ToString(), out rtn);

            return rtn;
        }
    }

}
