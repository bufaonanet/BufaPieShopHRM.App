using BufaPieShopHRM.Shared.Domain;

namespace BufaPieShopHRM.App.Services;

public interface IJobCategoryDataService
{
    Task<IEnumerable<JobCategory>> GetAllJobCategories();
    Task<JobCategory> GetJobCategoryById(int jobCategoryId);
}