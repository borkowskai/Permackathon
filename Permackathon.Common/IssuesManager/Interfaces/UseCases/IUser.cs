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
		bool BecomeResolver(int id);
		bool MarkAsCompleted(int id);
		bool MarkAsArchived(int id);
		List<IssueTO> GetIssues();
	}
}
