using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using VolleyData.Models;

namespace VolleyData.Data.Configurations {
    public class AtletaConfig : IEntityTypeConfiguration<Atleta> {
        
            public void Configure(EntityTypeBuilder<Atleta> builder) {

            }
        
    }
}

