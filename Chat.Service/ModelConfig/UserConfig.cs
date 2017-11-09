using Chat.Service.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Service.ModelConfig
{
    class UserConfig:EntityTypeConfiguration<UserEntity>
    {
        public class a
        {
            public string Name { get; set; }
            public string NickName { get; set; }
            public string PhotoUrl { get; set; }
            public string Mobile { get; set; }
            public bool Gender { get; set; }
            public string Address { get; set; }
        }
        public UserConfig()
        {

            ToTable("T_Users");
            //Property(u => u.Name).HasMaxLength(20).IsRequired().IsUnicode(false);

            Property(u => u.Name).HasMaxLength(50).IsRequired();
            Property(u => u.NickName).HasMaxLength(100).IsRequired();
            Property(u => u.PhotoUrl).HasMaxLength(1024).IsRequired();
            Property(u => u.Mobile).HasMaxLength(100).IsRequired();
            Property(u => u.Gender).IsRequired();
            Property(u => u.Address).HasMaxLength(1024).IsRequired();
        }
    }
}
