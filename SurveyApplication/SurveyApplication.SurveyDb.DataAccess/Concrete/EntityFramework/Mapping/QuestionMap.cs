using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.DataAccess.Concrete.EntityFramework.Mapping
{
    public class QuestionMap : EntityTypeConfiguration<Question>
    {
        public QuestionMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Text)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Questions");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.QuestionTypeId).HasColumnName("QuestionTypeId");
            this.Property(t => t.Text).HasColumnName("Text");

            // Relationships
            this.HasMany(t => t.Surveys)
                .WithMany(t => t.Questions)
                .Map(m =>
                    {
                        m.ToTable("SurveysQuestions");
                        m.MapLeftKey("QuestionId");
                        m.MapRightKey("SurveyId");
                    });

            this.HasRequired(t => t.QuestionType)
                .WithMany(t => t.Questions)
                .HasForeignKey(d => d.QuestionTypeId);

        }
    }
}
