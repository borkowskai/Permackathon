using Microsoft.EntityFrameworkCore;
using Permackathon.Common.IssuesManager.Entities;
using Permackathon.Common.IssuesManager.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Permackathon.Issues.DAL.Repositories
{


    public class UserRepository : IUserRepository
    {
        private readonly IssuesContext issuesContext;

        public UserRepository(IssuesContext issuesContext)
        {
            this.issuesContext = issuesContext ?? throw new ArgumentNullException($"{nameof(issuesContext)} in UserRepository");
        }


        public UserEF Add(UserEF Entity)
        {
            if (Entity is null)
            {
                throw new ArgumentNullException(nameof(Entity));
            }
            var user = Entity;
            var result = issuesContext.Users.Add(user);
            issuesContext.SaveChanges();
            return result.Entity;
        }

        public IEnumerable<UserEF> GetAll()
        {
            return issuesContext.Users
            .AsNoTracking()
            .Select(r => r).ToList();
        }

        public UserEF GetById(int Id)
        {
            var user = issuesContext.Users
            .AsNoTracking()
            .FirstOrDefault(c => c.Id == Id);

            if (user is null)
            {
                throw new KeyNotFoundException($"No effective with ID={Id} was found.");
            }
            return user;
        }

        public bool Remove(UserEF entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            return Remove(entity.Id);
        }

        public bool Remove(int Id)
        {
            var user = issuesContext.Sectors.FirstOrDefault(c => c.Id == Id);

            if (user == null)
            {
                throw new KeyNotFoundException($"CommentRepository. Delete(commentId = {Id}) no record to delete.");
            }
            var userUser = issuesContext.Sectors.Remove(user);
            return userUser.State == EntityState.Deleted;
        }

        public UserEF Update(UserEF Entity)
        {
            if (Entity is null)
            {
                throw new ArgumentNullException(nameof(Entity));
            }
            return issuesContext
                .Users
                .Update(Entity)
                .Entity
                ;
        }
    }
}
