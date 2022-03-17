using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appai.Repository;
using Appai.Domain;

namespace Appai.Service
{
    public class MateriaService
    {

        public bool Cadastrar(string nome)
        {
            return MateriasRepository.CadastroMateria(nome);
        }
        public bool Remover(int id)
        {
            return MateriasRepository.RemoverMateria(id);
        }

        public List<Materia> GetMaterias()
        {
            return MateriasRepository.MateriasGetAll();
        }
        public bool Localizar(int id)
        {
            return MateriasRepository.Localizar(id);
        }
    }
}
