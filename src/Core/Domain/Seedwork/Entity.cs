﻿using Dtat.Seedwork.Abstractions;
using System;

namespace Domain.Seedwork;

//public class Entity : object
//{
//}

//public class Entity<TStronglyTypedId, TValue>
//	: object,
//	Dtat.Seedwork.Abstractions.IEntity<TStronglyTypedId, TValue>
//	where TValue : notnull
//	where TStronglyTypedId : IStronglyTypedId<TValue>
//{
//	public Entity(TStronglyTypedId id) : base()
//	{
//		Id = id;
//	}

//	public TStronglyTypedId Id { get; init; }
//}

public class Entity	: object, IEntity
{
	//public Entity(Guid id) : base()
	//{
	//	Id = id;
	//}

	public Guid Id { get; init; } = Guid.NewGuid();
}
