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

    public partial class AwBuildVersionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AwBuildVersion>
    {
        public AwBuildVersionConfiguration()
            : this("dbo")
        {
        }

        public AwBuildVersionConfiguration(string schema)
        {
            ToTable("AWBuildVersion", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"AWBuildVersionID").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.DatabaseVersion).HasColumnName(@"Database Version").HasColumnType("nvarchar").IsRequired().HasMaxLength(25);
            Property(x => x.VersionDate).HasColumnName(@"VersionDate").HasColumnType("datetime").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
