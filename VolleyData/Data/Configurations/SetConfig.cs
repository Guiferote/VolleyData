using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VolleyData.Models;

namespace VolleyData.Data.Configurations {
    public class SetConfig : IEntityTypeConfiguration<Set> {
        public void Configure(EntityTypeBuilder<Set> builder) {
           
        }
    }
}
