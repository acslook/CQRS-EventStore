using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Core.Commands
{
    public class EditMessageCommand : BaseCommand
    {
        public string Message { get; set; }
    }
}