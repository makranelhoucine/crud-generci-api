namespace CRUD.Api.Core
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using Controllers;

    using Infrastructure.POCOs;

    using Microsoft.AspNetCore.Mvc.ApplicationParts;
    using Microsoft.AspNetCore.Mvc.Controllers;

    public class GenericTypeControllerFeatureProvider : IApplicationFeatureProvider<ControllerFeature>
    {
        public void PopulateFeature(IEnumerable<ApplicationPart> parts, ControllerFeature feature)
        {
            var entityType = typeof(IEntity<>);
            var exportedTypes = entityType.Assembly.ExportedTypes;
            var candidates = exportedTypes.Where(type => type.IsClass).Select(
                type => new
                            {
                                IdType = type
                                         .GetInterfaces()
                                         .SingleOrDefault(
                                             interfaceType =>
                                                 interfaceType.Name.Contains(entityType.Name))?.GenericTypeArguments[0],
                                OriginalType = type
                            });


            foreach (var candidate in candidates.Where(c => c.IdType != null))
            {
                feature.Controllers.Add(
                    typeof(ApiController<,>)
                        .MakeGenericType(candidate.OriginalType, candidate.IdType).GetTypeInfo());
            }
        }
    }
}