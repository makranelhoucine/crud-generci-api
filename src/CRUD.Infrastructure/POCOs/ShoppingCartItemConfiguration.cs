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

    public partial class ShoppingCartItemConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ShoppingCartItem>
    {
        public ShoppingCartItemConfiguration()
            : this("Sales")
        {
        }

        public ShoppingCartItemConfiguration(string schema)
        {
            ToTable("ShoppingCartItem", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ShoppingCartItemID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ShoppingCartId).HasColumnName(@"ShoppingCartID").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.Quantity).HasColumnName(@"Quantity").HasColumnType("int").IsRequired();
            Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired();
            Property(x => x.DateCreated).HasColumnName(@"DateCreated").HasColumnType("datetime").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            HasRequired(a => a.Product).WithMany(b => b.ShoppingCartItems).HasForeignKey(c => c.ProductId).WillCascadeOnDelete(false);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
