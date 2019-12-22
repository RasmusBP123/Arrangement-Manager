using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Reflection;

namespace Group15.EventManager.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(config =>
            {
                config.AddProfile(new DomainToViewModelProfile());
                config.AddProfile(new ViewModelToDomainProfile());
            });
        }
    }

    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services, params Assembly[] assemblies)
        {
            var config = AutoMapperConfig.RegisterMappings();
            var mapper = config.CreateMapper();

            IEnumerable<Profile> profiles = new List<Profile>() { new DomainToViewModelProfile(), new ViewModelToDomainProfile() };
            services.AddAutoMapper(config => config.AddProfiles(profiles), assemblies);
        }
    }
}
