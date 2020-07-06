using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SurveyApplication.SurveyDb.Entities.Models.Mapping
{
    public class AnswerMap : EntityTypeConfiguration<Answer>
    {
        public AnswerMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Answers");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.SurveyId).HasColumnName("SurveyId");
            this.Property(t => t.QuestionId).HasColumnName("QuestionId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.Choice).HasColumnName("Choice");

            // Relationships
            this.HasRequired(t => t.Question)
                .WithMany(t => t.Answers)
                .HasForeignKey(d => d.QuestionId);
            this.HasRequired(t => t.Survey)
                .WithMany(t => t.Answers)
                .HasForeignKey(d => d.SurveyId);
            this.HasRequired(t => t.User)
                .WithMany(t => t.Answers)
                .HasForeignKey(d => d.UserId);

        }
    }
}
