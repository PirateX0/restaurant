using RpCater.DAL;
using RpCater.model;
using System.Collections.Generic;
using System.Data;

namespace RpCater.BLL
{
    public class RoomInfoBLL
    {
        public int add(RoomInfo model)
        {
            return new RoomInfoDAL().add(model);
        }

        public int delete(int id)
        {
            return new RoomInfoDAL().delete(id);
        }

        public RoomInfo get(int id)
        {
            return new RoomInfoDAL().get(id);
        }

        public IEnumerable<RoomInfo> getAll()
        {
            return new RoomInfoDAL().getAll();
        }

        public List<RoomInfo> GetAllRoomInfoByDelFlag(int delFlag)
        {
            return new RoomInfoDAL().GetAllRoomInfoByDelFlag(delFlag);
        }

        public int SoftDelete(int id)
        {
            return new RoomInfoDAL().SoftDelete(id);
        }

        public RoomInfo toModel(DataRow dr)
        {
            return new RoomInfoDAL().toModel(dr);
        }

        public int update(RoomInfo model)
        {
            return new RoomInfoDAL().update(model);
        }
    }
}