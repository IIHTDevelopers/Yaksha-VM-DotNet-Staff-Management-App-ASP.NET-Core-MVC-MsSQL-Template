using StaffManagementApp.DAL.Interface;
using StaffManagementApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StaffManagementApp.DAL.Repository
{
    public class StaffManagementService : IStaffInterface
    {
        private IStaffRepository _repo;
        public StaffManagementService(IStaffRepository repo)
        {
            this._repo = repo;
        }

        public Staff AddStaff(Staff staff)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Staff DeleteStaff(int staffId)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public IEnumerable<Staff> GetAllStaffs()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Staff GetStaffById(int staffId)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Staff UpdateStaff(Staff staff)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}