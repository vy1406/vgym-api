using Microsoft.EntityFrameworkCore;
using Vgym.Data.Contexts;
using Vgym.Models.Entities;

namespace Vgym.Server.Data.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly VgymDbContext _context;

        public UserRepository(VgymDbContext context)
        {
            this._context = context;
        }
        public async Task Add(User newUser)
        {
            _context.Users.Add(newUser);
            await SaveAsync();
        }

        public async Task Delete(int id)
        {
            var user = await _context.Users.SingleOrDefaultAsync(user => user.Id == id);
            if (user != null)
            {
                _context.Users.Remove(user);
                await SaveAsync();
            }
            else
            {
                //TODO: add custom data exeptions
                throw new NotImplementedException();
            }
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetById(int id)
        {
            return await _context.Users.SingleOrDefaultAsync(user => user.Id == id);
        }

        public async Task<User> GetByName(string requestedName)
        {
            var userFromDb = await _context.Users.SingleOrDefaultAsync(user => user.Username == requestedName);
            return userFromDb;
            //later needs to look like the snippet below and return custom data exeptions in the else statement
            //if (userFromDb != null)
            //{
            //    return userFromDb;
            //}
            //else
            //{
            //    //TODO: add custom data exeptions

            //}
        }
        //TODO: need to make sure the passed parameter has the entity id since entry uses it to track the entity in db
        public async Task Update(User updatedUser)
        {
            _context.Entry(updatedUser).State = EntityState.Modified;
            await SaveAsync();
        }


        private Task SaveAsync() => _context.SaveChangesAsync();

    }
}
