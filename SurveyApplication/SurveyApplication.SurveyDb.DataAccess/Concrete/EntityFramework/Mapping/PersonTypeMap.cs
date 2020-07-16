using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using SurveyApplication.SurveyDb.Entities.Concrete;

namespace SurveyApplication.SurveyDb.DataAccess.Concrete.EntityFramework.Mapping
{
    public class PersonTypeMap:EntityTypeConfiguration<PersonType>
    {
        public PersonTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PersonTypes");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
