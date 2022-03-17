using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appai.Domain
{
    public class Professor
    {
        private string nome;
        private string email;
        private int id = 0;
        private string status = "Pendente";
        private Materia materia;
        public Professor()
        {

        }
        public Professor(string nome, string email, int id)
        {
            this.nome = nome;
            this.email = email;
            this.id = id;

        }



        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Materia Materia
        {
            get { return materia; }
            set { materia = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
