using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspCoreApi.Infrastructure.Core.Interface;
using AspCoreApi.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;

namespace AspCoreApi.Web.Controllers
{
    public abstract class BaseController<T> : Controller
    {
        protected readonly IUnitOfWork UnitOfWork;
        protected readonly ILogger<T> Logger;
        protected readonly IFileProvider FileProvider;
        protected readonly ICoreService<T> CoreService;

        protected BaseController(ICoreService<T> coreService)
        {
            CoreService = coreService;
            UnitOfWork = coreService.UnitOfWork;
            Logger = coreService.Logger;
            FileProvider = coreService.FileProvider;
        }

        #region Current Information

        protected DateTime Now => DateTime.Now;
        protected string UserName => User.Identity.Name ?? "Anonymous";

        #endregion
    }
}