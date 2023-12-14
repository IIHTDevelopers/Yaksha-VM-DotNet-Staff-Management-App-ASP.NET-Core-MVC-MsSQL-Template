using StaffManagementApp.DAL.Interface;
using StaffManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace StaffManagementApp.DAL.Repository
{
    public class StaffRepository : IStaffRepository
    {
        private StaffDbContext _context;
        public StaffRepository(StaffDbContext Context)
        {
            this._context = Context;
        }
      
        public Staff GetStaffById(int staffId)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public IEnumerable<Staff> GetAllStaffs()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Staff AddStaff(Staff staff)
        {
            //write your code here
            throw new NotImplementedException();
        }


        public Staff UpdateStaff(Staff updatedStaff)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Staff DeleteStaff(int staffId)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
