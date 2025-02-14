using MarketAppProject.EntityLayer;
using MarketAppProject.HelperFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAppProject.DataAccessLayer
{
    internal class ProfessionManager
    {
        public List<TblProfession> BLProfessionList()
        {
            using (var repository = new ProfessionRepository())
            {
                return repository.DALProfessionList();
            }
        }

        public int BLProfessionAdd(TblProfession profession)
        {
            if (FieldCheck.checkBasicStringField(profession.professionName, 1, 40)
                )
            {
                return -1;
            }

            using (var repository = new ProfessionRepository())
            {
                return repository.DALProfessionAdd(profession);
            }
        }
        public int BLProfessionUpdate(TblProfession profession)
        {
            if (profession.professionId<0
                ||FieldCheck.checkBasicStringField(profession.professionName, 1, 40)
                )
            {
                return -1;
            }

            using (var repository = new ProfessionRepository())
            {
                return repository.DALProfessionUpdate(profession);
            }
        }

        public int BLProfessionDelete(TblProfession profession)
        {
            using (var repository = new ProfessionRepository())
            {
                return repository.DALProfessionDelete(profession);
            }
        }
    }
}
