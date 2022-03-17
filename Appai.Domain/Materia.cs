using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appai.Domain
{
    public class Materia
    {
        private string nome;
        private int id = 0;
        private double nota = 0;
        public Materia()
        {

        }
        public Materia(string nome, int id)
        {
            this.nome = nome;
            this.id = id;

        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public double Nota
        {
            get { return nota; }
            set { nota = value; }
        }
    }
}
