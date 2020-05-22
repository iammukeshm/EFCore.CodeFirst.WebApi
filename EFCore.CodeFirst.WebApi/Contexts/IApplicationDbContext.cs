using EFCore.CodeFirst.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EFCore.CodeFirst.WebApi.Contexts
{
    public interface IApplicationDbContext
    {
        DbSet<Student> Students { get; set; }

        Task<int> SaveChanges();
    }
}