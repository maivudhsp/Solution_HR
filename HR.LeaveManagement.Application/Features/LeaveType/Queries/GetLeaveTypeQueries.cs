using MediatR;


namespace HR.LeaveManagement.Application.Features.LeaveType.Queries
{
    public record GetLeaveTypeQueries : IRequest<List<LeaveTypeDto>>
    {
    }
}
