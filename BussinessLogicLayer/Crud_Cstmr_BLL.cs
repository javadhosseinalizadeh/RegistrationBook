using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessEntity;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class Crud_Cstmr_BLL
    {
        CRUD_Cstmr_DAL dal = new CRUD_Cstmr_DAL();

        public string Create(CRUD_Cstmr c)
        {
            return dal.Create(c);
        }

        public List<CRUD_Cstmr> Read(string ifExist) //search
        {
            return dal.Read(ifExist);
        }

        public CRUD_Cstmr Read(int id)
        {
            return dal.Read(id);
        }

        public List <CRUD_Cstmr> Read() //Read all
        {
            return dal.Read();
        }

        public string Update(int id , CRUD_Cstmr cnew)
        {
            return dal.Update(id, cnew);
        }

        public string Delete(int id)
        {
            return dal.Delete(id);
        }
    }
}
