using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.DataAccess.Concrete.EntityFramework.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonId);

            // Properties
            this.Property(t => t.PersonId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Users");
            this.Property(t => t.PersonId).HasColumnName("PersonId");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.GenderId).HasColumnName("GenderId");
            this.Property(t => t.CityId).HasColumnName("CityId");

            // Relationships
            this.HasRequired(t => t.City)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.CityId);
            this.HasRequired(t => t.Gender)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.GenderId);
            this.HasRequired(t => t.Person)
                .WithOptional(t => t.User);

        }
    }
}
