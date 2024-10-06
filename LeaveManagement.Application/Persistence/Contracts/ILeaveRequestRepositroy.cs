using HR.LeaveManagement.Domain;
using LeaveManagement.Application.Persistence.Contracts;

namespace HR.LeaveManagement.Application.Persistence.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestWithDetails(int id);
        Task<LeaveRequest> GetLeaveRequestWithDetails();
    }
}
