﻿using Microsoft.AspNetCore.Mvc;
using Com.Shamiraa.Service.Core.Lib.Services;
using Com.Shamiraa.Service.Core.Lib.Models;
using Com.Shamiraa.Service.Core.WebApi.Helpers;
using Com.Shamiraa.Service.Core.Lib.ViewModels;
using Com.Shamiraa.Service.Core.Lib;

namespace Com.Shamiraa.Service.Core.WebApi.Controllers.v1.BasicControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/buyers")]
    public class BuyersController : BasicController<BuyerService, Buyer, BuyerViewModel, CoreDbContext>
    {
        private new static readonly string ApiVersion = "1.0";

        public BuyersController(BuyerService service) : base(service, ApiVersion)
        {
        }
    }
}
