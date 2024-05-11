using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Command.DeleteLeaveType
{
    public class DeleteLeaveTypeCommandHandle : IRequestHandler<DeleteLeaveTypeCommand, int>
    {
        public Task<int> Handle(DeleteLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
