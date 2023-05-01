using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeLogger.Domain.Models
{
    public class Category : Entity
    {
        public string? Name { get; set; }

        /* EF Relations */
        public IEnumerable<KnowledgeLog>? KnowledgeLog { get; set; }
    }
}
