using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class PlayerManager : BasePlayerManager
    {
        private IPersonCheckService _personCheckService;

        public PlayerManager(IPersonCheckService personCheckService)
        {
            this._personCheckService = personCheckService;
        }
       public void Save(Player player)
        {
            if (_personCheckService.CheckIfRealPerson(player))
            {
                base.Save(player);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
    }
}
