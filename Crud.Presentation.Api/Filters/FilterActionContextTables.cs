using Crud.Infraestructure.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Crud.Presentation.Api.Filters;

public class FilterActionContextTables<T> : IAsyncActionFilter where T : class, IEntity
{
    //private readonly IServiceDirectory serviceDirectory;
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        if (!context.ModelState.IsValid)
            context.Result = new BadRequestObjectResult("É obrigatório informar o JSON para gerar o app.");

        try
        {
            dynamic? obj = null;
            context.ActionArguments.TryGetValue("metadata", out obj);
            var scriptMetadata = obj?.ScriptMetadata;
            // here save all actributes in the metadata in base 64.
        }
        catch (Exception ex)
        {
            context.Result = new BadRequestObjectResult(ex.Message);
        }

        await next();
    }
}