using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Prestataire
    {   public enum Zone
        {
            Raoued,arienaVille,Lasoukra
        }
        [Range(0, 5)]
        public int Note { get; set; }
        public string PageInstagramme { get; set; }
        public int PrestataireId { get; set; }
        public string PrestataireNom { get; set; }
        public string PrestataireTel { get; set; }

        public virtual IList<Prestation> Prestation { get; set; }
    }
}
