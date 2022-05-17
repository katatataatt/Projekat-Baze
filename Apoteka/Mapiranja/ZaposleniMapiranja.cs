using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Apoteka.Entiteti;

namespace Apoteka.Mapiranja
{
    class ZaposleniMapiranja : ClassMap<Zaposleni>
    {
        public ZaposleniMapiranja()
        {
            //Mapiranje tabele
            Table("ZAPOSLENI");

            //mapiranje primarnog kljuca
            Id(x => x.MaticniBroj, "MATICNI_BROJ").GeneratedBy.Assigned();

            //mapiranje svojstava
            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.BrojTelefona, "BROJ_TELEFONA");
            Map(x => x.DatumRodjenja, "DATUM_RODJENJA");


            HasMany(x => x.Recepti).KeyColumn("MATICNI_BROJ_ZAPOSLENOG").LazyLoad().Cascade.All().Inverse();

        }
    }
}
