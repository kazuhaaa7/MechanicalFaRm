using System;
using System.Collections.Generic;
using System.Text;
using MechanicalFaRm.App.Service;
using MechanicalFaRm.App.Models;

namespace MechanicalFaRm.App.Controllers
{
    internal class C_barangController
    {
        private S_BarangService barangService = new S_BarangService();

        public M_barang? GetBarangById(int id)
        {
            return barangService.GetBarangById(id);
        }

    }
}
