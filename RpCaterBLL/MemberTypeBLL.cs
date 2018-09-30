using RpCater.DAL;
using RpCater.model;
using System.Collections.Generic;
using System.Data;

namespace RpCater.BLL
{
    public class MemberTypeBLL
    {
        public int add(MemberType model)
        {
            return new MemberTypeDAL().add(model);
        }

        public int delete(int id)
        {
            return new MemberTypeDAL().delete(id);
        }

        public MemberType get(int id)
        {
            return new MemberTypeDAL().get(id);
        }

        public IEnumerable<MemberType> getAll()
        {
            return new MemberTypeDAL().getAll();
        }

        public MemberType toModel(DataRow dr)
        {
            return new MemberTypeDAL().toModel(dr);
        }

        public int update(MemberType model)
        {
            return new MemberTypeDAL().update(model);
        }
    }
}