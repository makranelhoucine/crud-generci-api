namespace CRUD.Api.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;

    using Infrastructure.POCOs;
    using Infrastructure.Repositories;

    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class ApiController<TEntity, TId> : ControllerBase
        where TEntity : class, IEntity<TId>
    {
        [HttpPost]
        public async Task<IActionResult> Create([FromServices] IWriter<TEntity> writer, [FromBody] TEntity record)
        {
            writer.Create(record);
            if (await writer.SaveAsync() == 0)
            {
                return this.BadRequest();
            }

            return this.CreatedAtAction("Find", new { id = record.Id }, record);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromServices] IWriter<TEntity> writer, TId id)
        {
            writer.Delete(id);
            if (await writer.SaveAsync() == 0)
            {
                return this.BadRequest();
            }

            return this.NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult Find([FromServices] IReader<TEntity> reader, TId id)
        {
            var record = reader.Get(entity => entity.Id.Equals(id), Queryable.SingleOrDefault);
            if (record == null)
            {
                return this.NotFound();
            }

            return this.Ok(record);
        }

        [HttpGet]
        public IActionResult Get([FromServices] IReader<TEntity> reader)
        {
            return this.Ok(reader.Get(entity => entity, Queryable.Select));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromServices] IWriter<TEntity> writer, TId id, [FromBody] TEntity record)
        {
            if (!id.Equals(record.Id))
            {
                return this.BadRequest();
            }

            writer.Update(record);
            if (await writer.SaveAsync() == 0)
            {
                return this.BadRequest();
            }

            return this.Ok(record);
        }
    }
}