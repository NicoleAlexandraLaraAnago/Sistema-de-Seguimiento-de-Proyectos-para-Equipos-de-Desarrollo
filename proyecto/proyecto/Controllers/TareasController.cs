using Microsoft.AspNetCore.Mvc;
using proyecto.Context;
using proyecto.Model.DTO;
using proyecto.Model;

[Route("api/[controller]")]
[ApiController]
public class TareasController : ControllerBase
{
    private readonly AppDbContext DbContext;

    public TareasController(AppDbContext context)
    {
        DbContext = context;
    }

    [HttpPost]
    public async Task<ActionResult<Tarea>> CreateTarea(CreateTareaRequestDto request)
    {
        var tarea = new Tarea
        {
            NombreTarea = request.NombreTarea,
            NombreEquipo = request.NombreEquipo,
            DescripcionTarea = request.DescripcionTarea,
            Estado = request.Estado,
            FechaInicio = request.FechaInicio,
            FechaFin = request.FechaFin
        };

        await DbContext.Tareas.AddAsync(tarea);
        await DbContext.SaveChangesAsync();

        return Ok();
    }
    [HttpGet]
public ActionResult<IEnumerable<Tarea>> GetTareas()
{
    var tareas = DbContext.Tareas.ToList();
    return Ok(tareas);
}

}
