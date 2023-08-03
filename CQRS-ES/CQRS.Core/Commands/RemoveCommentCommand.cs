using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Core.Commands
{
    public class RemoveCommentCommand : BaseCommand
    {
        public Guid CommentId { get; set; }
        public string Username { get; set; }
    }
}