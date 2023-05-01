using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeLogger.Domain.Models
{
    public class KnowledgeLog : Entity
    {
        public string? Title { get; set; }
        public string? ShortDescription { get; set; }
        public byte[] LongDescription { get; set; }
        public string? Author {  get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public int CategoryId { get; set; }
        public decimal Rating { get; set; }

        /* EF Relation */
        public Category? Category { get; set; }

    }
}
