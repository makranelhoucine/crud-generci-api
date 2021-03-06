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

    public partial class ProductSubcategoryConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProductSubcategory>
    {
        public ProductSubcategoryConfiguration()
            : this("Production")
        {
        }

        public ProductSubcategoryConfiguration(string schema)
        {
            ToTable("ProductSubcategory", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ProductSubcategoryID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ProductCategoryId).HasColumnName(@"ProductCategoryID").HasColumnType("int").IsRequired();
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            HasRequired(a => a.ProductCategory).WithMany(b => b.ProductSubcategories).HasForeignKey(c => c.ProductCategoryId).WillCascadeOnDelete(false);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
