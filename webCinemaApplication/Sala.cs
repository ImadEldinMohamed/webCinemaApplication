using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webCinemaApplication
{
    public class Sala
    {
        public string nome { get; set; }
        public string cognome { get; set; }

        public bool ridotto = false;

        public Sala() { }
        public Sala(string nome, string cognome,bool ridotto )
        {
            this.nome = nome;
            this.cognome = cognome;
            this.ridotto = ridotto;
           
        }


    }

}