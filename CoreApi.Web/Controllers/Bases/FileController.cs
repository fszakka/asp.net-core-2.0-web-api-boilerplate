using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi.DataContext.Infrastructure;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;

namespace CoreApi.Web.Controllers.Bases
{
    public class FileController : BaseController
    {
        protected readonly IFileProvider FileProvider;

        public FileController(
            IUnitOfWork unitOfWork,
            ILogger logger,
            IFileProvider fileProvider) :
            base(unitOfWork, logger)
        {
            FileProvider = fileProvider;
        }
    }
}
