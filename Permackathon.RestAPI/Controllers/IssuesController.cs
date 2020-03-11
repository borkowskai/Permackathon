using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Permackathon.Common.IssuesManager.Entities;
using Permackathon.Common.IssuesManager.Interfaces.IRepositories;
using Permackathon.Common.IssuesManager.Interfaces.UseCases;
using Permackathon.Issues.DAL;

namespace Permackathon.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class IssuesController : ControllerBase
    {
        public IssuesController(IssuesContext ctx, IIssuesUnitOfWork uow, IUser user)
        {
            this._Context = ctx;
            this._UserRole = user;
            this._Uow = uow;
 
        }
        private readonly IssuesContext _Context;
        private readonly IIssuesUnitOfWork _Uow;
        private readonly IUser _UserRole;

        [HttpGet]
        public IEnumerable<IssueEF> Get()
        {
            return _UserRole.GetIssues();
        }

        [HttpPost]
        public IssueEF Add([FromBody]IssueEF Issue)
        {
            return _UserRole.AddIssue(Issue);
        }

        [HttpPost]
        public IssueEF Resolve([FromBody]int IssueId, int UserId)
        {
            return _UserRole.BecomeResolver(IssueId, UserId);
        }

        [HttpPost]
        public IssueEF Archived([FromBody]int IssueId, int UserId)
        {
            return _UserRole.MarkAsArchived(IssueId, UserId);
        }

        [HttpPost]
        public IssueEF Completed([FromBody]int IssueId, int UserId)
        {
            return _UserRole.MarkAsCompleted(IssueId, UserId);
        }

    }
}