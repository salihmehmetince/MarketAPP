using MarketAppProject.DataAccessLayer;
using MarketAppProject.EntityLayer;
using System.Collections.Generic;

namespace MarketAppProject.BusinessLogicLayer
{
    internal class AdminManager
    {
        public List<TblAdmin> BLAdminList()
        {
            using (var repository = new AdminRepository())
            {
                return repository.DALAdminList();
            }
        }

        public int BLAdminAdd(TblAdmin admin)
        {
            if (string.IsNullOrWhiteSpace(admin.adminUsername) ||
                admin.adminUsername.Length < 5 ||
                admin.adminUsername.Length > 50 ||
                admin.adminUsername.Contains(" "))
            {
                return -1;
            }

            using (var repository = new AdminRepository())
            {
                return repository.DALAdminAdd(admin);
            }
        }

        public int BLAdminDelete(TblAdmin admin)
        {
            using (var repository = new AdminRepository())
            {
                return repository.DALAdminDelete(admin);
            }
        }
    }
}
