using Permackathon.Common.TransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Common.Interfaces.UseCases
{
	public interface IUser
	{
		IssueTO AddIssue(IssueTO Issue);
		bool BecomeResolver(int id);
		bool MarkAsCompleted(int id);
		bool MarkAsArchived(int id);
		List<IssueTO> GetIssues();
	}
}
