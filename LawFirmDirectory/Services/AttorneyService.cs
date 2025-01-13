using LawFirmDirectory.Data;
using Microsoft.EntityFrameworkCore;

namespace LawFirmDirectory.Services
{
    public class AttorneyService
    {
        AppDBContext dbContext = new AppDBContext();

        public AttorneyService() { }   
        public async Task<List<Attorney>> GetAllAttorneys()
        {
            return await dbContext.Attorneys.AsNoTracking().ToListAsync();
        }
    }
}
