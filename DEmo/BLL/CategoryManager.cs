using System.Collections.Generic;
using System.Web.Services.Description;



namespace DEmo.BLL
{
    public class CategoryManager
    {
        CategoryGateway categoryGateway=new CategoryGateway();

        public string saveCategory(Category category)
        {
            
            Category aCategory = categoryGateway.IsExist(category);
            if (aCategory==null)
            {
                int rowsAffected = categoryGateway.SaveCategory(category);

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
                return "Not Uniq";
            }
           
        }


        public List<Category> GetAllCategory()
        {
            return categoryGateway.GetAllCategories();
        }


    }
}