﻿using DemoAspx.Enum;


namespace DemoAspx.Model
{
    public class BaseResponse
    {

        public Esito codice { get; set; }
        public string messaggio { get; set; }


        public BaseResponse(Esito codice, string messaggio)
        {
            this.codice = codice;
            this.messaggio = messaggio;

        }
    }
}