using BufaPieShopHRM.Shared.Domain;

namespace BufaPieShopHRM.Api.Data.Repositories;

public interface ICountryRepository
{
    IEnumerable<Country> GetAllCountries();
    Country GetCountryById(int countryId);
}