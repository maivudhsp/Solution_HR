using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries
{
    public class GetLeaveTypeQueryHandler : IRequestHandler<GetLeaveTypeQueries, List<LeaveTypeDto>>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveType;

        public GetLeaveTypeQueryHandler(IMapper mapper, ILeaveTypeRepository leaveType)
        {
            _mapper = mapper;
            _leaveType = leaveType;
        }
        public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypeQueries request, CancellationToken cancellationToken)
        {
            //query from database
            var leavetypes = await _leaveType.GetAllAsync();
            //map object to dto
            var data = _mapper.Map<List<LeaveTypeDto>>(leavetypes);
            //return data
            return data;
        }
    }
}
