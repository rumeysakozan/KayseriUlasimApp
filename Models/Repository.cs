namespace KayseriUlasimApp.Models
{
    public class Repository
    {

        private static readonly List<Card> _card = new();

        static Repository()
        {
            _card = new List<Card>(){

                new Card(){
                    Id = 1,
                    Title="Tam Kart38",
                    Description = "Ulaşım hatlarımız üzerinde yer alan duraklara yakın noktalardaki Gişe, Otomatik Dolum Noktaları (Kiosklar) ve bayilerimizden temin edebildiğiniz ulaşım kartıdır.",
                    Image="2.jpg",
                    },
                    new Card(){Id = 2,
                    Title="İndirimli Kart38",
                    Description = "Öğrenci ve öğretmenlerin aşağıda belirtilen evraklar ile Kart38 İşlem Merkezleri'ne başvuru yapılarak alınan kişiselleştirilmiş kartlardır. Kişiye özel olan bu kartların başkaları tarafından kullanımı yasaktır. Böyle durumlarda karta el konularak kart kara listeye alınmaktadır.",
                    Image="3.jpg",
                    },
                    new Card(){Id = 3,
                    Title="Serbest Kart38",
                    Description = "Gazi, Gazi Yakını ve Şehit Yakınları ve Vazife Malulü için tahsis edilecek olan kartlar olup, ücretsiz binişler için kullanılmaktadır. (Aile Sosyal Politikalar Bakanlığı’nca verilen kartlar.) 65 Yaş, Engelli, Engelli Refakatçi, kartları serbest kart grubunda yer almaktadır.",
                    Image="4.jpg",
                    },
                    new Card(){Id = 4,
                    Title="Kaybis Kart",
                    Description = "Kayseri Bisiklet Paylaşım Sistemini kullanarak bisiklet kiralamak amacıyla kullanılan ulaşım kartıdır. Kaybis Kartını, Kart38 İşlem merkezinden tedarik edilebilir.",
                    Image="5.jpg",

                    }
            };
        }

        public static List<Card> KayseriUlasimAppCards
        {
            get
            {
                return _card;
            }
        }

        public static Card? GetById(int? id)
        {
            return _card.FirstOrDefault(c => c.Id == id);
        }
    }
}