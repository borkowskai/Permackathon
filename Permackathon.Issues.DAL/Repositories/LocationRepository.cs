using Microsoft.EntityFrameworkCore;
using Permackathon.Common.IssuesManager.Entities;
using Permackathon.Common.IssuesManager.Interfaces.IRepositories;
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

		public LocationEF Add(LocationEF Entity)
		{
			if (Entity is null)
			{
				throw new ArgumentNullException(nameof(Entity));
			}

			var result = issuesContext.Locations.Add(Entity);
			issuesContext.SaveChanges();
			return result.Entity;
		}

		public IEnumerable<LocationEF> GetAll()
		{
			return issuesContext.Locations
			.AsNoTracking()
			.Select(r => r).ToList();
		}

		public LocationEF GetById(int Id)
		{
			var location = issuesContext.Locations
			.AsNoTracking()
			.FirstOrDefault(c => c.Id == Id);

			if (location is null)
			{
				throw new KeyNotFoundException($"No effective with ID={Id} was found.");
			}

			return location;
		}

		public bool Remove(LocationEF entity)
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

		public LocationEF Update(LocationEF Entity)
		{
			if (Entity is null)
			{
				throw new ArgumentNullException(nameof(Entity));
			}

			return issuesContext
				.Locations
				.Update(Entity)
				.Entity;
		}
	}

}

