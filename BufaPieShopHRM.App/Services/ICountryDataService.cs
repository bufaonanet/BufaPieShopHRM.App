using BufaPieShopHRM.Shared.Domain;

namespace BufaPieShopHRM.App.Services;

public interface ICountryDataService
{
    Task<IEnumerable<Country>> GetAllCountries();
    Task<Country> GetCountryById(int countryId);
}