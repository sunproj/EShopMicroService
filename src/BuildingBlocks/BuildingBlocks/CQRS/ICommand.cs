﻿using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks.CQRS
{
	public interface ICommand<TResponse>:IRequest<TResponse>
	{

	}

	public interface ICommand : IRequest<Unit>
	{

	}
}
