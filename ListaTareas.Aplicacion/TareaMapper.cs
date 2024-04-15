using AutoMapper;
using ListaTareas.Model.Models;

namespace ListaTareas.Aplicacion
{
    public class TareaMapper : Profile
    {
    
        public TareaMapper() 
        {

            CreateMap<TareaDTO, Tarea>().ReverseMap();
        
        }
    
    }
}
