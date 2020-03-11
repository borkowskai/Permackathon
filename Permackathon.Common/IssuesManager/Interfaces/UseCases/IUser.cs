using Permackathon.Common.FinancialManager.TransferObjects;
using Permackathon.Common.IssuesManager.TransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Common.IssuesManager.Interfaces.UseCases
{
	public interface IUser
	{
		//IssuesManagement
		IssueTO AddIssue(IssueTO Issue);
		IssueTO BecomeResolver(int IssueId, int UserId);
		IssueTO MarkAsCompleted(int IssueId, int UserId);
		IssueTO MarkAsArchived(int IssueId, int UserId);
		IEnumerable<IssueTO> GetIssues();
	}
}
