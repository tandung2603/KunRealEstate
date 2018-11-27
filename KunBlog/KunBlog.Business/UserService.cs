using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using KunBlog.Contracts.Dto;
using KunBlog.Contracts.ServiceInterface;
using KunBlog.Database.Context;

namespace KunBlog.Business
{
    public class UserService : IUserService
    {
        private readonly ApplicationDBContext _ctx;
        private readonly IMapper _mapper;

        public UserService(ApplicationDBContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        public SaveResultDto AddUserProfile(UserProfileDto user)
        {
            var entity = _mapper.Map<UserProfileDto, UserProfileEntity>(user);
            _ctx.UserProfiles.Attach(entity);

            _ctx.SaveChanges();

            return new SaveResultDto
            {
                IsSuccess = true,
                Id = entity.Id
            };
        }

        public UserProfileDto Get(string userName)
        {
            var data = _ctx.UserProfiles.FirstOrDefault(p => p.Email == userName);

            if (data == null) return null;

            var result = _mapper.Map<UserProfileEntity, UserProfileDto>(data);

            return result;
        }

        public List<UserProfileDto> GetAll()
        {
            var data = _ctx.UserProfiles.ToList();

            return _mapper.Map<List<UserProfileEntity>, List<UserProfileDto>>(data);
        }
    }
}
