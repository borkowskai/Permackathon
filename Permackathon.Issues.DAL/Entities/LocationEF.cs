using Permackathon.Common.IssuesManager.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Permackathon.Issues.DAL.Models
{
    public class LocationEF
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
