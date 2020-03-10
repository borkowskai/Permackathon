using Permackathon.Common.IssuesManager.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Issues.DAL.Models
{
    public class Location :IEntity<int>
    {
        private int _idLocation;
        private string _name;

        public int IdLocation
        {
            get
            {
                return _idLocation;
            }

            set
            {
                _idLocation = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int Id
        {
            get
            {
                return _idLocation;
            }
        }
    }
}
