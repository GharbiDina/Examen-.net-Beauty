using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class PrestationService : Service<Prestation>, IServicePrestation
    {
        public PrestationService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}