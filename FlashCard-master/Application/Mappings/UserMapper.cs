using System.Collections.Generic;
using Application.DTO;
using Domain.Entities;

namespace Application.Mappings
{
    public static class UserMapper
    {
        public static UserDto MappingDto(this User user)
        {
            return new UserDto
            {
                ID = user.ID,
                tagname = user.tagname,
                email = user.email,
                contry = user.contry,
                avatar = user.avatar
            };
        }

        public static User MappingUser(this UserDto userDto)
        {
            return new User
            {
                ID = userDto.ID,
                tagname = userDto.tagname,
                email = userDto.email,
                contry = userDto.contry,
                avatar = userDto.avatar
            };
        }

        public static void MappingUser(this UserDto userDto, User user)
        {
            user.ID = userDto.ID;
            user.tagname = userDto.tagname;
            user.email = userDto.email;
            user.contry = userDto.contry;
            user.avatar = userDto.avatar;
        }

        public static IEnumerable<UserDto> MappingDto(this IEnumerable<User> users)
        {
            foreach (var user in users)
            {
                yield return user.MappingDto();
            }
        }

    }
}
