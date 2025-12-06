using AutoMapper;
using HexagonalSample.Application.DtoClasses.Orders;
using HexagonalSample.Application.DtoClasses.Requests;

namespace HexagonalSample.Application.Mappings
{
    public class OrderMappingProfile : Profile
    {
        public OrderMappingProfile()
        {
            CreateMap<CreateOrderRequest, CreateOrderCommand>();
            CreateMap<UpdateOrderRequest, UpdateOrderCommand>();
        }
    }
}
