using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace People.Autentication.Models
{
    public class MappingPeople : EntityTypeConfiguration<People>
    {
        public MappingPeople()
        {
            ToTable("People");
            HasKey(x => x.Cod);
            Property(x => x.Cpf).HasMaxLength(11).IsRequired();
            Property(x => x.Uf).HasMaxLength(2).IsRequired();
            Property(x => x.Nascimento).IsRequired();
            Property(x => x.Nome).HasMaxLength(100).IsRequired();
        }
    }
}