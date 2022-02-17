using Microsoft.AspNetCore.Mvc;
using Rise_Tech_Rehber.Service.Model.IletisimBilgileri;
using Rise_Tech_Rehber.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiseTech_Rehber_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IletisimController : Controller
    {
        private readonly IletisimBilgileriService iletisimService;
        public IletisimController(IletisimBilgileriService _iletisimService)
        {
            iletisimService = _iletisimService;
        }


        [HttpPost(nameof(IletisimBilgileriKaydetSil))]
        public IActionResult IletisimBilgileriKaydetSil([FromBody] IletisimBilgileriRequest request)
        {
            var response = iletisimService.IletisimBilgileriKaydetSil(request);
            return new JsonResult(response);
        }
        [HttpGet(nameof(KisiIletisimBilgileriGetir))]
        public IActionResult KisiIletisimBilgileriGetir(int uu_id)
        {
            var response = iletisimService.IletisimBilgileriDetay(uu_id);
            return new JsonResult(response);
        }

    }
}
