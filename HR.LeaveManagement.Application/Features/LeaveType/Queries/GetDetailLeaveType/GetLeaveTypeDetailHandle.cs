using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetDetailLeaveType
{
    public class GetLeaveTypeDetailHandle : IRequestHandler<GetLeaveTypeDetail, LeaveTypeDetailDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public GetLeaveTypeDetailHandle(ILeaveTypeRepository leaveTypeRepository,
            IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<LeaveTypeDetailDto> Handle(GetLeaveTypeDetail request, CancellationToken cancellationToken)
        {

            //query data from database
            var leavetype = await _leaveTypeRepository.GetByIdAsync(request.id);
            //mapping data to dto
            var data = _mapper.Map<LeaveTypeDetailDto>(leavetype);
            //return data
            return data;
        }
    }
}
