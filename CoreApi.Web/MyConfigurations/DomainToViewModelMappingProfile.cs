using AutoMapper;
using CoreApi.Models.Core;
using CoreApi.ViewModels.Core;

namespace CoreApi.Web.MyConfigurations
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName => "DomainToViewModelMappings";

        public DomainToViewModelMappingProfile()
        {
            CreateMap<UploadedFile, UploadedFileViewModel>();
        }
    }
}