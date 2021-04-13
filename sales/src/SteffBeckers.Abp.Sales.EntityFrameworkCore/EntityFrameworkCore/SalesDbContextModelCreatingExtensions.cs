using System;
using Microsoft.EntityFrameworkCore;
using SteffBeckers.Abp.Sales.Accounts;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace SteffBeckers.Abp.Sales.EntityFrameworkCore
{
    public static class SalesDbContextModelCreatingExtensions
    {
        public static void ConfigureSales(
            this ModelBuilder builder,
            Action<SalesModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new SalesModelBuilderConfigurationOptions(
                SalesDbProperties.DbTablePrefix,
                SalesDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
            
                b.ConfigureByConvention();
            
                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */

            builder.Entity<Account>(b =>
            {
                b.ToTable(SalesDbProperties.DbTablePrefix + "Accounts", SalesDbProperties.DbSchema);
                b.ConfigureByConvention(); // auto configure for the base class props

                b.Property(p => p.Name)
                    .HasMaxLength(AccountConsts.NameMaxLength);
                b.HasIndex(p => p.Name);

                b.Property(p => p.Email)
                    .HasMaxLength(AccountConsts.EmailMaxLength);

                b.Property(p => p.Telephone)
                   .HasMaxLength(AccountConsts.TelephoneMaxLength);

                b.Property(p => p.Website)
                    .HasMaxLength(AccountConsts.WebsiteMaxLength);
            });
        }
    }
}