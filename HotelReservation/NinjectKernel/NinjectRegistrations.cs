using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using HotelReservation.Common.Interfaces;
using HotelReservation.Common.Logic;

namespace HotelReservation.NinjectKernel
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository>().To<HotelRepository>().WithConstructorArgument("context", new HotelContext());
            Bind<IData>().To<Data>();
        }
    }
}