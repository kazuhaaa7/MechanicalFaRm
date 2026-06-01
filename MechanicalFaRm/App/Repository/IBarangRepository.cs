using MechanicalFaRm.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicalFaRm.App.Repository
{
    internal interface IBarangRepository
    {
        List<M_barang> GetListBarang();
        List<M_barang> GetListBarang(int limit);
        M_barang GetStok();
        M_barang GetBarangById(int id);
        void InsertBarang(M_barang barang);
        void UpdateBarang(M_barang barang);
        void UpdateStokBarang(int barangId, int qtyNew);
        void DeleteBarang(int barangId);


    }
}
