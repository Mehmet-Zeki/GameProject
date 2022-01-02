using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public abstract class BaseCampaignManager : ICampaigService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign add to db "+campaign.Id);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign Delete to db " + campaign.Id);

        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign Update to db "+campaign.Id);
        }
    }
}
