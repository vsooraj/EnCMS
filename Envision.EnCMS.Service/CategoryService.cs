using Envision.EnCMS.Data.Infrastructure.Repositories.Abstract;
using Envision.EnCMS.Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace Envision.EnCMS.Service
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetCategories(string name = null);
        Category GetCategory(int id);
        Category GetCategory(string name);
        void CreateCategory(Category category);
        void SaveCategory();
    }

    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categorysRepository;

        public CategoryService(ICategoryRepository categorysRepository)
        {
            this.categorysRepository = categorysRepository;
        }

        #region ICategoryService Members

        public IEnumerable<Category> GetCategories(string name = null)
        {
            if (string.IsNullOrEmpty(name))
                return categorysRepository.GetAll();
            else
                return categorysRepository.GetAll().Where(c => c.Name == name);
        }

        //public Category GetCategory(int id)
        //{
        //    var category = categorysRepository.GetById(id);
        //    return category;
        //}

        //public Category GetCategory(string name)
        //{
        //    var category = categorysRepository.GetCategoryByName(name);
        //    return category;
        //}

        public void CreateCategory(Category category)
        {
            categorysRepository.Add(category);
        }

        public void SaveCategory()
        {
        }

        #endregion
    }
}
