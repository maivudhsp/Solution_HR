using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Command.CreateLeaveType
{
    internal class CreateLeaveTypeCommandHandle : IRequestHandler<CreateLeaveTypeCommand, int>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public CreateLeaveTypeCommandHandle(ILeaveTypeRepository leaveTypeRepository,
            IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {

            //validate data
            //map data from request

            var leaveTypeCreateToDb= _mapper.Map<Domain.LeaveType>(request);

            //save to database

            await _leaveTypeRepository.CreateAsync(leaveTypeCreateToDb);

            //return data
            return leaveTypeCreateToDb.Id;
        }
    }
}
