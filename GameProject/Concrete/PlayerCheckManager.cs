using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class PlayerCheckManager : IPersonCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            return true;
        }
    }
}
