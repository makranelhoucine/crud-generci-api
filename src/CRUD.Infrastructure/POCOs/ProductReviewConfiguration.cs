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

    public partial class ProductReviewConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProductReview>
    {
        public ProductReviewConfiguration()
            : this("Production")
        {
        }

        public ProductReviewConfiguration(string schema)
        {
            ToTable("ProductReview", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ProductReviewID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired();
            Property(x => x.ReviewerName).HasColumnName(@"ReviewerName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.ReviewDate).HasColumnName(@"ReviewDate").HasColumnType("datetime").IsRequired();
            Property(x => x.EmailAddress).HasColumnName(@"EmailAddress").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.Rating).HasColumnName(@"Rating").HasColumnType("int").IsRequired();
            Property(x => x.Comments).HasColumnName(@"Comments").HasColumnType("nvarchar").IsOptional().HasMaxLength(3850);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            HasRequired(a => a.Product).WithMany(b => b.ProductReviews).HasForeignKey(c => c.ProductId).WillCascadeOnDelete(false);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>