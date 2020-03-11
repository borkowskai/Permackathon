using Permackathon.Common.FinancialManager.TransferObjects;
using Permackathon.Common.IssuesManager.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Common.IssuesManager.Interfaces.UseCases
{
	public interface IUser
	{
		//IssuesManagement
		IssueEF AddIssue(IssueEF Issue);
		IssueEF BecomeResolver(int IssueId, int UserId);
		IssueEF MarkAsCompleted(int IssueId, int UserId);
		IssueEF MarkAsArchived(int IssueId, int UserId);
		IEnumerable<IssueEF> GetIssues();
	}
}
