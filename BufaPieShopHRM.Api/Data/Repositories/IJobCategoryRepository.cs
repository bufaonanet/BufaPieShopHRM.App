using BufaPieShopHRM.Shared.Domain;

namespace BufaPieShopHRM.Api.Data.Repositories;

public interface IJobCategoryRepository
{
    IEnumerable<JobCategory> GetAllJobCategories();
    JobCategory GetJobCategoryById(int jobCategoryId);
}
