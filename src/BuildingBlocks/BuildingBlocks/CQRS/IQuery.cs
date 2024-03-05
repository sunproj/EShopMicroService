using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks.CQRS
{
	public interface IQuery<out T> : IRequest<T>
		where T :notnull
	{

	}

	public interface IQuery : IRequest<Unit>
	{

	}
}
