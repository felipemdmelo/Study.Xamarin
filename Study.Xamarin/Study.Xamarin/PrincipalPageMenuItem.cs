using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Xamarin
{

    public class PrincipalPageMenuItem
    {
        public PrincipalPageMenuItem()
        {
            TargetType = typeof(PrincipalPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}