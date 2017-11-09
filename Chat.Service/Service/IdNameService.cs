using Chat.IService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat.DTO.DTO;
using Chat.DTO;

namespace Chat.Service.Service
{
    public class IdNameService : IIdNameService
    {
        public long AddNew(string typeName, string name, string imgUrl)
        {
            throw new NotImplementedException();
        }

        public IdNameDTO[] GetAll()
        {
            throw new NotImplementedException();
        }

        public IdNameDTO[] GetAll(string typeName)
        {
            throw new NotImplementedException();
        }

        public IdNameDTO GetById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
