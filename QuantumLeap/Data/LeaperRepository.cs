using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using QuantumLeap.Models;

namespace QuantumLeap.Data
{
    public class LeaperRepository
    {
        const string ConnectionString = "Server=localhost;Database=QuantumLeap;Trusted_Connection=True;";

        public IEnumerable<Leaper> GetAllLeapers()
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                var leapers = db.Query<Leaper>("Select * from Leapers").ToList();

                return leapers;
            }
        }
    }
}
