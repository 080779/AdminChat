﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Service.Entities
{
    /// <summary>
    /// 权限项实体类
    /// </summary>
    public class PermissionEntity : BaseEntity
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public virtual ICollection<RoleEntity> Roles { get; set; } = new List<RoleEntity>();
    }
}
