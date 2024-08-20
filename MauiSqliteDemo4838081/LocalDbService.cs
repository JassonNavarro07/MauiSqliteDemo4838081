using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiSqliteDemo4838081
{
    public class LocalDbService
    {
        private const string DB_NAME = "demo_local_db.db3";
        private readonly SQLiteAsyncConnection _connection;

        public LocalDbService()
        {
            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));
            //le indica al sistema que crea  la tabla  de nuestro contexto
            _connection.CreateTableAsync<Cliente>();
        }

        //metodo para listar los registros de nuestra tabla 
        public async Task<List<Cliente>> GetClientes()
        {
            return await _connection.Table<Cliente>().ToListAsync();
        }

        //metodo para listar los registros por id
        public async Task<Cliente> GetById(int id)
        {
           return await _connection.Table<Cliente>().Where(x=>x.Id == id).FirstOrDefaultAsync();
        }


        //Metodo para crear registro
        public async Task Create(Cliente cliente)
        {
            await _connection.InsertAsync(cliente);
        }

        //metodo para actualizar
        public async Task Update(Cliente clientes)
        {
            await _connection.UpdateAsync(clientes);
        }

        //metodo para eliminar 
        public async Task Delete(Cliente clientes)
        {
            await _connection.DeleteAsync(clientes);
        }
    }
}
