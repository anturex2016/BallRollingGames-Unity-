using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DEmo.Model;
using DEmo.DAL;

namespace DEmo.BLL
{
    public class CompanyManager
    {
        CompanyGeteway companyGeteway=new CompanyGeteway();





        public string saveCompany(Company company)
        {
            Company aCompany = companyGeteway.IsExist(company);
            if (aCompany==null)
            {
                int rowsAffected = companyGeteway.SaveCompany(company);
                if (rowsAffected > 0)
                {
                    return "Saved Successful";

                }
                else
                {
                    return "Saved Failed";
                }
                               
            }
            else
            {
                return "Not uniq";
            }
        
        }


        public List<Company> GetAllCompany()
        {
            return companyGeteway.GetAllCompany();
        }


    }
}