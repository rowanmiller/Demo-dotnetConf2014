using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CycleSalesPublicSite.Conventions
{
    public class MyKeyConvention : Convention
    {
        public MyKeyConvention()
        {
            this.Properties()
                .Where(p => p.Name == p.DeclaringType.Name + "_Id")
                .Configure(p => p.IsKey());
        }
    }
}