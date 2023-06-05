using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }

        public int TöötajaNumber { get; set; }
        public Isik Isik { get; set; }
        public string LepinguNumber { get; set; }
        public DateTime TöösuhteAlgus { get; set; }
        public bool TöösuheKehtiv { get; set; }
        public DateTime? TöösuhteLõpp { get; set; }
        public int TööTelefon { get; set; }
        public string TööEmail { get; set; }
        public string Kontonumber { get; set; }
        public int TulumaksuvabaSumma { get; set; }


        /// ESIMENE HINDELINE HARJUTUS
        /// Nõuded ja tegevus:
        /// 1. Kui tahate, siis võite forkida minu projekti GitHubist ja läbi Sourcetree enda arvutisse tõmmata.
        /// 2. See teeb teil teise hindelise ülesande tegemise lihtsamaks kuna siis on ainult vaja commitida ja pushida.
        /// 3. Teha Code First ja Database First Migration.
        /// 4. Teha word dokumendile töökäik koos piltidega ja detailne. Mitte, et vajuta seda ja mine sinna ning siis on valmis. 
        /// St, et kui mina hakkan teie õpetust jäljendama, siis ma saan selle tehtud.
        /// 5. Kindlasti tahan näha MS SQL DB-st pilti enne migrationit ja peale seda.
        /// 6. Enne Database first migrationi tegemist tuleb ära kustutada Employee.cs ja TARge20DbContext.cs​ . Seda juhul, kui kasutad minu projektipõhja.
        /// 7. Code first puhul peab tekkima Serverisse sinu loodud objekt(id), serverisse __EFMigrationsHistory objekt ja  Migrations kaust projekti.
        /// 8. Database first puhul tekib projekti Models-i alla Serveris loodud objekt(id).


        /// TEINE HINDELINE HARJUTUS
        ///
        /// 1. Teha Teie meeskonna poolt esitletud FirmaDB-st objektide struktuur.
        /// 2. Kui see on valmis, siis teha code first migration. Vajadusel võib mitu migrationit teha.
        /// 3. NB! Kasutate enda meeskonna poolt esitatud FirmaDB ERD-d, aga igaüks teeb individuaalselt.
        /// 4. Järgida hea programmeerimise tava.
        /// 5. Kogu solution laadida GitHubi ja link valmis tööst saata mulle.
        /// 6. Järgmisena teha print screen MS SQL-s database diagrams all olevast auto-genereeritud ERD-st pilt. See lisada readMe.md failina sama projekti alla GitHubis.

        /// Mõned muutujad võivad olla ka NULL väärtusega ja need tuleb ära märkida

        /// kui peate tõmbama mingeid packagesi alla, siis kasutage eelistatult microsofti omasid ning latest stabel versiooni

        /// <summary>
        /// Kui kasutate enumit, siis peate olema kindel, et on tegemist valikutega, mis jäävad kogu rakenduse eluajaks samaks.
        /// </summary>
        //public Gender Gender { get; set; }

        /// <summary>
        /// 
        /// Siin on info ja analüüs, et mis varianti kasutada
        /// https://stackoverflow.com/questions/10113244/why-use-icollection-and-not-ienumerable-or-listt-on-many-many-one-many-relatio/10113331
        /// https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable?redirectedfrom=MSDN&view=net-5.0
        /// https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1?redirectedfrom=MSDN&view=net-5.0
        /// https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?redirectedfrom=MSDN&view=net-5.0
        /// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers#:~:text=Object%20initializers%20let%20you%20assign,by%20lines%20of%20assignment%20statements.
        /// </summary>
        /// Kas peaks objekti initsialiseerima või mitte
        //public IEnumerable<Children> Childrens { get; set; } = new List<Children>();
        public ICollection<TöötajaLaps>? Childrens { get; set; }
        public ICollection<TöötajaPalve>? TöötajaPalves { get; set; }
        public ICollection<TöötajaLigipääs> TöötajaLigipääs { get; set; }
        public ICollection<TöötajaAmetinimetus> TöötajaAmetinimetus { get; set; }
        public ICollection<Tööleping> Töölepings { get; set; }
        public ICollection<Tervisekontroll> Tervisekontrolls { get; set; }
        public ICollection<Puhkus> Puhkus { get; set; }
        public ICollection<Palk> Palks { get; set; }
        public ICollection<OsakonnaTöötaja> OsakonnaTöötajas { get; set; }
        public ICollection<Osakonnajuht> Osakonnajuhts { get; set; }
        public ICollection<Laenutus> Laenutus { get; set; }
        public ICollection<Koolitus> Koolitus { get; set; }
        public ICollection<Haigusleht> Haiguslehts { get; set; }
        //public List<Children> Childrens { get; set; }
    }


    //public enum Gender
    //{
    //    Female, 
    //    Male,
    //    Unknown
    //}

    //public class Children
    //{
    //    [Key]
    //    public Guid Id { get; set; }

    //    public string FirstName { get; set; }
    //}
}

