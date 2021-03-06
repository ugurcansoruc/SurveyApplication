using System.Data.Entity.ModelConfiguration;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.DataAccess.Concrete.EntityFramework.Mapping
{
    public class QuestionResponseOptionMap : EntityTypeConfiguration<QuestionResponseOption>
    {
        public QuestionResponseOptionMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Text)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("QuestionResponseOptions");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.QuestionId).HasColumnName("QuestionId");
            this.Property(t => t.Text).HasColumnName("Text");

            // Relationships
            this.HasRequired(t => t.Question)
                .WithMany(t => t.QuestionResponseOptions)
                .HasForeignKey(d => d.QuestionId);

        }
    }
}
