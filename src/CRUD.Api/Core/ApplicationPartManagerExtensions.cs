namespace Microsoft.Extensions.DependencyInjection
{
    using CRUD.Api.Core;

    using Microsoft.AspNetCore.Mvc.ApplicationParts;

    public static class ApplicationPartManagerExtensions
    {
        public static void ConfigureGenericFeature(this ApplicationPartManager applicationPartManager)
        {
            applicationPartManager.FeatureProviders.Add(new GenericTypeControllerFeatureProvider());
        }
    }
}