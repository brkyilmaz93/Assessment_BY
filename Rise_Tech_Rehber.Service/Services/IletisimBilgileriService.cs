using Rise_Tech_Rehber.Data;
using Rise_Tech_Rehber.Service.Model.Common;
using Rise_Tech_Rehber.Service.Model.IletisimBilgileri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rise_Tech_Rehber.Service.Services
{
    public class IletisimBilgileriService : BaseService
    {
        public IletisimBilgileriResponse IletisimBilgileriKaydetSil(IletisimBilgileriRequest request)
        {
            var sonuc = new IletisimBilgileriResponse();
            try
            {
                string islem = string.Empty;
                var kayit = request != null && request.Kayit != null ? request.Kayit : null;
                if (kayit == null)
                {
                    sonuc.SetError("Kayit verisi alınamadı.");
                }
                if (kayit.Id==0)
                {
                    var yeniKayit = new IletisimBilgisi {
                        IT_ID = kayit.IT_ID,
                        BilgiIcerigi = kayit.BilgiIcerigi,
                        SilinmisMi = kayit.SilinmisMi,
                        UU_ID = kayit.UU_ID                  
                    };
                    RehberDbContext.ILETISIMBILGILER.Add(yeniKayit);
                }
                else
                {
                    var mevcutKayit = RehberDbContext.ILETISIMBILGILER.FirstOrDefault(x => x.IT_ID == kayit.Id && !x.SilinmisMi);
                    if (request.SilinecekMi)
                    {
                        mevcutKayit.SilinmisMi = true;
                        islem = mevcutKayit.IT_ID + "Id'li depo kaydı silindi.";
                    }
                }
                RehberDbContext.SaveChanges();
                sonuc.SetSuccess();

            }

            catch (Exception ex)
            {

                sonuc.SetError("Hata oluştu. hata Mesajı : " + ex.Message);
            }
            return sonuc;
        }
        public IletisimBilgileriResponse IletisimBilgileriDetay(int uu_ID)
        {
            var sonuc = new IletisimBilgileriResponse();
            try
            {
                sonuc.Liste = RehberDbContext.ILETISIMBILGILER
                    .Where(x => x.UU_ID == uu_ID && !x.SilinmisMi)
                    .Select(x => new IletsimBilgiItem
                    {
                        BilgiIcerigi = x.BilgiIcerigi,
                        UU_ID = x.UU_ID,
                        SilinmisMi = x.SilinmisMi,
                        IT_ID = x.IT_ID
                    }).ToList();
                sonuc.SetSuccess();
            }
            catch (Exception ex)
            {
                sonuc.SetError("Liste oluşturulurken hata ile karşılasıldı." + ex.Message);
            }
            return sonuc;
        }

        public TextIdResponse GetIletisimTipListe()
        {
            var sonuc = new TextIdResponse();
            try
            {
                sonuc.Liste = RehberDbContext.ILETISIMTIPLER
                    .Where(x => !x.SilinmisMi)
                    .Select(x => new TextIdModel
                    {
                        Id = x.Id,
                        Text = x.TipAdı,
                        SilinmisMi = x.SilinmisMi
                    }).ToList();
                sonuc.SetSuccess();
            }
            catch (Exception ex)
            {

                sonuc.SetError("İletisim Tip listelenirken hata oluştu.." + ex.Message);
            }
           return sonuc;
        }
    }
}
