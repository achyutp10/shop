using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Specifications
{
    internal class BaseSpecification<T>(Expression<Func<T, bool>> criteria) : ISpecification<T>
    {
        public Expression<Func<T, bool>> Criteria => criteria;
    }
}
