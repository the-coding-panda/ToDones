using System.Collections.Generic;
using ToDones.Data.Models;
using ToDones.Data.Types;

namespace ToDones.Application.Abstractions
{
    public interface ICategoryService
    {
        void AddCategory(string name, int userId, CategoryColour colour);
        void RemoveCategory(int categoryId);
        void AssignCategoryToTask(int taskId, int categoryId);
        List<Category> GetCategories(int userId);

    }
}
