using System;
using System.Collections.Generic;
using System.Reflection;

namespace AutoMapper
{
    public interface IMapperConfigurationExpression : IProfileExpression
    {
        /// <summary>
        /// Create missing type maps during mapping, if necessary
        /// </summary>
        bool? CreateMissingTypeMaps { get; set; }

        /// <summary>
        /// Add an existing profile
        /// </summary>
        /// <param name="profile">Profile to add</param>
        void AddProfile(Profile profile);

        /// <summary>
        /// Add an existing profile type. Profile will be instantiated and added to the configuration.
        /// </summary>
        /// <typeparam name="TProfile">Profile type</typeparam>
        void AddProfile<TProfile>() where TProfile : Profile, new();

        /// <summary>
        /// Add an existing profile type. Profile will be instantiated and added to the configuration.
        /// </summary>
        /// <param name="profileType">Profile type</param>
        void AddProfile(Type profileType);

        /// <summary>
        /// Add profiles contained in assemblies
        /// </summary>
        /// <param name="assembliesToScan">Assemblies containing profiles</param>
        void AddProfiles(IEnumerable<Assembly> assembliesToScan);

        /// <summary>
        /// Add profiles contained in assemblies
        /// </summary>
        /// <param name="assembliesToScan">Assemblies containing profiles</param>
        void AddProfiles(params Assembly[] assembliesToScan);

        /// <summary>
        /// Add profiles contained in assemblies
        /// </summary>
        /// <param name="assemblyNamesToScan">Assembly names to load and scan containing profiles</param>
        void AddProfiles(IEnumerable<string> assemblyNamesToScan);

        /// <summary>
        /// Add profiles contained in assemblies
        /// </summary>
        /// <param name="assemblyNamesToScan">Assembly names to load and scan containing profiles</param>
        void AddProfiles(params string[] assemblyNamesToScan);

        /// <summary>
        /// Add profiles contained in assemblies
        /// </summary>
        /// <param name="typesFromAssembliesContainingProfiles">Types from assemblies containing profiles</param>
        void AddProfiles(IEnumerable<Type> typesFromAssembliesContainingProfiles);

        /// <summary>
        /// Add profiles contained in assemblies
        /// </summary>
        /// <param name="typesFromAssembliesContainingProfiles">Types from assemblies containing profiles</param>
        void AddProfiles(params Type[] typesFromAssembliesContainingProfiles);

        /// <summary>
        /// Add mapping definitions contained in assemblies
        /// </summary>
        /// <param name="assembliesToScan">Assemblies containing mapping definitions</param>
        void AddMaps(IEnumerable<Assembly> assembliesToScan);

        /// <summary>
        /// Add mapping definitions contained in assemblies
        /// </summary>
        /// <param name="assembliesToScan">Assemblies containing mapping definitions</param>
        void AddMaps(params Assembly[] assembliesToScan);

        /// <summary>
        /// Add mapping definitions contained in assemblies
        /// </summary>
        /// <param name="assemblyNamesToScan">Assembly names to load and scan containing mapping definitions</param>
        void AddMaps(IEnumerable<string> assemblyNamesToScan);

        /// <summary>
        /// Add mapping definitions contained in assemblies
        /// </summary>
        /// <param name="assemblyNamesToScan">Assembly names to load and scan containing mapping definitions</param>
        void AddMaps(params string[] assemblyNamesToScan);

        /// <summary>
        /// Add mapping definitions contained in assemblies
        /// </summary>
        /// <param name="typesFromAssembliesContainingMappingDefinitions">Types from assemblies containing mapping definitions</param>
        void AddMaps(IEnumerable<Type> typesFromAssembliesContainingMappingDefinitions);

        /// <summary>
        /// Add mapping definitions contained in assemblies
        /// </summary>
        /// <param name="typesFromAssembliesContainingMappingDefinitions">Types from assemblies containing mapping definitions</param>
        void AddMaps(params Type[] typesFromAssembliesContainingMappingDefinitions);

        /// <summary>
        /// Supply a factory method callback for creating resolvers and type converters
        /// </summary>
        /// <param name="constructor">Factory method</param>
        void ConstructServicesUsing(Func<Type, object> constructor);

        /// <summary>
        /// Create a named profile with the supplied configuration
        /// </summary>
        /// <param name="profileName">Profile name, must be unique</param>
        /// <param name="config">Profile configuration</param>
        void CreateProfile(string profileName, Action<IProfileExpression> config);

        /// <summary>
        /// Object mappers
        /// </summary>
        IList<IObjectMapper> Mappers { get; }

        /// <summary>
        /// Advance Configuration
        /// </summary>
        AdvancedConfiguration Advanced { get; }
    }
}