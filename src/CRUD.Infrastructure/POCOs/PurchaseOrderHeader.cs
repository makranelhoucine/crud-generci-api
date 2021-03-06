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
    /// General purchase order information. See PurchaseOrderDetail.
    ///</summary>
    public partial class PurchaseOrderHeader
    {

        ///<summary>
        /// Primary key.
        ///</summary>
       public int PurchaseOrderId { get; set; }

        ///<summary>
        /// Incremental number to track changes to the purchase order over time.
        ///</summary>
       public byte RevisionNumber { get; set; }

        ///<summary>
        /// Order current status. 1 = Pending; 2 = Approved; 3 = Rejected; 4 = Complete
        ///</summary>
       public byte Status { get; set; }

        ///<summary>
        /// Employee who created the purchase order. Foreign key to Employee.BusinessEntityID.
        ///</summary>
       public int EmployeeId { get; set; }

        ///<summary>
        /// Vendor with whom the purchase order is placed. Foreign key to Vendor.BusinessEntityID.
        ///</summary>
       public int VendorId { get; set; }

        ///<summary>
        /// Shipping method. Foreign key to ShipMethod.ShipMethodID.
        ///</summary>
       public int ShipMethodId { get; set; }

        ///<summary>
        /// Purchase order creation date.
        ///</summary>
       public System.DateTime OrderDate { get; set; }

        ///<summary>
        /// Estimated shipment date from the vendor.
        ///</summary>
       public System.DateTime? ShipDate { get; set; }

        ///<summary>
        /// Purchase order subtotal. Computed as SUM(PurchaseOrderDetail.LineTotal)for the appropriate PurchaseOrderID.
        ///</summary>
       public decimal SubTotal { get; set; }

        ///<summary>
        /// Tax amount.
        ///</summary>
       public decimal TaxAmt { get; set; }

        ///<summary>
        /// Shipping cost.
        ///</summary>
       public decimal Freight { get; set; }

        ///<summary>
        /// Total due to vendor. Computed as Subtotal + TaxAmt + Freight.
        ///</summary>
       public decimal TotalDue { get; private set; }

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
       public System.DateTime ModifiedDate { get; set; }

        public ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }


        public Employee Employee { get; set; }

        public ShipMethod ShipMethod { get; set; }

        public Vendor Vendor { get; set; }

        public PurchaseOrderHeader()
        {
            RevisionNumber = 0;
            Status = 1;
            OrderDate = System.DateTime.Now;
            ModifiedDate = System.DateTime.Now;
            PurchaseOrderDetails = new List<PurchaseOrderDetail>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
