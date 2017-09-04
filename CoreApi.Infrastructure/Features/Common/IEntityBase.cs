using System;
using CoreApi.Infrastructure.Features.Order;

namespace CoreApi.Infrastructure.Features.Common
{
    public interface IEntityBase : IOrder
    {
        int Id { get; set; }
        DateTime CreateTime { get; set; }
        DateTime UpdateTime { get; set; }
        string CreateUser { get; set; }
        string UpdateUser { get; set; }
        string LastAction { get; set; }
    }
}
