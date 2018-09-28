namespace CRUD.Api.Test
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;

    using Core;

    using FizzWare.NBuilder;

    using Infrastructure.POCOs;

    using Microsoft.AspNetCore.Mvc.Testing;
    using Microsoft.Extensions.DependencyInjection;

    using Moq;

    using Newtonsoft.Json.Linq;

    using Shouldly;

    using Xunit;

    public class UnitTest1 : EndToEndTest
    {
        private IADWContext dbContext;

        public UnitTest1(WebApplicationFactory<Startup> factory)
            : base(factory)
        {
            Startup.RegisterDbContext = services =>
                                            {
                                                var contextMock = new Mock<IADWContext>();
                                                ConfigureFakeDbSet<Location, short>(contextMock);
                                                this.dbContext = contextMock.Object;
                                                services.AddScoped(_ => this.dbContext);
                                            };
        }

        [Fact]
        public async Task Test1()
        {
            var response = await this.Client.Value.GetAsync("/api/locations");

            response.EnsureSuccessStatusCode();
            var locations = await response.Content.ReadAsync<List<Location>>(JArray.Parse);
            var originals = this.dbContext.Set<Location>().ToList();
            locations.ShouldAllBe(location => originals.SingleOrDefault(l => l.Id == location.Id) != null);
        }

        private static void ConfigureFakeDbSet<TEntity, TId>(Mock<IADWContext> contextMock)
            where TEntity : class, IEntity<TId>
        {
            var data = Builder<TEntity>.CreateListOfSize(10).Build();
            var fakeDbSetMock = new Mock<DbSet<TEntity>>().SetupData(data);
            contextMock.Setup(c => c.Set<TEntity>()).Returns(fakeDbSetMock.Object);
        }
    }
}