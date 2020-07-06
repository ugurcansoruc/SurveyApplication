using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SurveyApplication.SurveyDb.Entities.Models.Mapping
{
    public class ManagerMap : EntityTypeConfiguration<Manager>
    {
        public ManagerMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonId);

            // Properties
            this.Property(t => t.PersonId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Managers");
            this.Property(t => t.PersonId).HasColumnName("PersonId");
            this.Property(t => t.GroupId).HasColumnName("GroupId");

            // Relationships
            this.HasRequired(t => t.Group)
                .WithMany(t => t.Managers)
                .HasForeignKey(d => d.GroupId);
            this.HasRequired(t => t.Person)
                .WithOptional(t => t.Manager);

        }
    }
}
