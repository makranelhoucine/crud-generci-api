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

    ///<summary>
    /// Cross-reference table mapping customers, vendors, and employees to their addresses.
    ///</summary>
    public partial class BusinessEntityAddress
    {

        ///<summary>
        /// Primary key. Foreign key to BusinessEntity.BusinessEntityID.
        ///</summary>
       public int BusinessEntityId { get; set; }

        ///<summary>
        /// Primary key. Foreign key to Address.AddressID.
        ///</summary>
       public int AddressId { get; set; }

        ///<summary>
        /// Primary key. Foreign key to AddressType.AddressTypeID.
        ///</summary>
       public int AddressTypeId { get; set; }

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
       public System.Guid Rowguid { get; set; }

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
       public System.DateTime ModifiedDate { get; set; }


        public Address Address { get; set; }

        public AddressType AddressType { get; set; }

        public BusinessEntity BusinessEntity { get; set; }

        public BusinessEntityAddress()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
