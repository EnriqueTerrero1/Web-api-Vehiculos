using AutoMapper;
using CarroCRUD.DTO;
using CarroCRUD.Entidades;

namespace CarroCRUD.Utilidades
{
    public class AutoMapperProfiles:Profile
    {

        public AutoMapperProfiles()
        {
            CreateMap<MarcaDTO, Marca>().ReverseMap();
            CreateMap<MarcaCreacionDTO, Marca>().ReverseMap();
            CreateMap<CarroDTO, Carro>().ReverseMap();
            CreateMap<CarroCreacionDTO, Carro>().ReverseMap();


        }



    }
}
