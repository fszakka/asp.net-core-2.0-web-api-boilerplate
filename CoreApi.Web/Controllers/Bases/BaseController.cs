using System;
using CoreApi.DataContext.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CoreApi.Web.Controllers.Bases
{
    public abstract class BaseController : Controller
    {
        protected readonly IUnitOfWork UnitOfWork;
        protected readonly ILogger Logger;

        protected BaseController(
            IUnitOfWork unitOfWork,
            ILogger logger)
        {
            UnitOfWork = unitOfWork;
            Logger = logger;
        }

        #region Current Information

        protected DateTime Now => DateTime.Now;
        protected string UserName => User.Identity.Name ?? "Anonymous";

        #endregion
        
    }
}