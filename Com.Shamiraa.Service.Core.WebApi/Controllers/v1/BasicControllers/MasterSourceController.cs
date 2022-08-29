﻿using System;
using Com.Shamiraa.Service.Core.Lib;
using Com.Shamiraa.Service.Core.Lib.Models;
using Com.Shamiraa.Service.Core.Lib.Services;
using Com.Shamiraa.Service.Core.Lib.ViewModels;
using Com.Shamiraa.Service.Core.WebApi.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Com.Shamiraa.Service.Core.WebApi.Controllers.v1.BasicControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/source")]
    public class MasterSourceController : BasicController<MasterSourceService, MasterSource, MasterSourceViewModel, CoreDbContext>
    {
        private new static readonly string ApiVersion = "1.0";
        public MasterSourceController(MasterSourceService service) : base(service, ApiVersion)
        {
        }
    }
}
