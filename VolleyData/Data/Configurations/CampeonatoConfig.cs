using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VolleyData.Models;

namespace VolleyData.Data.Configurations {
    public class CampeonatoConfig : IEntityTypeConfiguration<Campeonato> {
        public void Configure(EntityTypeBuilder<Campeonato> builder) {

        }
    }
}
