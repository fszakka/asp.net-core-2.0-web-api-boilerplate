using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApi.DataContext.Core
{
    public static class DatabaseInitializer
    {
        public static void Initialize(CoreContext context)
        {
            context.Database.EnsureCreated();

            context.SaveChanges();
        }
    }
}
