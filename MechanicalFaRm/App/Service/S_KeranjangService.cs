using MechanicalFaRm.App.Repository;
using MechanicalFaRm.App.Session;
using System;
using System.Collections.Generic;
using System.Text;

namespace MechanicalFaRm.App.Service
{
    internal class S_KeranjangService
    {

        R_TransaksiRepository _repotrans = new R_TransaksiRepository();
        public void ClearKeranjang(int id)
        {
             _repotrans.ClearKeranjang(id);
        }

    }
}
