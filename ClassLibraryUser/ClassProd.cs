using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUser
{
    public class ClassProd
    {
        //Propriedades com todos que iniciam em maiusculo
        private int Id_Product { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }
        private double Price { get; set; }
        private bool Status { get; set; }

        private ConnClass _conn = new ConnClass();

        //Construtor com todos com _
        public ClassProd(int _id, string _name, string _description, double _price, bool _status)
        {
            this.Id_Product = _id;
            this.Name = _name;
            this.Description = _description;
            this.Price = _price;
            this.Status = _status;
            
        }

        //Métodos (CRUD READ = SELECT ) = Pesquisar 
        public DataTable ProductSearch(string name, string description) // antes string...tudo C#
        {
            // DataTable dt = new DataTable(); usa toda memoria da sala 
            var dt = new DataTable();// var similar Varchar variavel temporario
            string sql = "SELECT * FROM Product WHERE Name LIKE @Name;";// Name Description igua BD

            try
            {
                using (SqlConnection cn = _conn.GetConnection())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Name", $"% {name} %");
                        cmd.Parameters.AddWithValue("@Description", $"% {description} %");

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }

                }


            }
            catch (Exception erro)
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

            string sql = "Insert INTO Product (name,description,price,status) Values (@Nome, @Description, @Price, @Status)";

            try
            {
                using (SqlConnection cn = _conn.GetConnection())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", this.Name);
                        cmd.Parameters.AddWithValue("@Description", this.Description);
                        cmd.Parameters.AddWithValue("@Price", this.Price);
                        cmd.Parameters.AddWithValue("@Status", this.Status);


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

        public bool Atualizar()
        {

            string sql = "UPDATE Product SET name@Name, description=@Description, price=@Price, status=@Status WHERE id_product=@id;";

            try
            {
                using (SqlConnection cn = _conn.GetConnection())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@id_product", this.Id_Product);
                        cmd.Parameters.AddWithValue("@Name", this.Name);
                        cmd.Parameters.AddWithValue("@Description", this.Description);
                        cmd.Parameters.AddWithValue("@Price", this.Price);


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

        }
        // remoção deletar do banco
        public bool Remover()
        {

            string sql = "DELETE from Usuario WHERE id_Usuario=@idUsuario;";

            try
            {
                using (SqlConnection cn = _conn.GetConnection())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@idUsuario", this.Id_Product);


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

        }
    }
}
