using Battery.Repository.Concrete.EntityFramework;
using CorePackages.UnitOfWorks;

namespace Battery.Repository.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BatterySelectionDbContext _context;

        public UnitOfWork(BatterySelectionDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
