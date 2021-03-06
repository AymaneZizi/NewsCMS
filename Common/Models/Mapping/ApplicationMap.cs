using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Tazeyab.Common.Models.Mapping
{
    public class ApplicationMap : EntityTypeConfiguration<Application>
    {
        public ApplicationMap()
        {
            // Primary Key
            this.HasKey(t => t.ApplicationId);

            // Properties
            this.Property(t => t.ApplicationName)
                .IsRequired()
                .HasMaxLength(235);

            this.Property(t => t.Description)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("Applications");
            this.Property(t => t.ApplicationName).HasColumnName("ApplicationName");
            this.Property(t => t.ApplicationId).HasColumnName("ApplicationId");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
