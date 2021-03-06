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

    public partial class DatabaseLogConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<DatabaseLog>
    {
        public DatabaseLogConfiguration()
            : this("dbo")
        {
        }

        public DatabaseLogConfiguration(string schema)
        {
            ToTable("DatabaseLog", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"DatabaseLogID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PostTime).HasColumnName(@"PostTime").HasColumnType("datetime").IsRequired();
            Property(x => x.DatabaseUser).HasColumnName(@"DatabaseUser").HasColumnType("nvarchar").IsRequired().HasMaxLength(128);
            Property(x => x.Event).HasColumnName(@"Event").HasColumnType("nvarchar").IsRequired().HasMaxLength(128);
            Property(x => x.Schema).HasColumnName(@"Schema").HasColumnType("nvarchar").IsOptional().HasMaxLength(128);
            Property(x => x.Object).HasColumnName(@"Object").HasColumnType("nvarchar").IsOptional().HasMaxLength(128);
            Property(x => x.Tsql).HasColumnName(@"TSQL").HasColumnType("nvarchar(max)").IsRequired();
            Property(x => x.XmlEvent).HasColumnName(@"XmlEvent").HasColumnType("xml").IsRequired();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
