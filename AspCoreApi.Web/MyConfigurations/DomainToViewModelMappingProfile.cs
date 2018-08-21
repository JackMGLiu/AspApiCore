using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspCoreApi.Models.Angular;
using AspCoreApi.ViewModels.Angular;
using AutoMapper;

namespace AspCoreApi.Web.MyConfigurations
{
    public class DomainToViewModelMappingProfile: Profile
    {
        public override string ProfileName => "DomainToViewModelMappings";

        public DomainToViewModelMappingProfile()
        {
            CreateMap<Client, ClientViewModel>();
            CreateMap<Client, ClientModificationViewModel>();
            CreateMap<ClientModificationViewModel, Client>();
        }
    }
}
