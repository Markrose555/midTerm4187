﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.EntityFrameworkCore;
using midTerm.Data.Entities;

namespace midTerm.Data
{
    public class midTermDbContext  : DbContext
    {
        public midTermDbContext(DbContextOptions<midTermDbContext> options) : base(options)
        {
            
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<SurveyUser> SurveyUsers { get; set; }
        public DbSet<Answers> Answers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>(question =>
            {
                question.Property(q => q.Id).IsRequired();
                question.Property(q => q.Text).IsRequired();
                question.HasKey(q => q.Id);
                question.HasMany(q => q.Options);
                question.Property(q => q.Options).IsRequired();
            });

            modelBuilder.Entity<Option>(option =>
            {
                option.Property(o => o.Id).IsRequired();
                option.Property(o => o.Text).IsRequired();
                option.Property(o => o.QuestionId).IsRequired();
                option.HasOne(o => o.Question);
                option.HasKey(o => o.Id);
            });

            modelBuilder.Entity<Answers>(answer =>
            {
                answer.Property(a => a.Id).IsRequired();
                answer.Property(a => a.OptionId).IsRequired();
                answer.HasKey(a => a.Id);
                answer.HasOne(a => a.Option);
            });

            modelBuilder.Entity<SurveyUser>(surveyuser =>
            {
                surveyuser.Property(su => su.Id).IsRequired();
                surveyuser.Property(su => su.FirstName).IsRequired();
                surveyuser.Property(su => su.Gender).IsRequired();
                surveyuser.HasKey(su => su.Id);
            });
        }

    }
}
