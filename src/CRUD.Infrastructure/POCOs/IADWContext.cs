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

    public partial interface IADWContext : System.IDisposable
    {
        System.Data.Entity.DbSet<Address> Addresses { get; set; }
        System.Data.Entity.DbSet<AddressType> AddressTypes { get; set; }
        System.Data.Entity.DbSet<AwBuildVersion> AwBuildVersions { get; set; }
        System.Data.Entity.DbSet<BillOfMaterial> BillOfMaterials { get; set; }
        System.Data.Entity.DbSet<BusinessEntity> BusinessEntities { get; set; }
        System.Data.Entity.DbSet<BusinessEntityAddress> BusinessEntityAddresses { get; set; }
        System.Data.Entity.DbSet<BusinessEntityContact> BusinessEntityContacts { get; set; }
        System.Data.Entity.DbSet<ContactType> ContactTypes { get; set; }
        System.Data.Entity.DbSet<CountryRegion> CountryRegions { get; set; }
        System.Data.Entity.DbSet<CountryRegionCurrency> CountryRegionCurrencies { get; set; }
        System.Data.Entity.DbSet<CreditCard> CreditCards { get; set; }
        System.Data.Entity.DbSet<Culture> Cultures { get; set; }
        System.Data.Entity.DbSet<Currency> Currencies { get; set; }
        System.Data.Entity.DbSet<CurrencyRate> CurrencyRates { get; set; }
        System.Data.Entity.DbSet<Customer> Customers { get; set; }
        System.Data.Entity.DbSet<DatabaseLog> DatabaseLogs { get; set; }
        System.Data.Entity.DbSet<Department> Departments { get; set; }
        System.Data.Entity.DbSet<Document> Documents { get; set; }
        System.Data.Entity.DbSet<EmailAddress> EmailAddresses { get; set; }
        System.Data.Entity.DbSet<Employee> Employees { get; set; }
        System.Data.Entity.DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
        System.Data.Entity.DbSet<EmployeePayHistory> EmployeePayHistories { get; set; }
        System.Data.Entity.DbSet<ErrorLog> ErrorLogs { get; set; }
        System.Data.Entity.DbSet<Illustration> Illustrations { get; set; }
        System.Data.Entity.DbSet<JobCandidate> JobCandidates { get; set; }
        System.Data.Entity.DbSet<Location> Locations { get; set; }
        System.Data.Entity.DbSet<Password> Passwords { get; set; }
        System.Data.Entity.DbSet<Person> People { get; set; }
        System.Data.Entity.DbSet<PersonCreditCard> PersonCreditCards { get; set; }
        System.Data.Entity.DbSet<PersonPhone> PersonPhones { get; set; }
        System.Data.Entity.DbSet<PhoneNumberType> PhoneNumberTypes { get; set; }
        System.Data.Entity.DbSet<Product> Products { get; set; }
        System.Data.Entity.DbSet<ProductCategory> ProductCategories { get; set; }
        System.Data.Entity.DbSet<ProductCostHistory> ProductCostHistories { get; set; }
        System.Data.Entity.DbSet<ProductDescription> ProductDescriptions { get; set; }
        System.Data.Entity.DbSet<ProductDocument> ProductDocuments { get; set; }
        System.Data.Entity.DbSet<ProductInventory> ProductInventories { get; set; }
        System.Data.Entity.DbSet<ProductListPriceHistory> ProductListPriceHistories { get; set; }
        System.Data.Entity.DbSet<ProductModel> ProductModels { get; set; }
        System.Data.Entity.DbSet<ProductModelIllustration> ProductModelIllustrations { get; set; }
        System.Data.Entity.DbSet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }
        System.Data.Entity.DbSet<ProductPhoto> ProductPhotoes { get; set; }
        System.Data.Entity.DbSet<ProductProductPhoto> ProductProductPhotoes { get; set; }
        System.Data.Entity.DbSet<ProductReview> ProductReviews { get; set; }
        System.Data.Entity.DbSet<ProductSubcategory> ProductSubcategories { get; set; }
        System.Data.Entity.DbSet<ProductVendor> ProductVendors { get; set; }
        System.Data.Entity.DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        System.Data.Entity.DbSet<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
        System.Data.Entity.DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }
        System.Data.Entity.DbSet<SalesOrderHeader> SalesOrderHeaders { get; set; }
        System.Data.Entity.DbSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }
        System.Data.Entity.DbSet<SalesPerson> SalesPersons { get; set; }
        System.Data.Entity.DbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }
        System.Data.Entity.DbSet<SalesReason> SalesReasons { get; set; }
        System.Data.Entity.DbSet<SalesTaxRate> SalesTaxRates { get; set; }
        System.Data.Entity.DbSet<SalesTerritory> SalesTerritories { get; set; }
        System.Data.Entity.DbSet<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }
        System.Data.Entity.DbSet<ScrapReason> ScrapReasons { get; set; }
        System.Data.Entity.DbSet<Shift> Shifts { get; set; }
        System.Data.Entity.DbSet<ShipMethod> ShipMethods { get; set; }
        System.Data.Entity.DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        System.Data.Entity.DbSet<SpecialOffer> SpecialOffers { get; set; }
        System.Data.Entity.DbSet<SpecialOfferProduct> SpecialOfferProducts { get; set; }
        System.Data.Entity.DbSet<StateProvince> StateProvinces { get; set; }
        System.Data.Entity.DbSet<Store> Stores { get; set; }
        System.Data.Entity.DbSet<TransactionHistory> TransactionHistories { get; set; }
        System.Data.Entity.DbSet<TransactionHistoryArchive> TransactionHistoryArchives { get; set; }
        System.Data.Entity.DbSet<UnitMeasure> UnitMeasures { get; set; }
        System.Data.Entity.DbSet<VAdditionalContactInfo> VAdditionalContactInfoes { get; set; }
        System.Data.Entity.DbSet<VEmployee> VEmployees { get; set; }
        System.Data.Entity.DbSet<VEmployeeDepartment> VEmployeeDepartments { get; set; }
        System.Data.Entity.DbSet<VEmployeeDepartmentHistory> VEmployeeDepartmentHistories { get; set; }
        System.Data.Entity.DbSet<Vendor> Vendors { get; set; }
        System.Data.Entity.DbSet<VIndividualCustomer> VIndividualCustomers { get; set; }
        System.Data.Entity.DbSet<VJobCandidate> VJobCandidates { get; set; }
        System.Data.Entity.DbSet<VJobCandidateEducation> VJobCandidateEducations { get; set; }
        System.Data.Entity.DbSet<VJobCandidateEmployment> VJobCandidateEmployments { get; set; }
        System.Data.Entity.DbSet<VPersonDemographic> VPersonDemographics { get; set; }
        System.Data.Entity.DbSet<VProductAndDescription> VProductAndDescriptions { get; set; }
        System.Data.Entity.DbSet<VProductModelCatalogDescription> VProductModelCatalogDescriptions { get; set; }
        System.Data.Entity.DbSet<VProductModelInstruction> VProductModelInstructions { get; set; }
        System.Data.Entity.DbSet<VSalesPerson> VSalesPersons { get; set; }
        System.Data.Entity.DbSet<VSalesPersonSalesByFiscalYear> VSalesPersonSalesByFiscalYears { get; set; }
        System.Data.Entity.DbSet<VStateProvinceCountryRegion> VStateProvinceCountryRegions { get; set; }
        System.Data.Entity.DbSet<VStoreWithAddress> VStoreWithAddresses { get; set; }
        System.Data.Entity.DbSet<VStoreWithContact> VStoreWithContacts { get; set; }
        System.Data.Entity.DbSet<VStoreWithDemographic> VStoreWithDemographics { get; set; }
        System.Data.Entity.DbSet<VVendorWithAddress> VVendorWithAddresses { get; set; }
        System.Data.Entity.DbSet<VVendorWithContact> VVendorWithContacts { get; set; }
        System.Data.Entity.DbSet<WorkOrder> WorkOrders { get; set; }
        System.Data.Entity.DbSet<WorkOrderRouting> WorkOrderRoutings { get; set; }

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
        System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get; }
        System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get; }
        System.Data.Entity.Database Database { get; }
        System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity);
        System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors();
        System.Data.Entity.DbSet Set(System.Type entityType);
        System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();

        // Stored Procedures
        System.Collections.Generic.List<UspGetBillOfMaterialsReturnModel> UspGetBillOfMaterials(int? startProductId, System.DateTime? checkDate);
        System.Collections.Generic.List<UspGetBillOfMaterialsReturnModel> UspGetBillOfMaterials(int? startProductId, System.DateTime? checkDate, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetBillOfMaterialsReturnModel>> UspGetBillOfMaterialsAsync(int? startProductId, System.DateTime? checkDate);

        System.Collections.Generic.List<UspGetEmployeeManagersReturnModel> UspGetEmployeeManagers(int? businessEntityId);
        System.Collections.Generic.List<UspGetEmployeeManagersReturnModel> UspGetEmployeeManagers(int? businessEntityId, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetEmployeeManagersReturnModel>> UspGetEmployeeManagersAsync(int? businessEntityId);

        System.Collections.Generic.List<UspGetManagerEmployeesReturnModel> UspGetManagerEmployees(int? businessEntityId);
        System.Collections.Generic.List<UspGetManagerEmployeesReturnModel> UspGetManagerEmployees(int? businessEntityId, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetManagerEmployeesReturnModel>> UspGetManagerEmployeesAsync(int? businessEntityId);

        System.Collections.Generic.List<UspGetWhereUsedProductIdReturnModel> UspGetWhereUsedProductId(int? startProductId, System.DateTime? checkDate);
        System.Collections.Generic.List<UspGetWhereUsedProductIdReturnModel> UspGetWhereUsedProductId(int? startProductId, System.DateTime? checkDate, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<UspGetWhereUsedProductIdReturnModel>> UspGetWhereUsedProductIdAsync(int? startProductId, System.DateTime? checkDate);

        int UspLogError(out int? errorLogId);
        // UspLogErrorAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int UspPrintError();
        // UspPrintErrorAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int UspSearchCandidateResumes(string searchString, bool? useInflectional, bool? useThesaurus, int? language);
        // UspSearchCandidateResumesAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int UspUpdateEmployeeHireInfo(int? businessEntityId, string jobTitle, System.DateTime? hireDate, System.DateTime? rateChangeDate, decimal? rate, byte? payFrequency, bool? currentFlag);
        // UspUpdateEmployeeHireInfoAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int UspUpdateEmployeeLogin(int? businessEntityId, System.Data.Entity.Hierarchy.HierarchyId organizationNode, string loginId, string jobTitle, System.DateTime? hireDate, bool? currentFlag);
        // UspUpdateEmployeeLoginAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int UspUpdateEmployeePersonalInfo(int? businessEntityId, string nationalIdNumber, System.DateTime? birthDate, string maritalStatus, string gender);
        // UspUpdateEmployeePersonalInfoAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

    }

}
// </auto-generated>
