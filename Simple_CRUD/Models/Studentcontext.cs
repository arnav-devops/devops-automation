using Microsoft.EntityFrameworkCore;

namespace Simple_CRUD.Models
{
    public class Studentcontext : DbContext
    {
        public Studentcontext(DbContextOptions<Studentcontext> options) : base(options)
        {

        }

    }
}
