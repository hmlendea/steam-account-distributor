using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using SteamAccountDistributor.Api.Models;
using SteamAccountDistributor.Core.Extensions;
using SteamAccountDistributor.Service;

//using NuciLog.Core;

namespace SteamAccountDistributor.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SteamAccountController : ControllerBase
    {
        readonly ISteamAccountService service;
        //readonly INuciLogger logger;

        public SteamAccountController(
            ISteamAccountService service)//,
            //INuciLogger logger)
        {
            this.service = service;
            //this.logger = logger;
        }

        [HttpGet("{hostname}")]
        public ActionResult<SteamAccountResponse> GetAccount(string hostname)
        {
            SteamAccountResponse response = service.GetAccount(hostname);

            return response;
        }
    }
}
