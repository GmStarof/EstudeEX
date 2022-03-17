using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appai.Domain;
using Appai.Repository;

namespace Appai.Service
{
    public class ProfessorService
    {
        public List<Professor> getProfessor()
        {
            return ProfessorRepository.GetAll();
        }
        public bool Cadastrar(string nome, string email)
        {
            return ProfessorRepository.CadastroProfessor(nome, email);
        }
        public void CadastrarMateria(int id, int idMateria)
        {
            ProfessorRepository.CadastrarMateria(id, idMateria);
        }
        public bool MateriaVerifica()
        {
            return ProfessorRepository.MateriaVerificar();
        }

        public bool Remover(int id)
        {
            return ProfessorRepository.RemoverProfessor(id);
        }
        public bool StatusFinan(int id)
        {
            return ProfessorRepository.SituaçãoFina(id);
        }
        public bool localizarP(int id)
        {
            return ProfessorRepository.localizar(id);
        }
        public void PagarProfe(int id)
        {
            ProfessorRepository.PagarProfe(id);
        }
    }
}
