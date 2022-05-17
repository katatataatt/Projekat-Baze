using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Apoteka.Entiteti;

namespace Apoteka.Mapiranja
{
    class ProdajnoMestoMapiranja : ClassMap<ProdajnoMesto>
    {
        public ProdajnoMestoMapiranja()
        {
            //Mapiranje tabele
            Table("PRODAJNO_MESTO");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID_MESTA").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.Mesto, "MESTO");


            HasMany(x => x.Recepti).KeyColumn("ID_PRODAJNOG_MESTA").LazyLoad().Cascade.All().Inverse();

            HasManyToMany(x => x.ProdajeLekove)
                .Table("PRODAJE_SE")
                .ParentKeyColumn("ID_PRODAJNOG_MESTA_1")
                .ChildKeyColumn("ID_LEKA_1")
                .Inverse()
                .Cascade.All();

            HasMany(x => x.ProdajeSeLek).KeyColumn("ID_PRODAJNOG_MESTA_1").LazyLoad().Cascade.All().Inverse();


        }
    }
}
