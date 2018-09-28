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

    public partial class VEmployee
    {
       public int BusinessEntityId { get; set; }
       public string Title { get; set; }
       public string FirstName { get; set; }
       public string MiddleName { get; set; }
       public string LastName { get; set; }
       public string Suffix { get; set; }
       public string JobTitle { get; set; }
       public string PhoneNumber { get; set; }
       public string PhoneNumberType { get; set; }
       public string EmailAddress { get; set; }
       public int EmailPromotion { get; set; }
       public string AddressLine1 { get; set; }
       public string AddressLine2 { get; set; }
       public string City { get; set; }
       public string StateProvinceName { get; set; }
       public string PostalCode { get; set; }
       public string CountryRegionName { get; set; }
       public string AdditionalContactInfo { get; set; }

        public VEmployee()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>