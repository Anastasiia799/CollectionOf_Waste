using TRASH.DomainObjects;
using TRASH.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace TRASH.ApplicationServices.GetTRASHListUseCase
{
    public class TypeAreaCriteria : ICriteria<DomainObjects.TRASH>
    {
        public string TypeArea { get; }      /*save filtration criteria*/

        public TypeAreaCriteria(string typeArea) /*get criteria and save as class member*/
            => TypeArea = typeArea;

        public Expression<Func<DomainObjects.TRASH, bool>> Filter
            => (rpts => rpts.TypeArea == TypeArea); /*Filter*/
    }
}
