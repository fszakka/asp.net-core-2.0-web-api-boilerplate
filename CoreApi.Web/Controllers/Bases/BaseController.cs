using System;
using CoreApi.DataContext.Infrastructure;
using CoreApi.Services.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;

namespace CoreApi.Web.Controllers.Bases
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