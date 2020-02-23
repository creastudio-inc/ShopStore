using Microsoft.EntityFrameworkCore;

namespace ShopStore.Infrastructure.Data
{
    public interface ICustomModelBuilder
    {
        void Build(ModelBuilder modelBuilder);
    }
}