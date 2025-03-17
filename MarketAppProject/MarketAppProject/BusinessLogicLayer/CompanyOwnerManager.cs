using MarketAppProject.DataAccessLayer;
using MarketAppProject.EntityLayer;
using MarketAppProject.HelperFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MarketAppProject.BusinessLogicLayer
{
    internal class CompanyOwnerManager
    {
        public List<TblCompanyOwner> BLCompanyOwnerList()
        {
            using (var repository = new CompanyOwnerRepository())
            {
                return repository.DALCompanyOwnerList();
            }
        }

        public int BLCompanyOwnerAdd(TblCompanyOwner companyOwner)
        {
            if (string.IsNullOrWhiteSpace(companyOwner.companyOwnerIdentityNumber)
                || !Regex.IsMatch(companyOwner.companyOwnerIdentityNumber, @"^\d+$")
                || companyOwner.companyOwnerIdentityNumber.Length < 5
                || companyOwner.companyOwnerIdentityNumber.Length > 15
                || string.IsNullOrWhiteSpace(companyOwner.companyOwnerName)
                || companyOwner.companyOwnerName.Length < 2
                || companyOwner.companyOwnerName.Length>40
                || string.IsNullOrWhiteSpace(companyOwner.companyOwnerSurname)
                || companyOwner.companyOwnerSurname.Length < 2
                || companyOwner.companyOwnerSurname.Length>40
                || FieldCheck.checkEmailField(companyOwner.companyOwnerEmail)
                || FieldCheck.checkPhoneField(companyOwner.companyOwnerTelephoneNumber)
                || FieldCheck.checkGenderField(companyOwner.companyOwnerGender)
                || FieldCheck.checkDateTimeField(companyOwner.companyOwnerBirthDate)
                || FieldCheck.checkAddressField(companyOwner.companyOwnerAddress)
                || FieldCheck.checkAddressField(companyOwner.companyOwnerBirthPlace)
                || companyOwner.companyOwnerProfession<0
                )
            {
                return -1;
            }


            using (var repository = new CompanyOwnerRepository())
            {
                return repository.DALCompanyOwnerAdd(companyOwner);
            }
        }

        public int BLCompanyOwnerUpdate(TblCompanyOwner companyOwner)
        {
            if (companyOwner.companyOwnerId<0
                ||string.IsNullOrWhiteSpace(companyOwner.companyOwnerIdentityNumber)
                || !Regex.IsMatch(companyOwner.companyOwnerIdentityNumber, @"^\d+$")
                || companyOwner.companyOwnerIdentityNumber.Length < 5
                || companyOwner.companyOwnerIdentityNumber.Length > 15
                || string.IsNullOrWhiteSpace(companyOwner.companyOwnerName)
                || companyOwner.companyOwnerName.Length < 2
                || companyOwner.companyOwnerName.Length > 40
                || string.IsNullOrWhiteSpace(companyOwner.companyOwnerSurname)
                || companyOwner.companyOwnerSurname.Length < 2
                || companyOwner.companyOwnerSurname.Length > 40
                || FieldCheck.checkEmailField(companyOwner.companyOwnerEmail)
                || FieldCheck.checkPhoneField(companyOwner.companyOwnerTelephoneNumber)
                || FieldCheck.checkGenderField(companyOwner.companyOwnerGender)
                || FieldCheck.checkDateTimeField(companyOwner.companyOwnerBirthDate)
                || FieldCheck.checkAddressField(companyOwner.companyOwnerAddress)
                || FieldCheck.checkAddressField(companyOwner.companyOwnerBirthPlace)
                || companyOwner.companyOwnerProfession < 0
                )
            {
                return -1;
            }


            using (var repository = new CompanyOwnerRepository())
            {
                return repository.DALCompanyOwnerUpdate(companyOwner);
            }
        }

        public int BLCompanyOwnerDelete(TblCompanyOwner companyOwner)
        {
            if (companyOwner.companyOwnerId < 0)
            {
                return -1;
            }
            using (var repository = new CompanyOwnerRepository())
            {
                return repository.DALDeleteCompanyOwner(companyOwner);
            }
        }
    }
}
