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
		bool BecomeResolver(int IssueId, int UserId);
		bool MarkAsCompleted(int IssueId, int UserId);
		bool MarkAsArchived(int IssueId, int UserId);
		IEnumerable<IssueTO> GetIssues();
	}
}
