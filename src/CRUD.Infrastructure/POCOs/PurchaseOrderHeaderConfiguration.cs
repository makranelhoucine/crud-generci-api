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

    public partial class PurchaseOrderHeaderConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PurchaseOrderHeader>
    {
        public PurchaseOrderHeaderConfiguration()
            : this("Purchasing")
        {
        }

        public PurchaseOrderHeaderConfiguration(string schema)
        {
            ToTable("PurchaseOrderHeader", schema);
            HasKey(x => x.PurchaseOrderId);

            Property(x => x.PurchaseOrderId).HasColumnName(@"PurchaseOrderID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RevisionNumber).HasColumnName(@"RevisionNumber").HasColumnType("tinyint").IsRequired();
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("tinyint").IsRequired();
            Property(x => x.EmployeeId).HasColumnName(@"EmployeeID").HasColumnType("int").IsRequired();
            Property(x => x.VendorId).HasColumnName(@"VendorID").HasColumnType("int").IsRequired();
            Property(x => x.ShipMethodId).HasColumnName(@"ShipMethodID").HasColumnType("int").IsRequired();
            Property(x => x.OrderDate).HasColumnName(@"OrderDate").HasColumnType("datetime").IsRequired();
            Property(x => x.ShipDate).HasColumnName(@"ShipDate").HasColumnType("datetime").IsOptional();
            Property(x => x.SubTotal).HasColumnName(@"SubTotal").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.TaxAmt).HasColumnName(@"TaxAmt").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Freight).HasColumnName(@"Freight").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.TotalDue).HasColumnName(@"TotalDue").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            HasRequired(a => a.Employee).WithMany(b => b.PurchaseOrderHeaders).HasForeignKey(c => c.EmployeeId).WillCascadeOnDelete(false);
            HasRequired(a => a.ShipMethod).WithMany(b => b.PurchaseOrderHeaders).HasForeignKey(c => c.ShipMethodId).WillCascadeOnDelete(false);
            HasRequired(a => a.Vendor).WithMany(b => b.PurchaseOrderHeaders).HasForeignKey(c => c.VendorId).WillCascadeOnDelete(false);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>