﻿namespace CRUD.Infrastructure.POCOs
{
    public interface IEntity<TId>
    {
        TId Id { get; set; }
    }
}