using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;



namespace StokTakip.Tests
{
    [TestClass]
   public class StokTakipTest
    {
        [TestMethod, ExpectedException(typeof(AuthenticationException))] //testin basarili olabilmesi icin hata olmasi gerek(hata geri donduruyor)
        public void kullaniciSifreHataliGiris()
        {
            LoginEkran control = new LoginEkran();//LoginEkran formunda 106. satır yorum satırı aktif edilmeli ki, geriye hata mesajı göndersin test başarılı olsun
            control.giris("dssd", "sdsdds");
        }


        [TestMethod, ExpectedException(typeof(AuthenticationException))] //testin basarili olabilmesi icin hata olmasi gerek
        public void kullaniciSifreGirilmemesi()
        {
            LoginEkran control = new LoginEkran(); //LoginEkran formunda 99. satır yorum satırı aktif edilmeli ki, geriye hata mesajı göndersin test başarılı olsun
            control.giris("", "");
        }

        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void KullaniciEkleBoslukKontrol()
        {
            KullaniciEkle control = new KullaniciEkle();//KullaniciEkle formunda 66. satır yorum satırı aktif edilmeli ki, geriye hata mesajı göndersin test başarılı olsun
            control.kullaniciEkle(2, 2, "", "");
        }



        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void BolumRolKontrol()
        {
            KullaniciEkle control = new KullaniciEkle();//KullaniciEkle formunda 56. satır yorum satırı aktif edilmeli ki, geriye hata mesajı göndersin test başarılı olsun
            control.kullaniciEkle(9, 9, "neclet", "123456");
        }


        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void StokEkleKontrol()
        {
            SatinAlma control = new SatinAlma();//SatinAlma formunda 51. satır yorum satırı aktif edilmeli ki, geriye hata mesajı göndersin test başarılı olsun
            control.StokEkle("", 3, DateTime.Now, "", 10, 30, "altin Bilisim");
        }

    }
}
