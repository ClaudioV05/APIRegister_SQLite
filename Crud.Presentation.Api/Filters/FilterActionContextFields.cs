using Crud.Infraestructure.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Crud.Presentation.Api.Filters;

public class FilterActionContextFields<T> : IAsyncActionFilter where T : class, IEntity
{
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        if (!context.ModelState.IsValid)
            context.Result = new BadRequestObjectResult("É obrigatório informar o JSON para gerar o app.");

        await next();
    }
}