using Chat.IService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat.DTO.DTO;
using Chat.Service.Entities;

namespace Chat.Service.Service
{
    public class RoleService : IRoleService
    {
        public long AddNew(string roleName)
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                CommonService<RoleEntity> cs = new CommonService<RoleEntity>(dbc);
                if(cs.GetAll().Any(r=>r.Name==roleName))
                {
                    return -1;
                }
                RoleEntity role = new RoleEntity();
                role.Name = roleName;
                dbc.Roles.Add(role);
                dbc.SaveChanges();
                return role.Id;
            }
        }

        public void AddRoleIds(long adminUserId, long[] roleIds)
        {
            throw new NotImplementedException();
        }

        public RoleDTO[] GetAll()
        {
            throw new NotImplementedException();
        }

        public RoleDTO[] GetByAdminUserId(long adminUserId)
        {
            throw new NotImplementedException();
        }

        public RoleDTO GetById(long id)
        {
            throw new NotImplementedException();
        }

        public RoleDTO GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool MarkDeleted(long roleId)
        {
            throw new NotImplementedException();
        }

        public void Update(long roleId, string roleName)
        {
            throw new NotImplementedException();
        }

        public void UpdateRoleIds(long adminUserId, long[] roleIds)
        {
            throw new NotImplementedException();
        }
    }
}
