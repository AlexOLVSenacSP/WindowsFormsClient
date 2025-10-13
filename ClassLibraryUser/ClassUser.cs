using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClassLibraryUser
{
    public class ClassUser
    {
        //Propriedades
        private int Id {  get; set; }
        private string Name { get; set; }
        private string Email{ get; set; }
        private string Password { get; set; }

        private ConnClass _conn = new ConnClass();

        //Construtor
        public ClassUser(int _id, string _name, string _email, string _password)
        {
            this.Id = _id;
            this.Name = _name;
            this.Email = _email;
            this.Password = _password;
        }

        //Métodos (CRUD READ = SELECT ) 
        public DataTable Entrar(string email, string password) // antes string...tudo C#
        {
            // DataTable dt = new DataTable(); usa toda memoria da sala 
            var dt = new DataTable();// var similar Varchar variavel temporario
            string sql = "SELECT * FROM Usuario WHERE email=@Email AND senha=@password";
            
            try
            {
                using (SqlConnection cn = _conn.GetConnection())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql,cn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }

                }

            
            }
            catch(Exception erro) 
            {
                Console.WriteLine(erro.Message); 
            
            }
            return dt;
            
            
            //if (email == "teste@gmail.com" && password == "teste123")
            //{
            //    return "login feito com sucesso.";
            //}
            //return "e-mail e/ou senha inválidos.";
        }

        //Function to Admin
        public bool Registrar()
        {
           
            string sql = "Insert INTO Usuario (nome,email,senha) Values (@Nome, @Email, @Senha)";

            try
            {
                using (SqlConnection cn = _conn.GetConnection())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", this.Name);
                        cmd.Parameters.AddWithValue("@Email", this.Email);
                        cmd.Parameters.AddWithValue("@Senha", this.Password);


                        int linhasAfetada = cmd.ExecuteNonQuery();
                        return linhasAfetada > 0;
                        
                    }

                }


            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
                return false;

            }
            //return dt;
        }
    }
}
