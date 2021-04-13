﻿using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace SteffBeckers.Abp.Sales.MongoDB
{
    [ConnectionStringName(SalesDbProperties.ConnectionStringName)]
    public interface ISalesMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
