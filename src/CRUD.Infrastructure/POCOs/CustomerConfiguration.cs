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

    public partial class CustomerConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
            : this("Sales")
        {
        }

        public CustomerConfiguration(string schema)
        {
            ToTable("Customer", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"CustomerID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PersonId).HasColumnName(@"PersonID").HasColumnType("int").IsOptional();
            Property(x => x.StoreId).HasColumnName(@"StoreID").HasColumnType("int").IsOptional();
            Property(x => x.TerritoryId).HasColumnName(@"TerritoryID").HasColumnType("int").IsOptional();
            Property(x => x.AccountNumber).HasColumnName(@"AccountNumber").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            HasOptional(a => a.Person).WithMany(b => b.Customers).HasForeignKey(c => c.PersonId).WillCascadeOnDelete(false);
            HasOptional(a => a.SalesTerritory).WithMany(b => b.Customers).HasForeignKey(c => c.TerritoryId).WillCascadeOnDelete(false);
            HasOptional(a => a.Store).WithMany(b => b.Customers).HasForeignKey(c => c.StoreId).WillCascadeOnDelete(false);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
