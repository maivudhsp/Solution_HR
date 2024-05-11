using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Command.CreateLeaveType
{
    public class CreateLeaveTypeCommand
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
