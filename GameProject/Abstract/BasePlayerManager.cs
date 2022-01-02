using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public abstract class BasePlayerManager : IPlayerService
    {
        public void Delete(Player player)
        {
            Console.WriteLine("Delete to db :"+player.Id);
        }

        public void Save(Player player)
        {
            Console.WriteLine("Save to db : " + player.Id);
        }

        public void Update(Player player)
        {
            Console.WriteLine("Update to db: "+player.Id);
        }
    }
}
