using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DEmo.DAL;
using DEmo.Model;

namespace DEmo.BLL
{
    public class SearchAndViewManager
    {
        SearchAndViewGeteway searchAndViewGeteway=new SearchAndViewGeteway();
        public List<Company> GetAllCompany()
        {
            return searchAndViewGeteway.GetAllCompany();

        }

        public List<Category> GetAllCategory()
        {
            return searchAndViewGeteway.GetAllCategory();
        }

        public List<SearchAndView> GetSearchResult(int companyID, int categoryId)
        {
            return searchAndViewGeteway.GetSearchResult(companyID, categoryId);
        }
    }
}