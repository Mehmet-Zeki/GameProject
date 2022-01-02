using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
   public class Campaign : IEntity
    {
        public int Id { get; set; }
        public int Discount { get; set; }
    }
}
