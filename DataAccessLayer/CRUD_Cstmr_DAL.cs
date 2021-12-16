using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessEntity;

namespace DataAccessLayer
{
    public class CRUD_Cstmr_DAL
    {
        //CRUD : Create - Read - Delete - update
        Database db = new Database();

        public bool Read(CRUD_Cstmr c) // Exist
        {
            return db.CRUD_Cstmrs.Any(i => i.cstmrid == c.cstmrid && i.natnlid == c.natnlid);
        }

        public string Create(CRUD_Cstmr c) //for creating objects in database
        {
            if(!Read(c))
            {
                if (c.natnlid.Length == 10)
                {
                    db.CRUD_Cstmrs.Add(c);
                    db.SaveChanges();
                    return "ثبت اطلاعات با موفقیت انجام شد";
                }
                else
                {
                    return "کد ملی باید ده رقم باشد";
                }
            }
            else
            {
                return "اطلاعات وارد شده تکراری است";
            }
        }

        public List<CRUD_Cstmr> Read(string ifExist) // Search
        {
            return db.CRUD_Cstmrs.Where(i=> i.name.Contains(ifExist) && i.family.Contains(ifExist) && i.cstmrid.Contains(ifExist) && i.mobile.Contains(ifExist)
            && i.natnlid.Contains(ifExist) && i.phone.Contains(ifExist) && i.how.Contains(ifExist) && i.prdctname.Contains(ifExist) && i.cmpnyname.Contains(ifExist)
            && i.price.Contains(ifExist) && i.dscrptn.Contains(ifExist)).ToList();
        }

        public List<CRUD_Cstmr> Read() // Read All, For adding to dgv
        {
            return db.CRUD_Cstmrs.ToList();
        }

        public CRUD_Cstmr Read(int id) //Read by id for update and delete
        {
            return db.CRUD_Cstmrs.Where(i=>i.id == id).Single();
        }

        public string Update(int id ,CRUD_Cstmr cnew)
        {
            CRUD_Cstmr c = new CRUD_Cstmr();
            c = Read(id);
            c.name = cnew.name;
            c.family = cnew.family;
            c.cstmrid = cnew.cstmrid;
            c.mobile = cnew.mobile;
            c.natnlid= cnew.natnlid;
            c.phone = cnew.phone;
            c.how = cnew.how;
            c.prdctname = cnew.prdctname;
            c.cmpnyname = cnew.cmpnyname;
            c.price = cnew.price;
            c.dscrptn = cnew.dscrptn;
            db.SaveChanges();
            return "ویرایش اطلاعات با موفقیت انجام شد";
        }

        public string Delete(int id)
        {
            CRUD_Cstmr c = new CRUD_Cstmr();
            db.CRUD_Cstmrs.Remove(c);
            db.SaveChanges();
            return "حذف اطلاعات با موفقیت انجام شد";
        }
        
    }
}
