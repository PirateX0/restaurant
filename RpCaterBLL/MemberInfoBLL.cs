using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using RpCater.DAL;
using RpCater.Model;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace RpCater.BLL
{
    public class MemberInfoBLL
    {
        private MemberInfoDAL dal = new MemberInfoDAL();

        public bool CanImportExcel(string fileName)
        {
            List<MemberInfo> memberList = GetMemberListFromExcel(fileName);
            dal.AddMemberListUsingTransaction(memberList);
            return true;
        }

        public bool CanExportToExcel(int delFlag, string fileName)
        {
            List<MemberInfo> memberList = GetAllMemberInfoByDelFlag(delFlag);
            using (FileStream writeStream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                HSSFWorkbook book = new HSSFWorkbook();
                ISheet sheet = book.CreateSheet();

                IRow rowHead = sheet.CreateRow(0);
                ICell nameCellHead = rowHead.CreateCell(0, CellType.String);
                nameCellHead.SetCellValue("会员姓名");
                ICell phoneCellHead = rowHead.CreateCell(1, CellType.String);
                phoneCellHead.SetCellValue("会员电话");
                ICell addressCellHead = rowHead.CreateCell(2, CellType.String);
                addressCellHead.SetCellValue("会员地址");
                ICell genderCellHead = rowHead.CreateCell(3, CellType.String);
                genderCellHead.SetCellValue("会员性别");
                ICell moneyCellHead = rowHead.CreateCell(4, CellType.String);
                moneyCellHead.SetCellValue("会员余额");

                for (int i = 0; i < memberList.Count; i++)
                {
                    IRow row = sheet.CreateRow(i + 1);
                    ICell nameCell = row.CreateCell(0, CellType.String);
                    nameCell.SetCellValue(memberList[i].MemName);
                    ICell phoneCell = row.CreateCell(1, CellType.String);
                    phoneCell.SetCellValue(memberList[i].MemMobilePhone);
                    ICell addressCell = row.CreateCell(2, CellType.String);
                    addressCell.SetCellValue(memberList[i].MemAddress);
                    ICell genderCell = row.CreateCell(3, CellType.String);
                    genderCell.SetCellValue(memberList[i].MemGender);
                    ICell moneyCell = row.CreateCell(4, CellType.Numeric);
                    moneyCell.SetCellValue(memberList[i].MemMoney);
                }

                book.Write(writeStream);
            }
            return true;
        }

        public bool AddOrUpdateMemberInfo(MemberInfo member, HandleStatus status)
        {
            return dal.AddOrUpdateMemberInfo(member, status) > 0;
        }

        public List<MemberInfo> GetAllMemberInfoByDelFlag(int delFlag)
        {
            return dal.GetAllMemberInfoByDelFlag(delFlag);
        }

        public MemberInfo GetMemberInfoById(int id)
        {
            return dal.GetMemberInfoById(id);
        }

        public DataTable GetMemberInfoDataTableByDelFlag(int delFlag)
        {
            return dal.GetMemberInfoDataTableByDelFlag(delFlag);
        }

        public DataTable GetMemberInfoDataTableLikeMemName(string memName)
        {
            return dal.GetMemberInfoDataTableLikeMemName(memName);
        }

        public List<MemberInfo> GetMemberInfoLikeMemName(string memName)
        {
            return dal.GetMemberInfoLikeMemName(memName);
        }

        public bool SoftDeleteMemberInfo(int id, int delFlag)
        {
            return dal.SoftDeleteMemberInfo(id, delFlag) > 0 ? true : false;
        }

        private static List<MemberInfo> GetMemberListFromExcel(string fileName)
        {
            List<MemberInfo> memberList = new List<MemberInfo>();
            using (Stream readStream = File.OpenRead(fileName))
            {
                IWorkbook book = WorkbookFactory.Create(readStream);
                ISheet sheet = book.GetSheetAt(0);
                //i=0是表头，不插入数据库
                for (int i = 1; i <= sheet.LastRowNum; i++)
                {
                    IRow row = sheet.GetRow(i);
                    MemberInfo member = new MemberInfo();
                    member.MemName = row.GetCell(0).StringCellValue;
                    member.MemMobilePhone = row.GetCell(1).StringCellValue;
                    member.MemAddress = row.GetCell(2).StringCellValue;
                    member.MemGender = row.GetCell(3).StringCellValue;
                    member.MemMoney = (float)row.GetCell(4).NumericCellValue;
                    memberList.Add(member);
                }
            }
            return memberList;
        }
    }
}