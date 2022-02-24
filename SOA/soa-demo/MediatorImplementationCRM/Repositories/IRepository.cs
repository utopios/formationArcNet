using System;
using System.Collections.Generic;

namespace MediatorImplementationCRM.Repositories
{
    public interface IRepository<T>
    {
        public T Create(T element);

        public List<T> FindAllBy(Func<T, bool> Search);
    }
}