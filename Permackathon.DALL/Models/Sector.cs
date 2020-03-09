using Permackathon.Common.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.DALL.Models
{
    public class Sector :IEntity<int>
    {
        private int _idSector;
        private string _name;

        public int IdSector
        {
            get
            {
                return _idSector;
            }

            set
            {
                _idSector = value;
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
                return _idSector;
            }
        }
    }
}
