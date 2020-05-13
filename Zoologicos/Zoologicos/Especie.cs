using System.Collections.Generic;

namespace Zoologicos
{
    public class Especie
    {
        public string NombreVulgar { get; set; }
        public string NombreCientifico { get; set; }
        public int Cantidad { get; set; }
        public string Clase { get; set; }
        public bool Extincion { get; set; }
        public List<Zoologico> zoologicos { get; set; }
    }
}
