using MechanicalFaRm.App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MechanicalFaRm.App.Service
{
    internal interface S_IPesananService
    {
        string AddToKeranjang(M_Keranjang itemkeranjang);
    }
}
