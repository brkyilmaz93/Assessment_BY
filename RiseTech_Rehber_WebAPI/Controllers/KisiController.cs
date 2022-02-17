using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Rise_Tech_Rehber.Service.Model.Kisi;
using Rise_Tech_Rehber.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiseTech_Rehber_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KisiController : Controller
    {

        private readonly KisiService kisiService;
        public KisiController(KisiService _kisiService)
        {
            kisiService = _kisiService;
        }
        [AllowAnonymous]
        [HttpPost(nameof(KisiKaydetGuncelleSil))]
        public IActionResult KisiKaydetGuncelleSil([FromBody]KisiRequest request)
        {
            var response = kisiService.KisiKaydetGuncelleSil(request);
            return new JsonResult(response);
        } 
        [HttpGet(nameof(KisileriGetir))]
        public ActionResult KisileriGetir()
        {
            var response = kisiService.KisileriGetir();
            return new JsonResult(response);
        }


    }
}
