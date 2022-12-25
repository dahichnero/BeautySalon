using BeautySalon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon
{
    public class Session
    {
        private Session()
        {
            context = new SalonBContext();
        }

        private static Session? instance;
        public static Session Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Session();
                }
                return instance;
            }
        }

        private SalonBContext context;
        public SalonBContext Context => context;
    }
}
