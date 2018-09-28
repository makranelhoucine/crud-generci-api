namespace CRUD.Api.Core
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.ApplicationModels;

    public class GenericControllerRouteConvention : IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            if (controller.ControllerType.IsGenericType)
            {
                var genericType = controller.ControllerType.GenericTypeArguments[0];

                if (genericType != null)
                {
                    controller.Selectors.Add(
                        new SelectorModel
                            {
                                AttributeRouteModel = new AttributeRouteModel(
                                    new RouteAttribute($"api/{genericType.Name}s"))
                            });
                }
            }
        }
    }
}