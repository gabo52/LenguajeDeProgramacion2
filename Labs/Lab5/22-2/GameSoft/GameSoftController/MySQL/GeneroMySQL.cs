﻿using GameSoftController.DAO;
using GameSoftDBManager;
using GameSoftModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftController.MySQL
{
    public class GeneroMySQL:GeneroDAO
    {
        private MySqlConnection con;
        private MySqlCommand comando;
        private MySqlDataReader lector;

        public BindingList<Genero> listarTodos()
        {
            BindingList<Genero>generos = new BindingList<Genero>();
            try
            {
                con = new MySqlConnection(DBManager.cadena);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "LISTAR_GENEROS_TODOS";
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Genero genero = new Genero();
                    genero.IdGenero = lector.GetInt32("id_genero");
                    genero.Nombre = lector.GetString("nombre");

                    generos.Add(genero);
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                lector.Close(); 
                con.Close();    
            }
            return generos;
        }
    }
}
