using ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Infrastructure.Configuration
{
    public class RDVConfiguration : IEntityTypeConfiguration<RDV>
    {
        public void Configure(EntityTypeBuilder<RDV> builder)
        {
            builder
.HasOne(r => r.Client)
.WithMany(p => p.RDV)
.HasForeignKey(r => r.ClientFK);

            builder
            .HasOne(r => r.Prestation)
            .WithMany(f => f.RDV)
           .HasForeignKey(r => r.PrestationFK);
             //Pour la configuration complete de la classe Expertise il faut ajouter la clé primaire
 builder.HasKey(r => new
 {
     r.ClientFK,
     r.PrestationFK,
     r.DateRDV
 });

        }
    }
}
