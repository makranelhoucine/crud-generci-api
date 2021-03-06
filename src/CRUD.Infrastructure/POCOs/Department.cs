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
    /// Lookup table containing the departments within the Adventure Works Cycles company.
    ///</summary>
    public partial class Department : IEntity<short>
    {

        ///<summary>
        /// Primary key for Department records.
        ///</summary>
       public short Id { get; set; }

        ///<summary>
        /// Name of the department.
        ///</summary>
       public string Name { get; set; }

        ///<summary>
        /// Name of the group to which the department belongs.
        ///</summary>
       public string GroupName { get; set; }

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
       public System.DateTime ModifiedDate { get; set; }

        public ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }

        public Department()
        {
            ModifiedDate = System.DateTime.Now;
            EmployeeDepartmentHistories = new List<EmployeeDepartmentHistory>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
