using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Lab_3.Abstraction
{
    public abstract class AssignedCourseMember
    {
        protected CoreMediator _coreMediator;

        public AssignedCourseMember(CoreMediator coreMediator)
        {
            _coreMediator = coreMediator;
        }
    }
}
