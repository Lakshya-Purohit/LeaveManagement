using HR.LeaveManagement.Application.DTOs.LeaveType;
using LeaveManagement.Application.Faetures.LeaveType.Requests.Queries;
using HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Application.Faetures.LeaveType.Handler.Queries
{
    public class GetLeaveTypeListRequestHandler : IRequestHandler<GetLeaveTypeListRequestQuery, List<LeaveTypeDto>>
    {
        //private readonly ILeaveTypeRepository
        public GetLeaveTypeListRequestHandler()
        {
            
        }
        public Task<List<LeaveTypeDto>> Handle(GetLeaveTypeListRequestQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
