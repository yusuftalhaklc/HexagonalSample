using AutoMapper;
using HexagonalSample.Application.DtoClasses.OrderDetails;
using HexagonalSample.Application.DtoClasses.Requests;

namespace HexagonalSample.Application.Mappings
{
    public class OrderDetailMappingProfile : Profile
    {
        public OrderDetailMappingProfile()
        {
            CreateMap<CreateOrderDetailRequest, CreateOrderDetailCommand>();
            CreateMap<UpdateOrderDetailRequest, UpdateOrderDetailCommand>();
        }
    }
}
