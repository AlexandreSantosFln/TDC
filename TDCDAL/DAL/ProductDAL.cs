using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDCEntity.Entity;

namespace TDCDAL.DAL
{
    public class ProductDAL
    {


        public ProductList GetProductList()
        {
            ProductList productList = new ProductList();

            using (SqlConnection sqlConnection =
                       new SqlConnection("server = localhost;database=TDC;uid=sa;password=ayty@sql"))
            {
                SqlCommand command =
                    new SqlCommand("select * from product", sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    productList.Add(new Product() { IdProduct = Convert.ToInt32(sqlDataReader["ID_PRODUCT"]), NmProduct = sqlDataReader["NM_PRODUCT"].ToString(), VlPrice = Convert.ToSingle(sqlDataReader["VL_PRICE"]) });
                }

                sqlDataReader.Close();
            }

            return productList;

        }

        public void InsertProduct(Product pProduct)
        {
            using (SqlConnection sqlConnection =
             new SqlConnection("server = localhost;database=TDC;uid=sa;password=ayty@sql"))
            {
                string commandText = "INSERT INTO PRODUCT (ID_PRODUCT, NM_PRODUCT, VL_PRICE) VALUES (" + pProduct.IdProduct + ",'" + pProduct.NmProduct + "'," + pProduct.VlPrice + ")";

                SqlCommand command = new SqlCommand(commandText, sqlConnection);
                sqlConnection.Open();


                command.ExecuteNonQuery();

            }
        }

        public Product GetProductByIdProduct(int pIdProduct)
        {
            Product product = null;

            using (SqlConnection sqlConnection =
                       new SqlConnection("server = localhost;database=TDC;uid=sa;password=ayty@sql"))
            {
                SqlCommand command =
                    new SqlCommand("select * from product where id_product = " + pIdProduct, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    product = new Product() { IdProduct = Convert.ToInt32(sqlDataReader["ID_PRODUCT"]), NmProduct = sqlDataReader["NM_PRODUCT"].ToString(), VlPrice = Convert.ToSingle(sqlDataReader["VL_PRICE"]) };
                }

                sqlDataReader.Close();
            }

            return product;
        }


        public void DeleteProductByIdProduct(int pIdProduct)
        {
            using (SqlConnection sqlConnection =
             new SqlConnection("server = localhost;database=TDC;uid=sa;password=ayty@sql"))
            {

                string commandText = "DELETE FROM PRODUCT WHERE ID_PRODUCT = " + pIdProduct;

                SqlCommand command = new SqlCommand(commandText, sqlConnection);
                sqlConnection.Open();

                command.ExecuteNonQuery();


            }
        }
    }
}
