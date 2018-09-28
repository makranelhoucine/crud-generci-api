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

    public partial class StoreConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Store>
    {
        public StoreConfiguration()
            : this("Sales")
        {
        }

        public StoreConfiguration(string schema)
        {
            ToTable("Store", schema);
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.SalesPersonId).HasColumnName(@"SalesPersonID").HasColumnType("int").IsOptional();
            Property(x => x.Demographics).HasColumnName(@"Demographics").HasColumnType("xml").IsOptional();
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            HasOptional(a => a.SalesPerson).WithMany(b => b.Stores).HasForeignKey(c => c.SalesPersonId).WillCascadeOnDelete(false);
            HasRequired(a => a.BusinessEntity).WithOptional(b => b.Store).WillCascadeOnDelete(false);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>