using System.Linq;
using ToDones.Application.Abstractions;
using ToDones.Data.Data;
using ToDones.Data.Models;
using ToDones.Data.Types;

namespace ToDones.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ToDonesContext _dbContext;

        public CategoryService()
        {
            _dbContext = new ToDonesContext();
        }

        public void AddCategory(string name, int userId, CategoryColour colour)
        {
            _dbContext.Categories.Add(new Category
            {
                Name = name,
                Color = colour.ToString(),
                UserId = userId
            });

            _dbContext.SaveChanges();
        }

        public void AssignCategoryToTask(int taskId, int categoryId)
        {
            _dbContext.CategoryTasks.Add(new CategoryTask
            {
                TaskId = taskId,
                CategoryId = categoryId
            });

            _dbContext.SaveChanges();
        }

        public void RemoveCategory(int categoryId)
        {
            var category = _dbContext.Categories.FirstOrDefault(r => r.Id == categoryId);
            _dbContext.Categories.Remove(category);

            _dbContext.SaveChanges();
        }
    }
}
