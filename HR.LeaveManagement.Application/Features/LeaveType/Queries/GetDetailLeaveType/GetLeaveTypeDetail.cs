using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetDetailLeaveType
{
    public record GetLeaveTypeDetail(int id) : IRequest<LeaveTypeDetailDto>
    {
    }
}
