using System;
using System.Collections.Generic;
using System.Text;
using CoreApi.DataContext.Infrastructure;
using CoreApi.Models.Core;

namespace CoreApi.Repositories.Core
{
    public interface IUploadedFileRepository: IEntityBaseRepository<UploadedFile> { }

    public class UploadedFileRepository: EntityBaseRepository<UploadedFile>, IUploadedFileRepository
    {
        public UploadedFileRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
