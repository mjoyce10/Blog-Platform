using blog_template_practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_template_practice.Repositories
{
    public class ContentRepository : Repository<Content>, IRepository<Content>
    {
        public ContentRepository(BlogContext db) : base(db)
        {

        }

    }
}
