using GoodIssueNoteApp.Context;
using Microsoft.EntityFrameworkCore;

namespace GoodIssueNoteApp.Data
{
    public class GoodsService
    {

        private readonly ApplicationDbContext _applicationDbContext;

        public GoodsService(ApplicationDbContext applicationDbContext) 
        {
            _applicationDbContext = applicationDbContext;
        }
        //get all good list
        public async Task<List<Goods>> GetAllGoods()
        {
            return await _applicationDbContext.GoodIssue.ToListAsync();
        }

        //add new good
        public async Task<bool> AddNewGood(Goods good)
        {
            await _applicationDbContext.GoodIssue.AddAsync(good);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //get good record by id
        public async Task<Goods> GetGoodbyId(int id)
        {
            Goods good = await _applicationDbContext.GoodIssue.FirstOrDefaultAsync(x => x.GoodId == id);
            return good;
        }

        //update good data
        public async Task<bool> UpdateGoodDetails(Goods good)
        {
            _applicationDbContext.GoodIssue.Update(good);
            await _applicationDbContext.SaveChangesAsync(); // save the changes
            return true;
        }

        //delete good data
        public async Task<bool> DeleteGood(Goods good)
        {
            _applicationDbContext.GoodIssue.Remove(good);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}
