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
	public class LocationRepository : ILocationRepository
	{
		private readonly IssuesContext issuesContext;

		public LocationRepository(IssuesContext issuesContext)
		{
			this.issuesContext = issuesContext ?? throw new ArgumentNullException($"{nameof(issuesContext)} in IssueRepository");
		}

		public LocationTO Add(LocationTO Entity)
		{
			if (Entity is null)
			{
				throw new ArgumentNullException(nameof(Entity));
			}

			var location = Entity.ToEF();
			var result = issuesContext.Locations.Add(location);
			issuesContext.SaveChanges();
			return result.Entity.ToTransferObject();
		}

		public IEnumerable<LocationTO> GetAll()
		{
			return issuesContext.Locations
			.AsNoTracking()
			.Select(r => r.ToTransferObject()).ToList();
		}

		public LocationTO GetById(int Id)
		{
			var location = issuesContext.Locations
			.AsNoTracking()
			.FirstOrDefault(c => c.Id == Id);

			if (location is null)
			{
				throw new KeyNotFoundException($"No effective with ID={Id} was found.");
			}

			return location.ToTransferObject();
		}

		public bool Remove(LocationTO entity)
		{
			if (entity is null)
			{
				throw new ArgumentNullException(nameof(entity));
			}

			return Remove(entity.Id);
		}

		public bool Remove(int Id)
		{
			var location = issuesContext.Locations.FirstOrDefault(c => c.Id == Id);

			if (location == null)
			{
				throw new KeyNotFoundException($"CommentRepository. Delete(commentLocationId = {Id}) no record to delete.");
			}
			var removedLocation = issuesContext.Locations.Remove(location);
			return removedLocation.State == EntityState.Deleted;
		}

		public LocationTO Update(LocationTO Entity)
		{
			if (Entity is null)
			{
				throw new ArgumentNullException(nameof(Entity));
			}

			return issuesContext
				.Locations
				.Update(Entity.ToEF())
				.Entity
				.ToTransferObject();
		}
	}

}

