using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Eklendi");   
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Güncellendi");
        }
    }
}
