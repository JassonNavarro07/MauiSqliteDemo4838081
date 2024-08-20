using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiSqliteDemo4838081
{
    [Table("cliente")]
    public  class Cliente
    {
        [PrimaryKey]
        [AutoIncrement]
        [Column("id")]
        public int Id { get; set; }
        [Column("nombrecliente")]
        public string NombreCliente { get; set; }
        [Column("movil")]
        public string Movil {  get; set; }
        [Column("email")]
        public string Email { get; set; }
    }
}
