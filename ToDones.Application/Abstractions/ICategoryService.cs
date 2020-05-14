using System;
using System.Collections.Generic;
using System.Text;
using ToDones.Data.Types;

namespace ToDones.Application.Abstractions
{
    interface ICategoryService
    {
        void AddCategory(string name, int userId, CategoryColour colour);
        void RemoveCategory(int categoryId);
        void AssignCategoryToTask(int taskId, int categoryId);
    }
}
