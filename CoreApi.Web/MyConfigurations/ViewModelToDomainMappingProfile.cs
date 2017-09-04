using AutoMapper;
using CoreApi.Models.Core;
using CoreApi.ViewModels.Core;

namespace CoreApi.Web.MyConfigurations
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName => "ViewModelToDomainMappings";

        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UploadedFileViewModel, UploadedFile>();
        }
    }
}