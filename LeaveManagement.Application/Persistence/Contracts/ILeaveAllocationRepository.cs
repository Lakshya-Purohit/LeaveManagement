using HR.LeaveManagement.Domain;
using LeaveManagement.Application.Persistence.Contracts;

namespace HR.LeaveManagement.Application.Persistence.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task<LeaveAllocation> GetLeaveAllocationWithDetails(int id);
        Task<LeaveAllocation> GetLeaveAllocationWithDetails();
    }
}
