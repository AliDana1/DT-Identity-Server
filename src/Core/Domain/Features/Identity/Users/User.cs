﻿using Domain.Seedwork;
using Domain.SharedKernel;
using Dtat.Seedwork.Abstractions;
using System.Collections.Generic;
using Domain.Features.Identity.Companies;

namespace Domain.Features.Identity.Users;

public class User :
	AggregateRoot, IEntityHasIsActive
{
#pragma warning disable CS8618
	private User() : base()
	{
	}
#pragma warning restore CS8618

	public User(Username username, Password password, EmailAddress emailAddress) : base()
	{
		Password = password;
		Username = username;
		EmailAddress = emailAddress;
	}

	public Username Username { get; set; }
	//public Username Username { get; private set; }

	public Password Password { get; private set; }

	public EmailAddress EmailAddress { get; private set; }

	public bool IsActive { get; private set; }

	public virtual IList<Company> Companies { get; } = [];
}
