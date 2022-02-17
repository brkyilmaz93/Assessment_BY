using Rise_Tech_Rehber.Data;
using Rise_Tech_Rehber.Service.Model.Kisi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rise_Tech_Rehber.Service.Services
{
    public class KisiService : BaseService
    {
        public KisiResponse KisiKaydetGuncelleSil(KisiRequest request)
        {
            var sonuc = new KisiResponse();
            try
            {
                string islem = string.Empty;
                var kayit = request != null && request.Kayit != null ? request.Kayit : null;
                if (kayit == null)
                {
                    sonuc.SetError("Kayıt verisi alınamadı.");
                    return sonuc;

                }
                if (kayit.Id == 0)
                {
                    if (RehberDbContext.KISILER.Any(x => x.Ad == kayit.Ad ))
                    {
                        sonuc.SetError("Bu kişi Kayıtlı...");

                        return sonuc;
                    }
                    else
                    {
                        var yeniKayit = new Kisi
                        {

                            Ad = kayit.Ad,
                            Firma = kayit.Firma,
                            Soyad = kayit.Soyad,

                        };
                        RehberDbContext.Add(yeniKayit);
                    }
                    RehberDbContext.SaveChanges();
                    sonuc.SetSuccess();
                }

                else
                {
                    var mevcutKayit = RehberDbContext.KISILER.FirstOrDefault(x => x.Id == kayit.Id && !x.SilinmisMi);
                    if (mevcutKayit == null)
                    {
                        sonuc.SetError("Kayıt bulunamadı.");
                        return sonuc;
                    }
                    if (request.Kayit.SilinecekMi)
                    {
                        mevcutKayit.SilinmisMi = true;
                        islem = mevcutKayit.Id + "Idli kişi listeden kaldırıldı...";

                    }
                    else
                    {
                        mevcutKayit.Ad = kayit.Ad;
                        mevcutKayit.Soyad = kayit.Soyad;
                        mevcutKayit.Firma = kayit.Firma;
                        //mevcutKayit.IletisimBilgileri = kayit.
                        islem = mevcutKayit.Id + " ıdli kayıt güncellendi..";
                    }
                    RehberDbContext.SaveChanges();
                    sonuc.SetSuccess();
                }
            }
            catch (Exception ex)
            {

                sonuc.SetError(ex.Message +" "+ ex.StackTrace);
            }
            return sonuc;
        }

        public KisiResponse KisileriGetir()
        {
            var sonuc = new KisiResponse();
            try
            {
                sonuc.Liste = RehberDbContext.KISILER
                    .Where(x => !x.SilinmisMi)
                    .Select(x=> new KisiItem
                    {
                        Ad = x.Ad,
                        Soyad = x.Soyad,
                        Firma = x.Firma,
                        Id = x.Id
                    }).ToList();
                sonuc.SetSuccess();
            }
            catch (Exception)
            {
                sonuc.SetError("Kisi Listelenirken Hata İle karşılasıldı.");
            }
            return sonuc;
        }

    }
}
