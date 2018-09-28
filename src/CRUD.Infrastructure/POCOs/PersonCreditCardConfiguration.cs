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

    public partial class PersonCreditCardConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PersonCreditCard>
    {
        public PersonCreditCardConfiguration()
            : this("Sales")
        {
        }

        public PersonCreditCardConfiguration(string schema)
        {
            ToTable("PersonCreditCard", schema);
            HasKey(x => new { x.BusinessEntityId, x.CreditCardId });

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CreditCardId).HasColumnName(@"CreditCardID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            HasRequired(a => a.CreditCard).WithMany(b => b.PersonCreditCards).HasForeignKey(c => c.CreditCardId).WillCascadeOnDelete(false);
            HasRequired(a => a.Person).WithMany(b => b.PersonCreditCards).HasForeignKey(c => c.BusinessEntityId).WillCascadeOnDelete(false);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>