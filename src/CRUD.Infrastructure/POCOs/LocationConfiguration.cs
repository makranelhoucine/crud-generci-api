// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.7
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace CRUD.Infrastructure.POCOs
{
    using System;
    using System.Collections.Generic;

    public partial class LocationConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Location>
    {
        public LocationConfiguration()
            : this("Production")
        {
        }

        public LocationConfiguration(string schema)
        {
            ToTable("Location", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"LocationID").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.CostRate).HasColumnName(@"CostRate").HasColumnType("smallmoney").IsRequired().HasPrecision(10,4);
            Property(x => x.Availability).HasColumnName(@"Availability").HasColumnType("decimal").IsRequired().HasPrecision(8,2);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
