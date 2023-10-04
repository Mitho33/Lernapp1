using System;
using System.Collections.Generic;
using System.Text;

namespace BilderApp1
{
    class Model1
    {
        private string id;
        private string frage;
        private string antwort;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Frage
        {
            get { return frage; }
            set { frage = value; }
        }

        public string Antwort
        {
            get { return antwort; }
            set { antwort = value; }
        }

        public Model1( string i, string f, string a)
        {
            id= i;
            frage = f;
            antwort=a;
        }

      
    }
}
