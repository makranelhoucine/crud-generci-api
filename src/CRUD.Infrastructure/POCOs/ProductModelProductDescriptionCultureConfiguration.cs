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

    public partial class ProductModelProductDescriptionCultureConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProductModelProductDescriptionCulture>
    {
        public ProductModelProductDescriptionCultureConfiguration()
            : this("Production")
        {
        }

        public ProductModelProductDescriptionCultureConfiguration(string schema)
        {
            ToTable("ProductModelProductDescriptionCulture", schema);
            HasKey(x => new { x.ProductModelId, x.ProductDescriptionId, x.CultureId });

            Property(x => x.ProductModelId).HasColumnName(@"ProductModelID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProductDescriptionId).HasColumnName(@"ProductDescriptionID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CultureId).HasColumnName(@"CultureID").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(6).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            HasRequired(a => a.Culture).WithMany(b => b.ProductModelProductDescriptionCultures).HasForeignKey(c => c.CultureId).WillCascadeOnDelete(false);
            HasRequired(a => a.ProductDescription).WithMany(b => b.ProductModelProductDescriptionCultures).HasForeignKey(c => c.ProductDescriptionId).WillCascadeOnDelete(false);
            HasRequired(a => a.ProductModel).WithMany(b => b.ProductModelProductDescriptionCultures).HasForeignKey(c => c.ProductModelId).WillCascadeOnDelete(false);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>