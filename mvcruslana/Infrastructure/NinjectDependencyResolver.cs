using System; 
using System.Collections.Generic; 
using System.Linq;
using System.Web.Mvc;
using Moq; 
using Ninject;
using MvcRuslana.Abstract;
using MvcRuslana.Entities;

namespace MvcRuslana.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {

            Mock<IBlogRepository> mock = new Mock<IBlogRepository>();
            mock.Setup(m => m.BlogItems).Returns(new List<BlogItem> 
            {     

                new BlogItem
                { 
                    Id = 50, 
                    BlogCreated = new DateTime(2015,05,25), 
                    BlogHeader = @"I HOPP OM EN LJUSARE FRAMTID 10 maj", 
                    BlogText =  @"Kära medlemmar!
                        Tack så hjärtligt till alla som deltog och var närvarande den 10 maj på konsert "" I HOPP OM EN LJUSARE FRAMTID"" där pianisten Elena Glagoleva och operasångerskan Irina Moshkova- Paulsen och flöjtist Anastasija Bila och barnen Daria och Ludmila framförde fantastiska låtar." + Environment.NewLine +
                        @"Alltid ett nöje att se så många bekanta ansikten." + Environment.NewLine +
                        @"Vi ses snart igen!" + Environment.NewLine +
                        @"Med vänlig hälsning." + Environment.NewLine +
                        @"Tetyana Rep - ordförande",
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/DSC02801.JPG" },
                        new BlogPhoto { FileName = "blogg/DSC02823.JPG" },
                        new BlogPhoto { FileName = "blogg/DSC02826.JPG" },
                        new BlogPhoto { FileName = "blogg/DSC02832.JPG" },
                    }
                },   
                new BlogItem
                { 
                    Id = 49, 
                    BlogCreated = new DateTime(2015,03,09), 
                    BlogHeader = @"Tack för den 8 mars", 
                    BlogText =  @"Hej Kära vänner!" + Environment.NewLine + 
                        @"Jag vill så hjärtligt tacka alla som kom och deltog vid Kvinnokonferensen" + Environment.NewLine + 
                        @"""Likvärdighet bör alltid existera"" den 8 mars på Askims Montessoriskola." + Environment.NewLine + 
                        @"Ett särskilt tack till våra gäster Vladimir Reznik (Han har mångårig erfarenhet som jurist) och Didar Zuta ordförande i Centerkvinnorna i Göteborg, ni gjorde den här dagen unik. Tack till Tatiana Miralm för all" + Environment.NewLine + 
                        @"nyttig information om Folksam och dess fina hjälpmedel. Tack för Petre Cataneanu  är illusionisten som alltid skapar magi på alla våra evenemang." + Environment.NewLine + 
                        @"Ännu ett tack till var och en av er som kom, hoppas ni hade en trevlig dag, ta hand om varandra," + Environment.NewLine + 
                        @" speciellt om era käraste kvinnor och vi ser framemot att se er alla nästa år igen." + Environment.NewLine + 
                        @"Med vänlig hälsning." + Environment.NewLine + 
                        @"Tetyana Rep - ordförande ",
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/DSC02727.JPG" },
                        new BlogPhoto { FileName = "blogg/DSC02728.JPG" },
                        new BlogPhoto { FileName = "blogg/DSC02737.JPG" },
                        new BlogPhoto { FileName = "blogg/DSC02744.JPG" },
                    }
                },   
                new BlogItem
                { 
                    Id = 48, 
                    BlogCreated = new DateTime(2014,10,26), 
                    BlogHeader = @"Temautbildning SIOS", 
                    BlogText =  @"Hej!" + Environment.NewLine + 
                        @"Den 26 oktober fick Ukrainska Alliansen i Sverige i samarbete med Ukrainskt - Svenskt KF," + Environment.NewLine + 
                        @"Ukrainska Skola ""Romashka"", IFFI från Blekinge och Flärspråkliga" + Environment.NewLine + 
                        @"barn och föräldrar"" att ta del av en mycket intressant samt aktuell föreläsning. Deltagarna" + Environment.NewLine + 
                        @"fick lära sig mer om SIOS och dess roll. Det var väldigt givande att få veta deras ståndpunkter," + Environment.NewLine + 
                        @"det gav även möjlighet till att diskutera vilket uppskattades stort." + Environment.NewLine + 
                        @"Denna givande temautbildningsdag gav många nya idéer för framtid arbete." + Environment.NewLine + 
                        @"Tack till föreläsarna samt alla som deltog." + Environment.NewLine + 
                        @"Med vänlig hälsning." + Environment.NewLine + 
                        @"Tetyana Rep - ordförande ",
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/DSC02605.JPG" },
                        new BlogPhoto { FileName = "blogg/DSC02598.JPG" },
                        new BlogPhoto { FileName = "blogg/DSC02599.JPG" },
                        new BlogPhoto { FileName = "blogg/DSC02603.JPG" },
                    }
                },   
                new BlogItem
                { 
                    Id = 47, 
                    BlogCreated = new DateTime(2014,10,19), 
                    BlogHeader = @"Höstfest för barn den 19 oktober 2014", 
                    BlogText =  @"" +
                        @"Den ideella föreningen ""Flerspråkiga barn och föräldrar"" (""FBF"") har tillsammans med Ukrainska Alliansen i Sverige,  " + Environment.NewLine + 
                        @"Ukrainsk-Svenska Kulturföreningen organiserat en höstfest för barn den 19 oktober 2014 på Askims Montessoriskola. " + Environment.NewLine + 
                        @"I framtiden kommer denna typer av verksamheter att fortsätta och Ukrainska Alliansen i Sverige kommer fortsätta stödja ""FBF"" med olika typ av hjälp. " + Environment.NewLine + 
                        @"" + Environment.NewLine + 
                        @"Med vänlig hälsning." + Environment.NewLine + 
                        @"" + Environment.NewLine + 
                        @"Styrelsen UAIS" + Environment.NewLine + 
                        @"",
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/141114image1.JPG" },
                        new BlogPhoto { FileName = "blogg/141114image2.JPG" },
                        new BlogPhoto { FileName = "blogg/141114image3.JPG" },
                        new BlogPhoto { FileName = "blogg/141114image4.JPG" },
                        new BlogPhoto { FileName = "blogg/141114image5.JPG" },
                        new BlogPhoto { FileName = "blogg/141114image6.JPG" },
                        new BlogPhoto { FileName = "blogg/141114image7.JPG" },
                        new BlogPhoto { FileName = "blogg/141114image8.JPG" },
                        new BlogPhoto { FileName = "blogg/141114image9.JPG" },
                    }
                },   
                new BlogItem
                { 
                    Id = 46, 
                    BlogCreated = new DateTime(2014,09,09), 
                    BlogHeader = @"Föreläsning Alla Choifer", 
                    BlogText =  @"Hej Kära medlemmar! " + Environment.NewLine + 
                                @"Vi vill tackar hjärtligt vår medlem Alla Choifer för en intressant " + Environment.NewLine + 
                                @"och lärorik föreläsning. Att diskutera ett aktuellt ämne är ytterst " + Environment.NewLine + 
                                @"viktigt. Vi ser fram emot att ha nästa föreläsning om psykologi och " + Environment.NewLine + 
                                @"välmående. " + Environment.NewLine + 
                                @"Med vänlig hälsning. " + Environment.NewLine + 
                                @"Tetyana Rep - ordförande ",
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/DSC02499.JPG" },
                        new BlogPhoto { FileName = "blogg/DSC02504.JPG" },
                    }
                },   
                new BlogItem
                { 
                    Id = 45, 
                    BlogCreated = new DateTime(2014,03,23), 
                    BlogHeader = @"Kultur och Språkfestivalen", 
                    BlogText =  @"Hej kära nmedlemmar och gäster som var " + Environment.NewLine + 
                                @"närvarande vid firandet av 2014 Kultur och" + Environment.NewLine + 
                                @" Språkfestivalen i Artisten." + Environment.NewLine + 
                                @" Det 6-e Kultur- och Språkfestivalen samlade" + Environment.NewLine + 
                                @" olika kulturer och traditioner under ett och samma tak för" + Environment.NewLine + 
                                @" gemensam framtid.  Vi vill säga ett stort tack till de som var med och firade och ett enormt tack till  var barngrupp ""VESELKA"" och Anastasia Bila, som hjälpte till ordna och presentera Ukrainska kultur." + Environment.NewLine + 
                                @" Alla sångare, artister, utan er hade det aldrig gått." + Environment.NewLine + 
                                @" Det var en glädjefull dag." + Environment.NewLine + 
                                @" Med vänlig hälsning." + Environment.NewLine + 
                                @" Tetyana Rep - ordförande", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/140323.png" },
                    }
                },   
                new BlogItem
                { 
                    Id = 44, 
                    BlogCreated = new DateTime(2014,03,15), 
                    BlogHeader = @"Kvinnor vi är starkast tillsammans", 
                    BlogText = @"Hej kära medlemmar!" + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @" I söndags hade vi föreläsning ""Kvinnor vi är starkast tillsammans""," + Environment.NewLine + 
                                @" den här gången blev det mer aktuellt att diskutera igenom situationen i Ukraina ," + Environment.NewLine + 
                                @" då det är en väldigt aktuell fråga." + Environment.NewLine + 
                                @" Vi diskuterade även hur kvinnor ser på detta för att i utsatta situationen är det oftast kvinnor, barn och äldre som råkar mest illa ut. Vi är tacksamma att så många kunde vara med. " + Environment.NewLine + 
                                @" Med vänlig hälsning." + Environment.NewLine + 
                                @" Tetyana Rep - ordförande", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/DSC02349.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC02360.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC02364.jpg" },
                    }
                },   
                new BlogItem
                { 
                    Id = 43, 
                    BlogCreated = new DateTime(2014,02,24), 
                    BlogHeader = @"IV Internationella festivalen ""Hos Carlsson på taket"" Stockholm", 
                    BlogText = @"Hej kära medlemmar!" + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @" IV Internationella festivalen ""Hos Carlsson på taket"";" + Environment.NewLine + 
                                @" Barn - och ungdomstävling fanns på scenen inom projektet ""Salut av Talanger"" som var i Stockholm måndagen den 24/2 2014." + Environment.NewLine + 
                                @" Ukrainska Alliansen i Sverige tillsammans med Ukrainsk - Svenska Kulturföreningen och Svenska Kosacker blev" + Environment.NewLine + 
                                @" representerad av Daria Rep i nominering ""Musikinstrument"",  där musikpedagog är Elena Glagoleva. " + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @" Daria Rep vann 3:dje plats. Stort Grattis och stor applåd för Daria! " + Environment.NewLine + 
                                @" Det har varit en fantastisk festival som samlade barn från olika städer och länder, Ryssland, Tatarstan, Republik  Komi," + Environment.NewLine + 
                                @" och Sverige. De tävlade i koreografi, konstverksutställning, musikinstrument, sång, scenisk kreativitet." + Environment.NewLine + 
                                @" Festivalen avslutades med en underbar Galakonsert och diplomutdelning. Deltagaren i Galakonserten från" + Environment.NewLine + 
                                @" Ukrainska Alliansen i Sverige har varit ""Blommiga Själen"" från Stockholm. Publiken applåderade med stor glädje." + Environment.NewLine + 
                                @" Vi tackar ""Blommiga Själen"" och hoppas på att åter träffas igen." + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @" Med vänlig hälsning." + Environment.NewLine + 
                                @" Tetyana Rep - ordförande", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/DSC04183.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC04260.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC04262.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC04264.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC04266.jpg" },
                    }
                },   
                new BlogItem
                { 
                    Id = 42,
                    BlogCreated = new DateTime(2014,02,02),
                    BlogHeader = @"Återvänd material som Dagens konst",
                    BlogText = @"Hej kära medlemmar! " + Environment.NewLine + 
                                @"" + Environment.NewLine + 
                                @"" + Environment.NewLine + 
                                @"Vi vill så gärna tacka våra fantastiska föreläsa Tanja och Ksenia som höll i en väldigt lärorik föreläsning där vi alla närvarande utan tvekan fick lära oss hel del nytt. Vi fortsatte på ämnet kring jämställdhet på arbetsmarknaden men sedan gick över till ett ännu viktigt ämne som jag tror de flesta av er inte har kunnat att undgå samt inte lägga märke till. Det ämnet som huvudsakligen togs upp idag handlade om Feminism. Det diskuteras livligt ute i samhället, media och på sociala nätverk. Det berör alla individer och med alla menar vi alla medborgare ute i världen. Jämställdhet är det främsta synonymet till feminism och det är det som vi fick lära oss mycket mer om idag. Förutom det fick vi nog alla oss en tankeställare och vidgade våra vyer samt kunskap kring ämnet. Som vi nämnde tidigare, detta är något som berör alla och alla bör ta sig tiden och lära sig ordentligt om ämnet, därför är vi väldigt glada att en sådan föreläsning genomfördes. Tack ännu en gång. Information om nästa möte tillkommer längre fram. " + Environment.NewLine + 
                                @"" + Environment.NewLine + 
                                @"Med vänlig hälsning." + Environment.NewLine + 
                                @"" + Environment.NewLine + 
                                @"Tetyana Rep - ordförande", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/DSC02296.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC02297.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC02303.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC02287.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC02289.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC02292.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC02293.jpg" },                    }
                },
                new BlogItem
                { 
                    Id = 41,
                    BlogCreated = new DateTime(2014,01,27),
                    BlogHeader = @"Tupperware",
                    BlogText = @"Hej!" + Environment.NewLine + 
                                @" Tack Vaida för den intressant föreläsning om ""Tupperware""." + Environment.NewLine + 
                                @" Med vänlig hälsning. " + Environment.NewLine + 
                                @" Tetyana Rep", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/DSC02262.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC02267.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC02279.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC02283.jpg" },
                    }
                },
                new BlogItem
                { 
                    Id = 40,
                    BlogCreated = new DateTime(2013,12,01),
                    BlogHeader = @"Föreläsning, Julbord Askim",
                    BlogText = @"Hej kärra medlemmar!" + Environment.NewLine + 
                                @" Jag vill tacka alla er som tog er tiden och deltog på" + Environment.NewLine + 
                                @" föreläsningen den 1 september. Det var en väldig" + Environment.NewLine + 
                                @" bra föreläsningen. Och tack för barnen som" + Environment.NewLine + 
                                @" sjöng så bra och spelade piano. Alla ville börja dansa med dem." + Environment.NewLine + 
                                @" Vi fick se en riktigt trollkarl! Det var så otroligt med sant!" + Environment.NewLine + 
                                @" Med vänlig hälsning." + Environment.NewLine + 
                                @" Tetyana Rep - ordförande", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/DSC02219.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC02191.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC02198.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC02208.jpg" },
                        
                    }
                },
                new BlogItem
                { 
                    Id = 39,
                    BlogCreated = new DateTime(2013,11,02),
                    BlogHeader = @"Konferens i Stockholm",
                    BlogText = @"Hej kära medlemmar!" + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @" I lördags genomfördes det en konferens i Stockholm, där föreläsaren Rashin Fardnicklasson höll ett föredrag samt att de närvarande fick diskutera, framföra egna åsikter samt utbyta erfarenheter med varandra. Vi vill härmed tacka Rashin för ännu en fantastisk föreläsning. Tack även alla ni som tog er tiden och deltog på er lediga dag, vi välkomnar även våra gäster från Etiopiska föreningen och hoppas att vi syns snart igen. Vi får absolut inte glömma att framföra ett särskilt tack till folksång gruppen ""Blommiga Sjalen"" vars uppträdande var ännu en gång ett fantastiskt avslut på konferensen och bidrog till en underbar stämning." + Environment.NewLine + 
                                @" Ta hand om varandra och håll utkik efter mejlet angående vår sista föreläsning för iår samt julavslutning." + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @" Hälsningar " + Environment.NewLine + 
                                @" Tetyana Rep - ordförande", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/DSC02153.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC02166.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC02170.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC02172.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC02182.jpg" },
                    }
                },
                new BlogItem
                { 
                    Id = 38,
                    BlogCreated = new DateTime(2014,10,10),
                    BlogHeader = @"Kvinnans jämställdhet i världen: del 1(Mellanöstern)",
                    BlogText = @"Hej kära medlemmar!   Vi skulle vilja tacka alla som deltog igår på föreläsningen ""Kvinnans jämställdhet i världen: del 1(Mellanöstern)""  som hölls av Ksenia Staroselets på Askim Montessoriskola. Ett stort tack till Ksenia som utvidgade våra vyer kring kvinnans position i Mellanöstern, det var väldigt intressant och det var ännu intressantare att alla som deltog diskuterade så livligt samt delade med sig av egna erfarenheter kring gårdagens ämne. För er som fick förhinder igår och kunde inte delta vill vi påminna om att igår introducerades även en bok vid namn ""Resa i Sharialand"" skriven av Tina Thunander. Vi rekommenderar starkt till alla att läsa boken då den i första hand är väldigt intressant och lärorik, samtidigt som vi kommer att diskutera boken längre fram vid ett senare tillfälle eller mer specifikt 8 december(mer information om det tillkommer när det börjar närma sig). " + Environment.NewLine + 
                                @"" + Environment.NewLine + 
                                @" Med vänliga hälsningar" + Environment.NewLine + 
                                @" Tetyana Rep - ordförande", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/DSC02126.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC02131.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC02132.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC02134.jpg" },
                    }
                },
                new BlogItem
                { 
                    Id = 37,
                    BlogCreated = new DateTime(2013,09,14),
                    BlogHeader = @"Kvinnokonferensen, Emigranternas Hus",
                    BlogText = @"Hej käramedlemmar!" + Environment.NewLine + 
                                @" Vi vill tacka alla er som tog er tiden och deltog på Kvinnokonferensen 14 september,som hölls på Emigranternas Hus. Det var riktig kul att så många kunde delta och utbyta egna erfarenheter samt fick chansen att lära sig massa nyttig information. Vi vill framföra extra tacksamhet till dem som bidrog till att dagen blev så händelser - samt lärorik. Så tack Mikael Petersson för en sån lärorik presentation om trygghet, den var otroligt lärorik. Tack Rashin för en sån fantastisk föreläsning, du är en sann inspirationskälla. Sist men inte minst tack till våra gäster och medlemmar från Stockholm, Folksångsgruppen ""Blommiga Själen"", otroligt spännande och underhållande. Vi ses nästa gång 6 oktober, mer info kommer skickas ut längre fram." + Environment.NewLine + 
                                @" Med vänlig hälsning" + Environment.NewLine + 
                                @" Tetyana Rep - ordförande", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/Rashin.jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3161%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3162%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3164%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3165%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3167%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3169%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3171%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3172%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3175%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3177%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3178%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3179%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3182%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3183%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3186%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3187%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3189%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3190%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3191%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3192%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3193%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3195%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3196%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3198%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3202%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3203%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3212%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3219%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3221%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3223%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3225%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3226%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3229%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3232%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3236%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3237%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3239%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3245%20[800x600].jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_3247%20[800x600].jpg" },
                   
                    }
                },
                new BlogItem
                { 
                    Id = 36,
                    BlogCreated = new DateTime(2013,08,19),
                    BlogHeader = @"Föreläsningen psykologen Alla Choifer",
                    BlogText = @"Hej kära medlemmar!" + Environment.NewLine + 
                                @" Jag vill börja med att tacka alla som deltog 19/8 på den första officiella" + Environment.NewLine + 
                                @" föreläsningen som hölls av psykologen Alla Choifer. Vilket intressant ämne vi fick lära oss" + Environment.NewLine + 
                                @" om av Alla och det ledde ju till spännande diskussioner i mindre grupper samt gemensamt en större grupp." + Environment.NewLine + 
                                @" Tack Alla, det var ett nöje att få spendera måndagens förmiddag med dej och alla de som deltog." + Environment.NewLine + 
                                @" Vi ses snart igen." + Environment.NewLine + 
                                @" Med vänlig hälsning." + Environment.NewLine + 
                                @" Tetyana Rep - ordförande", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/DSC02050.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC02053.jpg" },
                        
                    }
                },
                new BlogItem
                { 
                    Id = 35,
                    BlogCreated = new DateTime(2013,04,28),
                    BlogHeader = @"Givande föreläsning för kvinnor",
                    BlogText = @"Hej kärra medlemmar och sammarbetspartner!" + Environment.NewLine + 
                                @"Nu har vi haft vår första seminarium den 17 juni, så nu är projektet officiellt igång." + Environment.NewLine + 
                                @"Vi gick igenom tidsplanen, diskuterade alla moment under det kommande" + Environment.NewLine + 
                                @"halvåret. Det var intressant att få veta era tankar kring projekt och vi tog " + Environment.NewLine + 
                                @"till oss era synpunkter. Nu ser vi framemot att få jobba med er och är " + Environment.NewLine + 
                                @"väldigt glada över att ni gav oss så positiv respons." + Environment.NewLine + 
                                @"MVH. Tetyana Rep - ordförande", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/DSC01993.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC02000.jpg" },
                    }
                },
                //new BlogItem
                //{ 
                //    Id = 34,
                //    BlogCreated = new DateTime(2013,06,17),
                //    BlogHeader = @"Seminarium",
                //    BlogText = @"Hej Kära medlemmar!" + Environment.NewLine + 
                //                @" Tack så hjärtligt till alla som deltog och var närvarande den 7 maj" + Environment.NewLine + 
                //                @" på konserten ""Vi HAR VUNNIT TILLSAMMANS"" där Alexsander Tkach" + Environment.NewLine + 
                //                @" framförde fantastiska låtar. Alltid ett nöje att se så många bekanta ansikten." + Environment.NewLine + 
                //                @" Vi ses snart igen!" + Environment.NewLine + 
                //                @" MVH. Tetyana Rep", 
                //    Photos = new List<BlogPhoto>() 
                //    {
                //        new BlogPhoto { FileName = "blogg/DSC01941.jpg" },
                //        new BlogPhoto { FileName = "blogg/DSC01961.jpg" },
                //        new BlogPhoto { FileName = "blogg/DSC01969.jpg" },
                //        new BlogPhoto { FileName = "blogg/DSC01978.jpg" },
                        
                //    }
                //},
                new BlogItem
                { 
                    Id = 33,
                    BlogCreated = new DateTime(2013,04,28),
                    BlogHeader = @"Givande föreläsning för kvinnor",
                    BlogText = @"Hej kärra medlemmar!" + Environment.NewLine + 
                                @" Vi vill tacka för så trevlig och givande föreläsning för kvinnor." + Environment.NewLine + 
                                @" Med vänlig hälsning." + Environment.NewLine + 
                                @" Tetyana Rep", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/DSC01915.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01922.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01923.jpg" },
                    }
                },
                //new BlogItem
                //{ 
                //    Id = 32,
                //    BlogCreated = new DateTime(2013,05,07),
                //    BlogHeader = @"Alexsander Tkach",
                //    BlogText = @"Hej kärra medlemmar!" + Environment.NewLine + 
                //                @" Jag vill tacka Shahla  Alamshahi  för den trafiksäkerhetsföreläsningen." + Environment.NewLine + 
                //                @" Det var jätte givande för vuxna och barnen. Vi kunde se många bilder" + Environment.NewLine + 
                //                @" och höra fakta som gör oss extra försiktiga i trafiken." + Environment.NewLine + 
                //                @" Med vänlig hälsning." + Environment.NewLine + 
                //                @" Tetyana Rep - ordförande", 
                //    Photos = new List<BlogPhoto>() 
                //    {
                //        new BlogPhoto { FileName = "blogg/DSC01941.jpg" },
                //        new BlogPhoto { FileName = "blogg/DSC01961.jpg" },
                //        new BlogPhoto { FileName = "blogg/DSC01969.jpg" },
                //        new BlogPhoto { FileName = "blogg/DSC01978.jpg" },

                //    }
                //},
                new BlogItem
                { 
                    Id = 31,
                    BlogCreated = new DateTime(2013,04,21),
                    BlogHeader = @"Shahla  Alamshahi på Askims Montessoriskola",
                    BlogText = @"Hej kärra medlemmar!" + Environment.NewLine + 
                                @" Jag vill tacka Shahla  Alamshahi  för den trafiksäkerhetsföreläsningen." + Environment.NewLine + 
                                @" Det var jätte givande för vuxna och barnen. Vi kunde se många bilder" + Environment.NewLine + 
                                @" och höra fakta som gör oss extra försiktiga i trafiken." + Environment.NewLine + 
                                @" Med vänlig hälsning." + Environment.NewLine + 
                                @" Tetyana Rep - ordförande", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/DSC01889.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01891.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01898.jpg" },
                    }
                },
                new BlogItem
                { 
                    Id = 30,
                    BlogCreated = new DateTime(2013,04,14),
                    BlogHeader = @"Alla Choifer på Askims Montessoriskola",
                    BlogText = @"Vi tackar Alla Choifer för givande diskussion" + Environment.NewLine + 
                                @" och möjlighet att få prata om sina tankar och problem." + Environment.NewLine + 
                                @" Stor tack till artisterna, fina sångare!" + Environment.NewLine + 
                                @" Tack för fin atmosfär och trevlig sällskap." + Environment.NewLine + 
                                @" Med vänlig hälsning" + Environment.NewLine + 
                                @" Tetyana Rep - ordförande", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/DSC01860.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01867.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01875.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01879.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01881.jpg" },
                        
                    }
                },
                new BlogItem
                { 
                    Id = 29,
                    BlogCreated = new DateTime(2013,03,17),
                    BlogHeader = @"""Minnet om Shevchenko"" på Askims Montessoriskola",
                    BlogText = @"Hej kära vänner!" + Environment.NewLine + 
                                @" Jag vill så hjärligt tacka vara artister barn grupp ""Veselka"" och flöjtist Anastasia Bila och " + Environment.NewLine + 
                                @" Mats Drevstad dragspel som kom och överaskade Er med" + Environment.NewLine + 
                                @" en konsert och fotoutställningen ""Minnet om Shevchenko"" den 17 mars på Askims Montessoriskola" + Environment.NewLine + 
                                @" Tusen tack för en fantastisk och fin dag." + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @" MVH.Tetyana Rep - ordförande" + Environment.NewLine + 
                                @" Tel: 0737310094", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/DSC01825.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01814.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01827.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01831.jpg" },
                        
                    }
                },
                new BlogItem
                { 
                    Id = 28,
                    BlogCreated = new DateTime(2013,01,26),
                    BlogHeader = @"Allaktivitetshus Serbiska kulturföreningen Södertälje",
                    BlogText = @"Hej kära vänner!" + Environment.NewLine + 
                                @" Jag vill så hjärligt tacka vara artister, som kom och överaskade Er med" + Environment.NewLine + 
                                @" en konsert den 26 januari 2013 på Allaktivitetshus Saltskog u Södertälje." + Environment.NewLine + 
                                @" Ett särskillt  tack till Serbiska kulturföreningen Södertalje, som organiserade" + Environment.NewLine + 
                                @" den underbar kulturarrangemang." + Environment.NewLine + 
                                @" Det var en upplevelserik." + Environment.NewLine + 
                                @" Ett stort tack." + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @" MVH.Tetyana Rep" + Environment.NewLine + 
                                @" Tel: 0737310094", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/DSC01787.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01778.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01779.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01781.jpg" },
                    }
                },
                new BlogItem
                { 
                    Id = 27,
                    BlogCreated = new DateTime(2013,01,23),
                    BlogHeader = @"Emigranternas Hus",
                    BlogText = @"Hej kära vänner!" + Environment.NewLine + 
                                @" Jag vill så hjärligt tacka alla, som kom och" + Environment.NewLine + 
                                @" deltog vid miniseminarium den 23 januari på Emigranternas Hus." + Environment.NewLine + 
                                @" Ett särskillt  tack till Mikael Petersson, som Mångfald och Integrationschef i Folksam," + Environment.NewLine + 
                                @" som berättade om pensionsfrågor och vi har fått all nyttig information om Folksam och" + Environment.NewLine + 
                                @" den fina hjälpmedel." + Environment.NewLine + 
                                @" Tack till Julio Fuentes från SIOS , som berättade om" + Environment.NewLine + 
                                @" vardagen för personer med funktionsnedsättning." + Environment.NewLine + 
                                @" Vi vill säga att Ukrainska Alliansen i Sverige är en stolt medlem av SIOS och vi hoppas på" + Environment.NewLine + 
                                @" en försatt trevlig sammarbete med dem i framtiden." + Environment.NewLine + 
                                @" Tack till var artister som överaskade Er med en konsert, både öperasång och showw med en trollkarl." + Environment.NewLine + 
                                @" Det var en upplevelserik." + Environment.NewLine + 
                                @" Ett stort tack." + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @" MVH.Tetyana Rep - ordförande" + Environment.NewLine + 
                                @" Tel: 0737310094", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/DSC01753.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01742.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01762.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01769.jpg" },
                        
                    }
                },
                new BlogItem
                { 
                    Id = 26,
                    BlogCreated = new DateTime(2012,11,28),
                    BlogHeader = @"Möte",
                    BlogText = @"Den 28 november 2012  Stockholm, Alexsander Eriksson(vise ordförande UAIS) tillsammans med Lioudmila Sigel(ordförande Ryska Riksförbundet) på möte till dialog om att motverka etnisk diskriminering.", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/121128.jpg" },
                    }
                },
                new BlogItem
                { 
                    Id = 25,
                    BlogCreated = new DateTime(2012,10,24),
                    BlogHeader = @"FN - dagen Allegården pensionsförening",
                    BlogText = @"Hej kära medlemmar och gäster!" + Environment.NewLine + 
                                @"Jag vill säga ett stort tack till de som var med" + Environment.NewLine + 
                                @"och firade FN - dagen den 24 oktober i Allegården pensionsförening" + Environment.NewLine + 
                                @"och ett enormt tack till alla som hjälpte till ordna var konsert." + Environment.NewLine + 
                                @"Alla artister, utan er hade det aldrig gått." + Environment.NewLine + 
                                @"Ett särskillt tack till Birgita Dovmyr (ordförande Allegårdens pensionärsförening)" + Environment.NewLine + 
                                @"Ännu ett tack till var och en av er som kom, hoppas ni hade en" + Environment.NewLine + 
                                @"trevlig dag, ta hand om varandra, och vi ser framemot att se er alla nästa år igen." + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @"MVH. Tetyana Rep - ordförande", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/DSC01616.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01617.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01618.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01629.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01633.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01647.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01648.jpg" },
                    }
                },
                new BlogItem
                { 
                    Id = 24,
                    BlogCreated = new DateTime(2012,10,07),
                    BlogHeader = @"Galina Bodiakovas utställning",
                    BlogText = @"Hej kära medlemmar!" + Environment.NewLine + 
                                @"Vilken dag! Jättetack för denna fina utställningen med" + Environment.NewLine + 
                                @"Galina Bodiakovas tavlor.  Barnen är så duktiga på att" + Environment.NewLine + 
                                @"sjunga och spela instrument, samt rita." + Environment.NewLine + 
                                @" Alltid trevlig stämning och trevliga människor." + Environment.NewLine + 
                                @"MVH. Tetyana Rep", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/DSC01584.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01601.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01602.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01607.jpg" },
                    }
                },
                new BlogItem
                { 
                    Id = 23,
                    BlogCreated = new DateTime(2012,09,16),
                    BlogHeader = @"Föreläsningen av psykologen Alla Choifer",
                    BlogText = @"Hej kära medlemmar!" + Environment.NewLine + 
                                @"Tack för alla som har kommit den 16 september i" + Environment.NewLine + 
                                @"Askims Montessoriskola på den fantastiska och" + Environment.NewLine + 
                                @"mycket givande föreläsningen av psykologen Alla Choifer." + Environment.NewLine + 
                                @"MVH. Tetyana Rep - ordförande.", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/DSC01548.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01556.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01557.jpg" },
                        
                    }
                },
                new BlogItem
                { 
                    Id = 22,
                    BlogCreated = new DateTime(2012,09,09),
                    BlogHeader = @"Konsert på Flunsåsparken",
                    BlogText = @"Hej kära vänner!" + Environment.NewLine + 
                                @"Jag vill så hjärligt tacka alla, som kom och" + Environment.NewLine + 
                                @"deltog vid konsert på Flunsåsparken den 9 september." + Environment.NewLine + 
                                @"Ett särskillt  tack till barn gruppa ""Veselka"" och artister :Mats Drevstad," + Environment.NewLine + 
                                @"Anastasia Bila, Irina Moshkova-Paulsen och Irina Belkovskaja." + Environment.NewLine + 
                                @"Det var en upplevelserik." + Environment.NewLine + 
                                @"Ett stort tack." + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @"MVH.Tetyana Rep - ordförande" + Environment.NewLine + 
                                @"Tel: 0737310094", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/IMG_1203.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01519.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01536.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01541.jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_1197.jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_1207.jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_1208.jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_1217.jpg" },
                        new BlogPhoto { FileName = "blogg/IMG_1219.jpg" },
                    }
                },
                //new BlogItem
                //{ 
                //    Id = 21,
                //    BlogCreated = new DateTime(2012,05,08),
                //    BlogHeader = @"VI HAR VUNNIT TILLSAMMANS",
                //    BlogText = @"Hej kära vänner!" + Environment.NewLine + 
                //                @"" + Environment.NewLine + 
                //                @"Jag vill så hjärligt tacka alla,som kom och deltog vid konsert ""VI HAR VUNNIT TILLSAMMANS"" den 8 maj på Emigranternas Hus." + Environment.NewLine + 
                //                @"Ett särskillt tack till ALEKSANDR TKACH, sångare, kompositör, bard från Ukraina." + Environment.NewLine + 
                //                @"Det var en upplevelse." + Environment.NewLine + 
                //                @"" + Environment.NewLine + 
                //                @"Ett stort tack." + Environment.NewLine + 
                //                @"MVH. Tetyana Rep - ordförande", 
                //    Photos = new List<BlogPhoto>() 
                //    {
                //        new BlogPhoto { FileName = "blogg/DSC01401.jpg" },
                //        new BlogPhoto { FileName = "blogg/DSC01399.jpg" },
                //        new BlogPhoto { FileName = "blogg/DSC01403.jpg" },
                //        new BlogPhoto { FileName = "blogg/DSC01404.jpg" },
                //        new BlogPhoto { FileName = "blogg/DSC01405.jpg" },
                //        new BlogPhoto { FileName = "blogg/DSC01406.jpg" },
                //        new BlogPhoto { FileName = "blogg/DSC01410.jpg" },
                //        new BlogPhoto { FileName = "blogg/DSC01415.jpg" },
                //    }
                //},
                new BlogItem
                { 
                    Id = 20,
                    BlogCreated = new DateTime(2012,03,31),
                    BlogHeader = @"Ritual för Initiering till Kosacker och utställning ""Min Ukraina"" Emigranternas Hus",
                    BlogText = @"Hej kära vänner!" + Environment.NewLine + 
                                @"" + Environment.NewLine + 
                                @"Jag vill så hjärtligt tacka alla som kom och deltog vid dubbningen till Kosacker. Ett särskillt tack till våra gäster Kosaker från Zoporoshe och Herson. Ett ännu särskillt tack Alexsandr Pitula,Oleg Sinaev och Alexsandr Erikson, ni gjörde den här dagen unik. Tack till Bijan Shafiei ordförande SIOS och Mikael Petersson Mångfald Integrationschefen i Folksam för all nyttig information om Folksam och dess fina hjälpmedel. Även ett enormt tack till alla de som hjälpte till med otroligt fina utställningen samt serveringen." + Environment.NewLine + 
                                @"" + Environment.NewLine + 
                                @"Ni alla som vanligt är bäst och tillsammans är vi starka." + Environment.NewLine + 
                                @"" + Environment.NewLine + 
                                @"MVH. Tetyana Rep - ordförande", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/DSC01263.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01277.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01287.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01293.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01299.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01358.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01366.jpg" },
                    }
                },
                new BlogItem
                { 
                    Id = 19,
                    BlogCreated = new DateTime(2012,03,10),
                    BlogHeader = @"Matresa på Axel Huset",
                    BlogText = @"Hej kära medlemmar!" + Environment.NewLine + 
                                @"Jag vill tacka våra medlemar, Tetiana och Angelika Kornienko samt" + Environment.NewLine + 
                                @"Markku Taka - Ano, som hjälpte till att laga den underbara ukrainska " + Environment.NewLine + 
                                @"borsjen den 10 mars till ""Matresa på Axel Huset"". Ni var bästa, ännu en" + Environment.NewLine + 
                                @"gång tack för stöd och hjälp!" + Environment.NewLine + 
                                @"MVH.Tetyana Rep", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/P1190030.jpg" },
                        new BlogPhoto { FileName = "blogg/P1190031.jpg" },
                        new BlogPhoto { FileName = "blogg/P1190032.jpg" },
                        new BlogPhoto { FileName = "blogg/P1190033.jpg" },
                        new BlogPhoto { FileName = "blogg/P1190034.jpg" },
                        new BlogPhoto { FileName = "blogg/P1190035.jpg" },
                        new BlogPhoto { FileName = "blogg/P1190036.jpg" },
                        new BlogPhoto { FileName = "blogg/P1190037.jpg" },
                        new BlogPhoto { FileName = "blogg/P1190038.jpg" },
                        new BlogPhoto { FileName = "blogg/P1190039.jpg" },
                        new BlogPhoto { FileName = "blogg/P1190040.jpg" },
                        new BlogPhoto { FileName = "blogg/P1190041.jpg" },
                        new BlogPhoto { FileName = "blogg/P1190042.jpg" },
                        new BlogPhoto { FileName = "blogg/P1190043.jpg" },
                        new BlogPhoto { FileName = "blogg/P1190044.jpg" },
                        new BlogPhoto { FileName = "blogg/P1190045.jpg" },
                        new BlogPhoto { FileName = "blogg/P1190046.jpg" },
                        new BlogPhoto { FileName = "blogg/P1190047.jpg" },
                        new BlogPhoto { FileName = "blogg/P1190048.jpg" },
                        new BlogPhoto { FileName = "blogg/P1190049.jpg" },

                    }
                },
                new BlogItem
                { 
                    Id = 18,
                    BlogCreated = new DateTime(2012,03,03),
                    BlogHeader = @"Internationella kvinnodagen",
                    BlogText = @"Hej kära medlemmar och gäster!" + Environment.NewLine + 
                                @"Jag vill säga ett stort tack till de som var med" + Environment.NewLine + 
                                @"och firade Internationella kvinnodagen den 3 mars 2012 i Emigranternas Hus" + Environment.NewLine + 
                                @"och ett enormt tack till alla som hjälpte till ordna var konsert." + Environment.NewLine + 
                                @"Alla artister, utan er hade det aldrig gått. Illusionisten som" + Environment.NewLine + 
                                @"som alltid skapar magi på alla vara evenemang." + Environment.NewLine + 
                                @"Ett särskillt tack till Flamengo paret, vilken show ni ställde till med!" + Environment.NewLine + 
                                @"Ännu ett tack till var och en av er som kom, hoppas ni hade en " + Environment.NewLine + 
                                @"trevlig kväll, ta hand om varandra, speciellt om era käraste kvinnor " + Environment.NewLine + 
                                @"och vi ser framemot att se er alla nästa år igen." + Environment.NewLine + 
                                @"" + Environment.NewLine + 
                                @"MVH. Tetyana Rep - ordförande", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/Nastja_Bila.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01217.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01225.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01227.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01229.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC01231.jpg" },
                        new BlogPhoto { FileName = "blogg/Eva_2.jpg" },
                        new BlogPhoto { FileName = "blogg/Eva_Milic.jpg" },
                        new BlogPhoto { FileName = "blogg/Kim.jpg" },
                        new BlogPhoto { FileName = "blogg/Kvinnor.jpg" },
                    }
                },
                new BlogItem
                { 
                    Id = 17,
                    BlogCreated = new DateTime(2011,09,23),
                    BlogHeader = @"Allegårdens Pensionärsförening/Askim Montessoriskola",
                    BlogText = @"Hej kära medlemmar!" + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @"Tack för en fantastisk utställning och underbar konsert! " + Environment.NewLine + 
                                @"Man riktig känner hur budskapet sjunker in och hjärta lyssnar och sjunger med!" + Environment.NewLine + 
                                @"Barnen var så lysande duktiga!! Deras musikaliska begåvning utmanar de till att utveckla deras underbara sång- och musikstil!!" + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @"Inspiration, Kunskap, Kontakt..." + Environment.NewLine + 
                                @"Härliga arrangemang och ödmjukt och engagerat ordförande!" + Environment.NewLine + 
                                @"Det är det värt! Blev så otroligt berörd!" + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @"Jag är så otroligt glad och stolt och riktar mitt stor tack till Er som gjorde vår utställning " + Environment.NewLine + 
                                @"""20 år självständig Ukraina"". " + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @"Tack för  barn gruppa ""Veselka"" för Er insats under vår fest!" + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @"MVH " + Environment.NewLine + 
                                @"Tetyana Rep - ordförande Ukrainska Alliansen i Sverige", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/DSC00672.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC00674.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC00677.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC00685.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC00686.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC00687.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC00688.jpg" },
                        new BlogPhoto { FileName = "blogg/DSC00689.jpg" },
                        
                    }
                },
                new BlogItem
                { 
                    Id = 16,
                    BlogCreated = new DateTime(2011,08,08),
                    BlogHeader = @"20 år självständig Ukraina",
                    BlogText = @"Foto - Ukraina vokalansambl ""DEBUT"" den 23.09 på Allegårdens Pensionärsförening" + Environment.NewLine + 
                                @"Visit konsula den 23.09 på Askim Montessoriskola" + Environment.NewLine + 
                                @"MVH Tetyana", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/2011001.jpg" },
                        new BlogPhoto { FileName = "blogg/2011349.jpg" },
                        new BlogPhoto { FileName = "blogg/2011351.jpg" },
                        new BlogPhoto { FileName = "blogg/2011352.jpg" },
                        new BlogPhoto { FileName = "blogg/2011353.jpg" },
                        new BlogPhoto { FileName = "blogg/2011355.jpg" },
                        new BlogPhoto { FileName = "blogg/2011361.jpg" },
                        new BlogPhoto { FileName = "blogg/2011368.jpg" },
                        new BlogPhoto { FileName = "blogg/2011379.jpg" },
                        new BlogPhoto { FileName = "blogg/2011380.jpg" },
                        new BlogPhoto { FileName = "blogg/2011385.jpg" },
                        new BlogPhoto { FileName = "blogg/2011386.jpg" },
                        new BlogPhoto { FileName = "blogg/2011387.jpg" },
                        new BlogPhoto { FileName = "blogg/2011388.jpg" },
                        new BlogPhoto { FileName = "blogg/2011389.jpg" },
                        new BlogPhoto { FileName = "blogg/2011390.jpg" },
                        new BlogPhoto { FileName = "blogg/2011391.jpg" },
                        new BlogPhoto { FileName = "blogg/2011394.jpg" },
                        new BlogPhoto { FileName = "blogg/2011395.jpg" },
                        new BlogPhoto { FileName = "blogg/2011396.jpg" },
                        new BlogPhoto { FileName = "blogg/2011398.jpg" },
                        new BlogPhoto { FileName = "blogg/2011400.jpg" },
                        new BlogPhoto { FileName = "blogg/2011408.jpg" },
                        new BlogPhoto { FileName = "blogg/2011415.jpg" },
                        new BlogPhoto { FileName = "blogg/2011416.jpg" },
                    }
                },
                new BlogItem
                { 
                    Id = 15,
                    BlogCreated = new DateTime(2011,07,07),
                    BlogHeader = @"St George`s Band",
                    BlogText = @"Hej kära medlemmar!" + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @"Den 8 maj Ukrainska Alliansen i Sverige tillsammans med" + Environment.NewLine + 
                                @"Ukrainskt - Svenskt Kulturförening genomför i Sverige en aktion" + Environment.NewLine + 
                                @"""St George`s Band"" startar runt om i världen och även i Sverige" + Environment.NewLine + 
                                @"på kämparerna mot fascismen gravarna. " + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @"VÄLKOMNA!" + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @"Aktionen är ägnat påminnelsen av Segern i Det Stora försterländska kriget och" + Environment.NewLine + 
                                @"Eurodagen, som hyllar slutet av det Andra världskriget." + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @"Välkomna alla som vill hedra minnet av kämparna mot fascismen genom att" + Environment.NewLine + 
                                @"tända Ljus och symboliskt lägga blommor på gravarna." + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @"Program" + Environment.NewLine + 
                                @"Göteborg" + Environment.NewLine + 
                                @"Den 8 maj, kl: 11.00 på Askim Montessoriskola utställning ""Tack"" eller ""Minnas""." + Environment.NewLine + 
                                @"Efter utställningen konsert med pianisten Irina Belkovskaja. Prisutdelning för alla" + Environment.NewLine + 
                                @"deltagarer av barnmåleritävling." + Environment.NewLine + 
                                @"Kaffe och kakor. Fri entre." + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @"MVH. Tetyana Rep", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/dsc00461.jpg" },
                        new BlogPhoto { FileName = "blogg/dsc00462.jpg" },
                        new BlogPhoto { FileName = "blogg/dsc00464.jpg" },
                        new BlogPhoto { FileName = "blogg/dsc00471.jpg" },
                        new BlogPhoto { FileName = "blogg/dsc00477.jpg" },
                        new BlogPhoto { FileName = "blogg/dsc00478.jpg" },
                        new BlogPhoto { FileName = "blogg/dsc00479.jpg" },
                        new BlogPhoto { FileName = "blogg/dsc00480.jpg" },
                    }
                },
                new BlogItem
                { 
                    Id = 14,
                    BlogCreated = new DateTime(2011,05,05),
                    BlogHeader = @"Fotoutställningen ""Minnet av Shevchenko"" av Ruslan Telipskij",
                    BlogText = @"Hej kära medlemmar!" + Environment.NewLine + 
                                @"Det var en fantastisk händelse att vi fick träffa" + Environment.NewLine + 
                                @"Ruslan Telipskij från Ukraina!!!" + Environment.NewLine + 
                                @"Vi som bor i Sverige är så obeskrivligt hungriga på" + Environment.NewLine + 
                                @"vår kultur... man ska ta vara på historien, utan den kan man inte" + Environment.NewLine + 
                                @"gå vidare... och utveklas som en garmonisk och produktiv människa." + Environment.NewLine + 
                                @"Allt lysna på nationall sång, gimn, var som att ladda sina batterier för " + Environment.NewLine + 
                                @"att få tillbacka den obegränsat styrka som någon kanske förlorade på" + Environment.NewLine + 
                                @"vägen till Sverige." + Environment.NewLine + 
                                @"Stor Tack till alla som ordnade den fantastiska träffen." + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @"MVH. Tetyana Rep", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/dsc00412.jpg" },
                        new BlogPhoto { FileName = "blogg/dsc00423.jpg" },
                        new BlogPhoto { FileName = "blogg/dsc00435.jpg" },
                        new BlogPhoto { FileName = "blogg/dsc00438.jpg" },
                        
                    }
                },
                new BlogItem
                { 
                    Id = 13,
                    BlogCreated = new DateTime(2011,03,05),
                    BlogHeader = @"International Kvinnodag",
                    BlogText = @"Den 5 mars 2011 kl: 17.00 - 23.00 på Högsbo Taverna vår förening" + Environment.NewLine + 
                                @"har haft International Kvinnodag konsert för vara medlemmar." + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @"Tack till alla medlemmar som medverkade vid vara fest." + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @"Hjärtlig tack för underbar underhållning till Nikolaj Gilöv, Irina Fransson," + Environment.NewLine + 
                                @"Tatyana Staroselets, Irina Moshkova, Irina Belkovskaja, Ksenija Staroselets," + Environment.NewLine + 
                                @"Lejla Bakurskaja, Petre Cataneanu, som har trollat, sjungit, dansad. Det har" + Environment.NewLine + 
                                @"kommit 73 vuxna och 5 barn. Alla blev bjudna på mat och dricka. Fest lyckades " + Environment.NewLine + 
                                @"och alla vår glada." + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @"MVH. Tetyana Rep", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/dsc00379.jpg" },
                        new BlogPhoto { FileName = "blogg/dsc00386.jpg" },
                        new BlogPhoto { FileName = "blogg/dsc00389.jpg" },
                        new BlogPhoto { FileName = "blogg/dsc00393.jpg" },
                    }
                },
                new BlogItem
                { 
                    Id = 12,
                    BlogCreated = new DateTime(2011,02,02),
                    BlogHeader = @"Film ""Väskan""",
                    BlogText = @"Film ""Väskan""" + Environment.NewLine + 
                                @"MVH. Tetyana Rep", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "dsc00366.jpg" },
                        new BlogPhoto { FileName = "dsc00367.jpg" },
                        new BlogPhoto { FileName = "dsc00372.jpg" },
                    }
                },
                new BlogItem
                { 
                    Id = 11,
                    BlogCreated = new DateTime(2011,01,23),
                    BlogHeader = @"Filmfestival",
                    BlogText = @"Filmfestivalen 23 jan 2011" + Environment.NewLine + 
                                @"Med hjärtliga hälsningar" + Environment.NewLine + 
                                @"Tetyana Rep", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/dsc00316.jpg" },
                        new BlogPhoto { FileName = "blogg/dsc00310.jpg" },
                        new BlogPhoto { FileName = "blogg/dsc00325.jpg" },
                    }
                },
                new BlogItem
                { 
                    Id = 10,
                    BlogCreated = new DateTime(2011,01,16),
                    BlogHeader = @"Årsmöte",
                    BlogText = @"Årsmöte 16 jan 2011", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/dsc00294.jpg" },
                    }
                },
                new BlogItem
                { 
                    Id = 9,
                    BlogCreated = new DateTime(2010,12,12),
                    BlogHeader = @"Tack till alla medlemmar som medverkade vid var Julbord och Julfest i Askims Montessoriskola i Göteborg",
                    BlogText = @"Tack till alla medlemmar som medverkade vid var Julbord och Julfest" + Environment.NewLine + 
                                @"i Askims Montessoriskola i Göteborg." + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @"Hjärtlig tack för underbar underhållning till pianist Irina Belkovskaja," + Environment.NewLine + 
                                @"Mats Drevstad, Lejla Bakurskaya, Olga Mirovskaja, kören Veselka," + Environment.NewLine + 
                                @"Dragisa Vlahovic, programledare Tatyana och Ksenija Staroselets." + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @"Det var en fantastisk fest! Barnen sjong så fina sånger från Ukraina," + Environment.NewLine + 
                                @"maten var god." + Environment.NewLine + 
                                @"Vad viktigt att träffas och känna sig Lyckligt!!!" + Environment.NewLine + 
                                @"En stor del av Ukraina har vi här i Sverige!" + Environment.NewLine + 
                                @"Tack för en underbar dag, trevliga minne i så mycket glädje..." + Environment.NewLine + 
                                @" " + Environment.NewLine + 
                                @"Med hjärtliga hälsningar" + Environment.NewLine + 
                                @"Tetyana Rep", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg/dsc00109.jpg" },
                        new BlogPhoto { FileName = "blogg/dsc00097.jpg" },
                        new BlogPhoto { FileName = "blogg/dsc00100.jpg" },
                        new BlogPhoto { FileName = "blogg/dsc00115.jpg" },
                    }
                },
                new BlogItem
                { 
                    Id = 8,
                    BlogCreated = new DateTime(2010,11,11),
                    BlogHeader = @"Ukrainska Alliansen i Sverige tillsammans med Ukrainskt-Svenskt Kulturförening i minimässa, presenterar vår kultur och vår äldre grupp",
                    BlogText = @"Ukrainska Alliansen i Sverige tillsammans med Ukrainskt-Svenskt Kulturförening i minimässa, presenterar vår kultur och vår äldre grupp.", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg101125/DSC00047.jpg" },
                        new BlogPhoto { FileName = "blogg101125/DSC00048.jpg" },
                        new BlogPhoto { FileName = "blogg101125/DSC00051.jpg" },
                        new BlogPhoto { FileName = "blogg101125/DSC00055.jpg" },
                    }
                },
                new BlogItem
                { 
                    Id = 7,
                    BlogCreated = new DateTime(2010,09,23),
                    BlogHeader = @"IT´S OUR DAY - kvinnokonference",
                    BlogText = @"Tack till alla medlemmar och gäster som medverkade vid var Kvinnokonferens" + Environment.NewLine + 
                                @"Två värderingar och jämställdhet i Emigranternas Hus den 23 september 2010" + Environment.NewLine + 
                                @"" + Environment.NewLine + 
                                @"Hjärtlig tack för underbar underhållning till Rashin Forotan Fard, jurist från " + Environment.NewLine + 
                                @"advokatfirma, till Evgenja Belkovskaja, Irina Belkovskaja, Nikolaj Gilöv," + Environment.NewLine + 
                                @"Petre Cataneanu." + Environment.NewLine + 
                                @"" + Environment.NewLine + 
                                @"Samt stor tack till Tatyana och Ksenija Staroselets, Wolodymyr bretan, som" + Environment.NewLine + 
                                @"hjälpte oss med det praktiska som dukning, fotografering." + Environment.NewLine + 
                                @"" + Environment.NewLine + 
                                @"Med hjärtliga hälsningar," + Environment.NewLine + 
                                @"Tetyana Rep", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg100930/S6301357.jpg" },
                        new BlogPhoto { FileName = "blogg100930/S6301354.jpg" },
                        new BlogPhoto { FileName = "blogg100930/S6301355.jpg" },
                        new BlogPhoto { FileName = "blogg100930/S6301358.jpg" },
                        new BlogPhoto { FileName = "blogg100930/S6301364.jpg" },
                        new BlogPhoto { FileName = "blogg100930/S6301370.jpg" },
                        
                    }
                },
                new BlogItem
                { 
                    Id = 6,
                    BlogCreated = new DateTime(2010,08,30),
                    BlogHeader = @"Vår Utställning ""Ukrainas folkdräkter genom åren"" den 30 augusti - 9 september 2010 på Stadsbiblioteket",
                    BlogText = @"Utställning ""Ukrainas folkdräkter genom åren"" den 30 augusti - 9 september 2010 på Stadsbiblioteket.", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg100830/s6301300.jpg" },
                        new BlogPhoto { FileName = "blogg100830/s6301292.jpg" },
                        new BlogPhoto { FileName = "blogg100830/s6301294.jpg" },
                        new BlogPhoto { FileName = "blogg100830/s6301299.jpg" },
                        new BlogPhoto { FileName = "blogg100830/s6301301.jpg" },
                    }
                },
                new BlogItem
                { 
                    Id = 5,
                    BlogCreated = new DateTime(2010,05,22),
                    BlogHeader = @"Vår Utställning ""Ukrainas folkdräkter genom åren"" den 22 maj 2010 kl. 12.00-16.00 på Emigranternas Hus",
                    BlogText = @"Hej !" + Environment.NewLine + 
                                @"" + Environment.NewLine + 
                                @"Tack till alla medlemmar som medverkade vid vår utställning ." + Environment.NewLine + 
                                @"" + Environment.NewLine + 
                                @"Vårt Utställning ""Ukrainas folkdräkter genom åren"" den 22 maj 2010 kl. 12.00-16.00 på Emigranternas Hus var väldigt lyckad." + Environment.NewLine + 
                                @"" + Environment.NewLine + 
                                @"Det var roligt både för barn och vuxna." + Environment.NewLine + 
                                @"Med Vänliga Hälsningar," + Environment.NewLine + 
                                @"Tetyana Rep", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "blogg100522/S6301057.jpg" },
                        new BlogPhoto { FileName = "blogg100522/S6301051.jpg" },
                        new BlogPhoto { FileName = "blogg100522/S6301053.jpg" },
                        new BlogPhoto { FileName = "blogg100522/S6301061.jpg" },
                        new BlogPhoto { FileName = "blogg100522/S6301062.jpg" },
                        new BlogPhoto { FileName = "blogg100522/S6301065.jpg" },
                        new BlogPhoto { FileName = "blogg100522/S6301067.jpg" },
                        new BlogPhoto { FileName = "blogg100522/S6301071.jpg" },
                        new BlogPhoto { FileName = "blogg100522/S6301078.jpg" },
                        new BlogPhoto { FileName = "blogg100522/S6301082.jpg" },
                        new BlogPhoto { FileName = "blogg100522/S6301083.jpg" },
                        new BlogPhoto { FileName = "blogg100522/S6301085.jpg" },
                        new BlogPhoto { FileName = "blogg100522/S6301089.jpg" },
                        new BlogPhoto { FileName = "blogg100522/S6301092.jpg" },
                        new BlogPhoto { FileName = "blogg100522/S6301093.jpg" },
                        new BlogPhoto { FileName = "blogg100522/S6301097.jpg" },
                        new BlogPhoto { FileName = "blogg100522/S6301101.jpg" },
                        new BlogPhoto { FileName = "blogg100522/S6301103.jpg" },
                        new BlogPhoto { FileName = "blogg100522/S6301107.jpg" },
                        new BlogPhoto { FileName = "blogg100522/S6301111.jpg" },
                        new BlogPhoto { FileName = "blogg100522/S6301113.jpg" },
                        new BlogPhoto { FileName = "blogg100522/S6301121.jpg" },
                    }
                },
                new BlogItem
                { 
                    Id = 4,
                    BlogCreated = new DateTime(2009,12,05),
                    BlogHeader = @"Julbord med trolleri",
                    BlogText = @"Den 5 December 2009 från kl.12.00 - 16.00 gjorde vi Julbord för barn och vuxna. Det var professionell trolleri för barn från vår lokalförening, presenterat kom Petre Catanuanu. Kända operasångaren Irina Moshkova och barnkören sjöng till oss. Efteråt besökte tomten oss och gav presenter för barn. Vi bjöd på jullbord och fika.", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "s6300860.jpg" },
                    }
                },
                new BlogItem
                { 
                    Id = 3,
                    BlogCreated = new DateTime(2009,11,03),
                    BlogHeader = @"Föredrag ""Välkommen in till det Svenska samhället""",
                    BlogText = @"Den 3 November 2009 hade vi en föreläsning för våra lokalmedlemmar med temat: ""Välkommen in till det Svenska samhället"". Elena Persson höll föreläsningen.", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "s6300750.jpg" },
                    }
                },
                new BlogItem
                { 
                    Id = 2,
                    BlogCreated = new DateTime(2009,10,25),
                    BlogHeader = @"Föreläsning på Odinskolan för våra lokalföreningar om Ångeset och Panikattacker",
                    BlogText = @"Den 25 Oktober 2009 från kl.10.30-14.00 hade vi en föreläsning på Odinskolan för våra lokalföreningar om Ångeset och Panikattacker samt olika hälsoproblem bland annat Hiv mm. Samt hur man bäst kan behandla själv. Yvette Holinger har gjort föreläsningen, kvinnorna hade många frågor om ångest och panikproblematik. Det var en lyckad dag med många information och råd. Efter föreläsningen bjöd vi på fika.", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "s6300725.jpg" },
                    }
                },
                new BlogItem
                { 
                    Id = 1,
                    BlogCreated = new DateTime(2009,10,24),
                    BlogHeader = @"Det riktiga arbetet med Ukrainska Alliansen börjar",
                    BlogText = @"Den 24 Oktober 2009 började vi det riktiga arbetet med Ukrainska Alliansen i samband med våra lokalföreningar. Vi hade öppet hus på FN dagen där vi presenterade vår kultur med olika programmer bland annat med kända Ukrainska operasångare, Irina Mochkova. Ukrainskt gymnastik presenterad av silvermedalj vinnaren, Ksenia Staroselets. Barnen sjöng Ukrainska sånger. Vi gjorde även en liten utställning om Ukraina, som hette ""Lär känna Ukraina"".", 
                    Photos = new List<BlogPhoto>() 
                    {
                        new BlogPhoto { FileName = "s6300766.jpg" },
	                    new BlogPhoto { FileName = "s6300779.jpg" },
                        new BlogPhoto { FileName = "s6300782.jpg" },
                        new BlogPhoto { FileName = "s6300790.jpg" },
                        new BlogPhoto { FileName = "s6300796.jpg" },                        
                    }
                },
            });

            kernel.Bind<IBlogRepository>().ToConstant(mock.Object);
        }
    }
}
    