using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Model
{
    public class Song
    {
        private int idChanson;
        private String titreMorceau;
        private String nomArtiste;
        private String categorieChanson;

        public int IdChanson { get => idChanson; set => idChanson = value; }
        public string TitreMorceau { get => titreMorceau; set => titreMorceau = value; }
        public string NomArtiste { get => nomArtiste; set => nomArtiste = value; }
        public string CategorieChanson { get => categorieChanson; set => categorieChanson = value; }
    }
}
