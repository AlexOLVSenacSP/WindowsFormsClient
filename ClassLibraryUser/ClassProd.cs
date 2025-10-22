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
            string sql = "SELECT * FROM Product WHERE Name LIKE @name ;"; // Name Description igua BD

            try
            {
                using (SqlConnection cn = _conn.GetConnection())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@name", $"%{name}%");
                        //cmd.Parameters.AddWithValue("@description", $"%{description}%");

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


                        return cmd.ExecuteNonQuery() > 0;
                        

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

            string sql = "UPDATE Product SET Name=@Name, Description=@Description, Price=@Price, Status=@Status WHERE id_Product=@idproduct;";

            try
            {
                using (SqlConnection cn = _conn.GetConnection())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@idproduct", this.Id_Product);
                        cmd.Parameters.AddWithValue("@Name", this.Name);
                        cmd.Parameters.AddWithValue("@Description", this.Description);
                        cmd.Parameters.AddWithValue("@Price", this.Price);
                        cmd.Parameters.AddWithValue("@Status",this.Status);


                        return cmd.ExecuteNonQuery() > 0;
                        
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

            string sql = "DELETE from Product WHERE id_Product=@idProduct;";

            try
            {
                using (SqlConnection cn = _conn.GetConnection())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@idProduct", this.Id_Product);


                        return cmd.ExecuteNonQuery() > 0;
                        
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
