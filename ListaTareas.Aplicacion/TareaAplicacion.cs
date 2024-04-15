using AutoMapper;
using ListaTareas.Model.Models;
using ListaTareas.Repo;

namespace ListaTareas.Aplicacion
{
    public class TareaAplicacion: ITareaAplicacion
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TareaAplicacion(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> AddTarea(TareaDTO tareaDTO)
        {
            try
            {
                var tarea = _mapper.Map<Tarea>(tareaDTO);
                var response = await _unitOfWork.TareaRepo.AddTarea(tarea);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteTarea(int idTarea)
        {
            try
            {
                var response = await _unitOfWork.TareaRepo.DeleteTarea(idTarea);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> EditStateTarea(int idTarea)
        {
            try
            {
                var response = await _unitOfWork.TareaRepo.EditStateTarea(idTarea);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<IEnumerable<Tarea>> GetTareas()
        {
            List<Tarea> response = [];

            try
            {
                response = (List<Tarea>)await _unitOfWork.TareaRepo.GetTareas();
                return response;
            }
            catch
            {
                return response;
            }
        }
    }
}
