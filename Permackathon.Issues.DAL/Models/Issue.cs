using Permackathon.Common.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Issues.DAL.Models
{
    public class Issue :IEntity<int>
    {
        private int _idIssue;
        private int _idUserCreator; ??? 
        private int _idUserResolver; ???
        private int _priority; ??? enum
        private string _name;
        private DateTime _deadLine;
        private bool _isCompleted;
        private bool _isSoftDeleted;
        private int _fk_Location; ???
        private int _fk_Ssector; ???
        private string _description;
    }
}
