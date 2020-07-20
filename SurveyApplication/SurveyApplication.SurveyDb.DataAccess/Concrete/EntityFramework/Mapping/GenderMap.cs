using System.Data.Entity.ModelConfiguration;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.DataAccess.Concrete.EntityFramework.Mapping
{
    public class GenderMap : EntityTypeConfiguration<Gender>
    {
        public GenderMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Genders");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
