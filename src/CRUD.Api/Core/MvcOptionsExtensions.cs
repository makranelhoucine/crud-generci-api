namespace Microsoft.Extensions.DependencyInjection
{
    using CRUD.Api.Core;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.DependencyInjection;

    public static class MvcOptionsExtensions
    {
        public static void ConfigureGenericApi(this MvcOptions mvcOptions)
        {
            mvcOptions.Conventions.Add(new GenericControllerRouteConvention());
        }
    }
}