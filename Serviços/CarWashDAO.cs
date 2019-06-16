using CarWash3.Modelos;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CarWash3.Serviços
{
    class CarWashDAO
    {
        public SQLiteConnection conexao;

        public CarWashDAO()
        {
            string dpPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Usuario.db3");
            var db = new SQLiteConnection(dpPath);
            conexao = new SQLiteConnection(dpPath);
            db.CreateTable<CarWash>();
        }
        public List<CarWash> GetTodos()
        {
            return (from data in conexao.Table<CarWash>()
                    select data).ToList();
        }

        public CarWash Get(int id)
        {
            return conexao.Table<CarWash>().FirstOrDefault(t => t.Id == id);
        }
        public CarWash Get(string Nome)
        {
            return conexao.Table<CarWash>().FirstOrDefault(t => t.Nome == Nome);
        }


        public void Adicionar(CarWash carWash)
        {
            conexao.Insert(carWash);
        }
        public void Encontrar(CarWash carWash)
        {
            conexao.Get<CarWash>(carWash);
        }
    }
}
