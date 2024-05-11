using MediatR;


namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveType
{
    public record GetLeaveTypeQueries : IRequest<List<LeaveTypeDto>>
    {
    }
}
