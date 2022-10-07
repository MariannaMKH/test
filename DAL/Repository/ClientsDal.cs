using DAL.Repository.Core;
using DTO.Data;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ClientsDal : BaseDal, IClientsDal
    {
        #region Ctors
        public ClientsDal(string connectionString, DataContext db = null) : base(connectionString, db)
        {
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// add new clients or update existing ones by provideing list of clinets
        /// </summary>
        /// <param name="clients"></param>
        public void AddOrUpdateClients(List<Client> clients)
        {
            foreach(var client in clients)
            {
                var dbClient = db.Clients.FirstOrDefault(c => c.Id == client.Id);
                if(dbClient == null)
                    db.Clients.Add(client);
                else
                    db.SetValues(client, dbClient);
            }
            db.SaveChanges();
        }
        /// <summary>
        /// delete existing clients by providing their id list
        /// </summary>
        /// <param name="clientIds"></param>
        public void DeleteClients(List<int> clientIds)
        {
            foreach (var id in clientIds)
            {
                var dbClient = db.Clients.FirstOrDefault(c => c.Id == id);
                if (dbClient != null)
                    db.Remove(dbClient);
            }
        }

        /// <summary>
        /// get history for client between given dates
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public IEnumerable<HistoryCheck> getHistoryForClient(int clientId, DateTime fromdate, DateTime to)
        {

            return from hist in db.HistoryChecks
                        join c in db.Clients on hist.ClientId equals c.Id
                        where hist.OrderDate >= fromdate && hist.OrderDate < to
                        select hist;

        }
        #endregion
    }
}
