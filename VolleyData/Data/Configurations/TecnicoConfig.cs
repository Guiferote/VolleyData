using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VolleyData.Models;

namespace VolleyData.Data.Configurations {
    public class TecnicoConfig : IEntityTypeConfiguration<Tecnico> {
        public void Configure(EntityTypeBuilder<Tecnico> builder) {
           
        }
    }
}
