using System.Collections.Generic;

namespace PotapanjeBrodova
{
    public class PoljeSmjer
    {
        public PoljeSmjer(Smjer smjer, Polje polje)
        {
            Smjer = smjer;
            Polje = polje;
        }
        public readonly Polje Polje;
        public readonly Smjer Smjer;
    }

    public interface IOdabirPočetnogPoljaZaBrod
    {
        PoljeSmjer IzaberiPočetnoPolje(IEnumerable<Polje> slobodnaPolja, int duljinaBroda);
    }
}
