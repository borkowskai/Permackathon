using Microsoft.EntityFrameworkCore;
using Permackathon.Common.IssuesManager.Interfaces.IRepositories;
using Permackathon.Common.IssuesManager.TransferObjects;
using Permackathon.Issues.DAL.Extensions;
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
            this.issuesContext = issuesContext ?? throw new ArgumentNullException($"{nameof(issuesContext)} in SectorRepository");
        }


        public UserTO Add(UserTO Entity)
        {
            if (Entity is null)
            {
                throw new ArgumentNullException(nameof(Entity));
            }
            var user = Entity.ToEF();
            var result = issuesContext.Users.Add(user);
            issuesContext.SaveChanges();
            return result.Entity.ToTransferObject();
        }

        public IEnumerable<UserTO> GetAll()
        {
            return issuesContext.Users
            .AsNoTracking()
            .Select(r => r.ToTransferObject()).ToList();
        }

        public UserTO GetById(int Id)
        {
            var user = issuesContext.Users
            .AsNoTracking()
            .FirstOrDefault(c => c.UserId == Id);

            if (user is null)
            {
                throw new KeyNotFoundException($"No effective with ID={Id} was found.");
            }
            return user.ToTransferObject();
        }

        public bool Remove(UserTO entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            return Remove(entity.UserId);
        }

        public bool Remove(int Id)
        {
            var user = issuesContext.Sectors.FirstOrDefault(c => c.SectorId == Id);

            if (user == null)
            {
                throw new KeyNotFoundException($"CommentRepository. Delete(commentId = {Id}) no record to delete.");
            }
            var userUser = issuesContext.Sectors.Remove(user);
            return userUser.State == EntityState.Deleted;
        }

        public UserTO Update(UserTO Entity)
        {
            if (Entity is null)
            {
                throw new ArgumentNullException(nameof(Entity));
            }
            return issuesContext
                .Users
                .Update(Entity.ToEF())
                .Entity
                .ToTransferObject();
        }
    }
}
