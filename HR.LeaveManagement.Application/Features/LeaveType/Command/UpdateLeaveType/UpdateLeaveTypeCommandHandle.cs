using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Command.UpdateLeaveType
{
    public class UpdateLeaveTypeCommandHandle : IRequestHandler<UpdateLeaveTypeCommand, Unit>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public UpdateLeaveTypeCommandHandle(ILeaveTypeRepository leaveTypeRepository,
            IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            //validate

            //read request data
            var updateLeaveType = _mapper.Map<Domain.LeaveType>(request);
            //save to database
            await _leaveTypeRepository.UpdateAsync(updateLeaveType);
            //return data
            return Unit.Value;

        }
    }
}
