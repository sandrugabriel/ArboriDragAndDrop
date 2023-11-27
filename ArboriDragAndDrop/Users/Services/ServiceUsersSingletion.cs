using ArboriDragAndDrop.Users.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArboriDragAndDrop.Users.Services
{
    public class ServiceUsersSingletion
    {

        private static readonly Lazy<IServiceUsers> _instance = new Lazy<IServiceUsers>(() => new ServiceUsers());

        public static IServiceUsers Instance => _instance.Value;

        private ServiceUsersSingletion() { }


    }
}
