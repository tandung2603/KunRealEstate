using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using KunBlog.Contracts.Dto;
using KunBlog.Contracts.ServiceInterface;
using KunBlog.Database.Context;
using Microsoft.EntityFrameworkCore;

namespace KunBlog.Business
{
    public class PropertyService : BaseService, IPropertyService
    {
        private readonly ApplicationDBContext _ctx;
        private readonly IMapper _mapper;

        public PropertyService(ApplicationDBContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        public Task<List<PropertyDto>> GetListProperties(string search)
        {
            //var data = _ctx.Properties.Include(x => x.PropertyImage).ToList();
            var data = new List<PropertyEntity>()
            {
                new PropertyEntity()
                {
                    Id = new System.Guid(),
                    Name = "Property 1",
                    Price = 50000,
                    Description = "Descriptions Proerty 1",
                    Sale = 10,
                    Area = 64.5M,
                    Bathroom = 2,
                    Bedroom = 1
                },
                new PropertyEntity()
                {
                    Id = new System.Guid(),
                    Name = "Property 2",
                    Price = 60000,
                    Description = "Descriptions Proerty 2",
                    Sale = 10,
                    Area = 64.5M,
                    Bathroom = 2,
                    Bedroom = 1
                },
            };

            return Task.FromResult(_mapper.Map<List<PropertyEntity>, List<PropertyDto>>(data));
        }
    }
}
