using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VolleyData.Models;

namespace VolleyData.Data.Configurations {
    public class EquipeConfig : IEntityTypeConfiguration<Equipe> {
        public void Configure(EntityTypeBuilder<Equipe> builder) {
            
        }
    }
}
