using System;
using System.Collections.Generic;
using System.Text;

namespace TRASH.ApplicationServices.Ports
{
    public interface IOutputPort<in TUseCaseResponse>
    {
        void Handle(TUseCaseResponse response);
    }
}
