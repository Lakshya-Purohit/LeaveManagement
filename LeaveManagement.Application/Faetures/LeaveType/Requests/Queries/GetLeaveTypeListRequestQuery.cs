using HR.LeaveManagement.Application.DTOs.LeaveType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Application.Faetures.LeaveType.Requests.Queries
{
    public class GetLeaveTypeListRequestQuery : IRequest<List<LeaveTypeDto>>
    {

    }
}
