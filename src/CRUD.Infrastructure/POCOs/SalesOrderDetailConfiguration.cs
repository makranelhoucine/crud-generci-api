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

    public partial class SalesOrderDetailConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SalesOrderDetail>
    {
        public SalesOrderDetailConfiguration()
            : this("Sales")
        {
        }

        public SalesOrderDetailConfiguration(string schema)
        {
            ToTable("SalesOrderDetail", schema);
            HasKey(x => new { x.SalesOrderId, x.Id });

            Property(x => x.SalesOrderId).HasColumnName(@"SalesOrderID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Id).HasColumnName(@"SalesOrderDetailID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CarrierTrackingNumber).HasColumnName(@"CarrierTrackingNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(25);
            Property(x => x.OrderQty).HasColumnName(@"OrderQty").HasColumnType("smallint").IsRequired();
            Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired();
            Property(x => x.SpecialOfferId).HasColumnName(@"SpecialOfferID").HasColumnType("int").IsRequired();
            Property(x => x.UnitPrice).HasColumnName(@"UnitPrice").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.UnitPriceDiscount).HasColumnName(@"UnitPriceDiscount").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.LineTotal).HasColumnName(@"LineTotal").HasColumnType("numeric").IsRequired().HasPrecision(38,6).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            HasRequired(a => a.SalesOrderHeader).WithMany(b => b.SalesOrderDetails).HasForeignKey(c => c.SalesOrderId);
            HasRequired(a => a.SpecialOfferProduct).WithMany(b => b.SalesOrderDetails).HasForeignKey(c => new { c.SpecialOfferId, c.ProductId }).WillCascadeOnDelete(false);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>