using AutoMapper;
using vega.Models;
using vega.Controllers.Resources;

namespace vega_angular_dotnet.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResource>();
        }
    }
}