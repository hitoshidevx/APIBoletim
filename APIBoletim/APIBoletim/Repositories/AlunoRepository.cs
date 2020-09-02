using APIBoletim.Context;
using APIBoletim.Domains;
using APIBoletim.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace APIBoletim.Repositories
{
    public class AlunoRepository : IAluno
    {

        BoletimContext conexao = new BoletimContext();

        SqlCommand cmd = new SqlCommand();
        
        public Aluno Alterar(Aluno a)
        {
            throw new NotImplementedException();
        }

        public Aluno BuscarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public Aluno Cadastrar(Aluno a)
        {
            throw new NotImplementedException();
        }

        public Aluno Excluir(Aluno a)
        {
            throw new NotImplementedException();
        }

        public List<Aluno> ListarTodos()
        {
            cmd.Connection = conexao.Conectar();

            cmd.CommandText = "SELECT * FROM aluno";

            SqlDataReader dados = cmd.ExecuteReader();

            List<Aluno> alunos = new List<Aluno>();

            while(dados.Read())
            {
                alunos.Add(
                    new Aluno()
                    {
                        IdAluno = Convert.ToInt32(dados.GetValue(0)),
                        Nome = dados.GetValue(1).ToString(),
                        RA = dados.GetValue(2).ToString(),
                        Idade = Convert.ToInt32(dados.GetValue(3))
                    }

                    );
            }
            conexao.Desconectar();
            return alunos;
        }
    }
}
