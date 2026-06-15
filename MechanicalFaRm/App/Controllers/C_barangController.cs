using System;
using System.Collections.Generic;
using System.Text;
using MechanicalFaRm.App.Service;
using MechanicalFaRm.App.Models;

namespace MechanicalFaRm.App.Controllers
{
    public abstract class CRUDBarang
    {
    public abstract bool InsertBarang(M_barang p);
    public abstract bool UpdateBarang(M_barang p);
    public abstract bool HapusBarang(int id); 
    }

    internal class C_barangController:CRUDBarang
    {
        private S_BarangService barangService = new S_BarangService();


        public M_barang? GetBarangById(int id)
        {
            return barangService.GetBarangById(id);
        }

        public List<M_barang> GetBarangList()
        {
            // ngarah ke service
            return barangService.GetListBarang();
        }


        public override bool InsertBarang(M_barang p)
        {
            barangService.InsertBarang(p);
            return true;
        }
        public override bool UpdateBarang(M_barang p)
        {
            barangService.UpdateBarang(p);
            return true;
        }
        public override bool HapusBarang(int  p)
        {
            barangService.DeleteBarang(p);
            return true;
        }
    }
}
