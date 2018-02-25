using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TurkAppService
{
    class Core
    {
        public Core() => MainAsyncC().Wait();



        static async Task MainAsyncC()
        {


            var connectionString = "mongodb://176.240.38.38:27017";

            var client = new MongoClient(connectionString);
            IMongoDatabase db = client.GetDatabase("turkapp");
            var collection = db.GetCollection<CrFirma>("markets");

                // var newAREYNode = CreateFirma();
                //await collection.InsertManyAsync(newAREYNode);

/*

            List<string> listemmm = new List<string>()
            { "123231,23232,3232323,23232,3232" , "422323,232332,1212132,3232","2323232,32321,21321321,123"};

            //    var result = await collection.FindOneAndUpdateAsync(Builders<CrFirma>.Filter.Eq("FirmaID", "1"),
            //      Builders<CrFirma>.Update.Set("firmaUrunler", listemmm));



            collection.UpdateOne(x => x._id == "0",
              Builders<CrFirma>.Update.Set(x => x.firmaUrunler, listemmm));

    */
        }







        static IEnumerable<CrFirma> CreateFirma ()//(string firmaID, string firmaAdi, string firmaLogo, string )
        {
            var df = new CrFirma()
            {
                Coordinates= new List<double>() { 41.095497, 28.80278 },
                firmaAdi= "AREYTech",
                firmaAdres="İncesu caddesi 91-5 Çanakya Ankara",
                FirmaID="1",
                firmaLogo= "https://i.ytimg.com/vi/_8j2zMal02M/maxresdefault.jpg",
                firmaTelefon="+905070443888",
                firmaType="tekno",
                firmaUrunler= new List<string>() { "" },
                _id="0"
            };


            var AREYNodeX = new List<CrFirma> { df };
            return AREYNodeX;

        }


        internal class CrProduct
        {       // 

            public object _id { get; set; }
            public string FirmaID { get; set; }
            public string MainImage { get; set; }
            public IEnumerable<string> Images { get; set; }
        }

        internal class CrFirma
        {       // 
            public object _id { get; set; }
            public string FirmaID { get; set; }
            public string firmaAdi { get; set; }
            public string firmaLogo { get; set; }
            public string firmaType { get; set; }
            public IEnumerable<double> Coordinates { get; set; } //lat long
            public string firmaAdres { get; set; }
            public string firmaTelefon { get; set; }
            public IEnumerable<string> firmaUrunler { get; set; }
        }


        internal class CrfirmaX
        {


            public string _id { get; set; }
            //  (artikelnumber)
            public string FirmaId { get; set; }
            public string magzaId { get; set; }

            public string _adresBilgisi { get; set; }
            public string _telefon { get; set; }
            public string _email { get; set; }
            public double _latidX { get; set; }
            public double _longtX { get; set; }

            public string calismaSaatleri { get; set; }
            public string SingleUrunBaslik { get; set; }

            public double guncelFiyat { get; set; }
            public double eskiFiyat { get; set; }

            public bool isPremium { get; set; }
            public uint tiklanmaDegeri { get; set; }

            //public string SingleUrunBaslik{ get; set; }
        }




    }
}