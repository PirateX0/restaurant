using RpCater.DAL;
using RpCater.model;
using System.Collections.Generic;
using System.Data;

namespace RpCater.BLL
{
    public class DeskInfoBLL
    {
        public int add(DeskInfo model)
        {
            return new DeskInfoDAL().add(model);
        }

        public int delete(int id)
        {
            return new DeskInfoDAL().delete(id);
        }

        public DeskInfo get(int id)
        {
            return new DeskInfoDAL().get(id);
        }

        public int GetAliveDeskCountByRoomId(int roomId)
        {
            return new DeskInfoDAL().GetAliveDeskCountByRoomId(roomId);
        }

        public IEnumerable<DeskInfo> getAll()
        {
            return new DeskInfoDAL().getAll();
        }

        public List<DeskInfo> GetAllAliveDeskInfoByRoomId(int roomId)
        {
            return new DeskInfoDAL().GetAllAliveDeskInfoByRoomId(roomId);
        }

        public List<DeskInfo> GetAllDeskInfoByDelFlag(int delFlag)
        {
            return new DeskInfoDAL().GetAllDeskInfoByDelFlag(delFlag);
        }

        public int SoftDelete(int id)
        {
            return new DeskInfoDAL().SoftDelete(id);
        }

        public DeskInfo toModel(DataRow dr)
        {
            return new DeskInfoDAL().toModel(dr);
        }

        public int update(DeskInfo model)
        {
            return new DeskInfoDAL().update(model);
        }

        /// <summary>
        /// �ı����״̬
        /// </summary>
        /// <param name="deskId"></param>
        /// <param name="state">0��ʾ���У�1��ʾ�Ͳ�</param>
        /// <returns></returns>
        public bool UpdateDeskInfoStateByDeskIdAndState(int deskId, int state)
        {
            return new DeskInfoDAL().UpdateDeskInfoStateByDeskIdAndState(deskId, state) > 0;
        }
    }
}