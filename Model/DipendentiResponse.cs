using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAspx.Model
{
    public class DipendentiResponse
    {
        public BaseResponse baseResponse { get; set; }
        public List<Dipendente> dipendenteList { get; set; }


        public DipendentiResponse(BaseResponse baseResponse, List<Dipendente> dipendenteList)
        {
            this.baseResponse = baseResponse;
            this.dipendenteList = dipendenteList;
        }

    }
}