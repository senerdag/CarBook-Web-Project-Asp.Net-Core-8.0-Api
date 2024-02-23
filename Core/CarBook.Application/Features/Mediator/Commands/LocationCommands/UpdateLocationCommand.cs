using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.LocationCommands
{
    public class UpdateLocationCommand:IRequest
    {
        public int LocationId { get; set; }
        public string Name { get; set; }
    }
}
