using MechanicalFaRm.App.Models;
using MechanicalFaRm.App.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicalFaRm.App.Service
{
    internal class BarangService : IBarangService
    {
        private readonly BarangRepository _torepo;

        public BarangService()
        {
            _torepo = new BarangRepository();
        }
        public List<M_barang> GetListBarang()
        {
            return _torepo.GetListBarang();
        }
        public List<M_barang> GetListBarang(int limit)
        {
            return _torepo.GetListBarang(limit);
        }
        public M_barang GetStok()
        {
            return _torepo.GetStok();
        }
        public M_barang GetBarangById(int id)
        {
            return _torepo.GetBarangById(id);
        }
        public void InsertBarang(M_barang barang)
        {
             _torepo.InsertBarang(barang);
        }
        public void UpdateBarang(M_barang barang)
        {
             _torepo.UpdateBarang(barang);
        }
        public void DeleteBarang(int barangId)
        {
            _torepo.DeleteBarang(barangId);
        }
    }
}
