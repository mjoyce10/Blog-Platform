using blog_template_practice.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_template_practice.Repositories
{
    public class ContentRepository : Repository<Content>, IRepository<Content>
    {
        private DbContext db;

        public ContentRepository(BlogContext db) : base(db)
        {
            this.db = db;
        }


        public override IEnumerable<Content> GetAll()
        {
            return db.Set<Content>().Include("Category");
        }

    }
}
