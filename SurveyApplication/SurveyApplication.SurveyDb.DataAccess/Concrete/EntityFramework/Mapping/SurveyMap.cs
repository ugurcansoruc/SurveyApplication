using System.Data.Entity.ModelConfiguration;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.DataAccess.Concrete.EntityFramework.Mapping
{
    public class SurveyMap : EntityTypeConfiguration<Survey>
    {
        public SurveyMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.EndDate)
                .IsOptional();

            // Table & Column Mappings
            this.ToTable("Surveys");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.IsOpen).HasColumnName("IsOpen");
            this.Property(t => t.ManagerId).HasColumnName("ManagerId");

            // Relationships
            this.HasRequired(t => t.Manager)
                .WithMany(t => t.Surveys)
                .HasForeignKey(d => d.ManagerId);

        }
    }
}
