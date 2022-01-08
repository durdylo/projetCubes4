using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.gestionServices
{
    public class Service
    {
        int id;
        String serviceName;

        public int Id { get => id; set => id = value; }
        public String ServiceName { get => serviceName; set => serviceName = value; }
    }
}
