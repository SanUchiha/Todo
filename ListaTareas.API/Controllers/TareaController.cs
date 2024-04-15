using ListaTareas.Aplicacion;
using Microsoft.AspNetCore.Mvc;

namespace ListaTareas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase
    {
        private readonly ITareaAplicacion _aplicacion;

        public TareaController(ITareaAplicacion aplicacion)
        {
            _aplicacion = aplicacion;
        }

        // GET: api/Tarea
        [HttpGet]
        public async Task<ActionResult> GetTareas()
        {

            try
            {
                var response = await _aplicacion.GetTareas();
                return Ok(response);
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return BadRequest(ex.ToString());
            }
   
        }

        // PUT: api/Tarea/ModificarEstado/X
        [HttpPut("ModificarEstado/{id}")]
        public async Task<IActionResult> PutTarea(int id)
        {
            try
            {
                await _aplicacion.EditStateTarea(id);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }

        }

        // POST: api/Tarea
        [HttpPost]
        public async Task<ActionResult> PostTarea(TareaDTO tareaDTO)
        {
            try
            {
                await _aplicacion.AddTarea(tareaDTO);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }

        // DELETE: api/Tarea/X
        [HttpDelete("{idTarea}")]
        public async Task<IActionResult> DeleteTarea(int idTarea)
        {
            try
            {
                await _aplicacion.DeleteTarea(idTarea);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}
