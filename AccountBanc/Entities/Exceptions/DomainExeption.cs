using System;

namespace AccountBanc.Entities.Exceptions
{
    class DomainExeption : ApplicationException
    {
        public DomainExeption(string message) : base(message) { }
    }
}
