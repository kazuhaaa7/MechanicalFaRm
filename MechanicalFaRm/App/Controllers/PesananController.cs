using MechanicalFaRm.App.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace MechanicalFaRm.App.Controllers
{
    public class PesananController
    {
        private S_PesananService _service = new S_PesananService();
        public string ProsesCo(int idUser)
        {
            return _service.SubmitCheckout(idUser);
        }
    }
}
