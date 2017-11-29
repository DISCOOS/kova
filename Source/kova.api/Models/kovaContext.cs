using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace kova.api.Models
{
    public partial class kovaContext : DbContext
    {
        public virtual DbSet<TFileStoreFile> TFileStoreFile { get; set; }
        public virtual DbSet<TFileStoreFileShare> TFileStoreFileShare { get; set; }
        public virtual DbSet<TOrganizationArea> TOrganizationArea { get; set; }
        public virtual DbSet<TOrganizationCertification> TOrganizationCertification { get; set; }
        public virtual DbSet<TOrganizationComNumber> TOrganizationComNumber { get; set; }
        public virtual DbSet<TOrganizationCourse> TOrganizationCourse { get; set; }
        public virtual DbSet<TOrganizationCourseGroup> TOrganizationCourseGroup { get; set; }
        public virtual DbSet<TOrganizationEquipment> TOrganizationEquipment { get; set; }
        public virtual DbSet<TOrganizationEvent> TOrganizationEvent { get; set; }
        public virtual DbSet<TOrganizationEventCrew> TOrganizationEventCrew { get; set; }
        public virtual DbSet<TOrganizationEventLog> TOrganizationEventLog { get; set; }
        public virtual DbSet<TOrganizationEventParticipant> TOrganizationEventParticipant { get; set; }
        public virtual DbSet<TOrganizationEventParticipantRole> TOrganizationEventParticipantRole { get; set; }
        public virtual DbSet<TOrganizationEventType> TOrganizationEventType { get; set; }
        public virtual DbSet<TOrganizationExternalMember> TOrganizationExternalMember { get; set; }
        public virtual DbSet<TOrganizationGroup> TOrganizationGroup { get; set; }
        public virtual DbSet<TOrganizationGroupMember> TOrganizationGroupMember { get; set; }
        public virtual DbSet<TOrganizationHiddenCourse> TOrganizationHiddenCourse { get; set; }
        public virtual DbSet<TOrganizationMailMessageTemplate> TOrganizationMailMessageTemplate { get; set; }
        public virtual DbSet<TOrganizationMap> TOrganizationMap { get; set; }
        public virtual DbSet<TOrganizationMemberGroup> TOrganizationMemberGroup { get; set; }
        public virtual DbSet<TOrganizationMessageGroup> TOrganizationMessageGroup { get; set; }
        public virtual DbSet<TOrganizationMessageGroupMember> TOrganizationMessageGroupMember { get; set; }
        public virtual DbSet<TOrganizationMessageLog> TOrganizationMessageLog { get; set; }
        public virtual DbSet<TOrganizationOrganization> TOrganizationOrganization { get; set; }
        public virtual DbSet<TOrganizationPerson> TOrganizationPerson { get; set; }
        public virtual DbSet<TOrganizationPersonEquipment> TOrganizationPersonEquipment { get; set; }
        public virtual DbSet<TOrganizationPersonPosition> TOrganizationPersonPosition { get; set; }
        public virtual DbSet<TOrganizationPoi> TOrganizationPoi { get; set; }
        public virtual DbSet<TOrganizationPosition> TOrganizationPosition { get; set; }
        public virtual DbSet<TOrganizationProject> TOrganizationProject { get; set; }
        public virtual DbSet<TOrganizationQualification> TOrganizationQualification { get; set; }
        public virtual DbSet<TOrganizationQualificationCourse> TOrganizationQualificationCourse { get; set; }
        public virtual DbSet<TOrganizationQualificationCriteria> TOrganizationQualificationCriteria { get; set; }
        public virtual DbSet<TOrganizationSmsNotificationReference> TOrganizationSmsNotificationReference { get; set; }
        public virtual DbSet<TOrganizationTask> TOrganizationTask { get; set; }
        public virtual DbSet<TOrganizationTaskLog> TOrganizationTaskLog { get; set; }
        public virtual DbSet<TOrganizationTrack> TOrganizationTrack { get; set; }
        public virtual DbSet<TOrganizationTracker> TOrganizationTracker { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TFileStoreFile>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_FileStore_File");

                entity.ToTable("t_FileStore_File");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FieldName).HasMaxLength(128);

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.FileShareRefNavigation)
                    .WithMany(p => p.TFileStoreFile)
                    .HasForeignKey(d => d.FileShareRef)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("r_FileStore_FileShare_Files");
            });

            modelBuilder.Entity<TFileStoreFileShare>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_FileStore_FileShare");

                entity.ToTable("t_FileStore_FileShare");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.FileShare)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");
            });
            
            modelBuilder.Entity<TOrganizationArea>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_Area");

                entity.ToTable("t_Organization_Area");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.FillColor).HasMaxLength(10);

                entity.Property(e => e.LineColor).HasMaxLength(10);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.MapRefNavigation)
                    .WithMany(p => p.TOrganizationArea)
                    .HasForeignKey(d => d.MapRef)
                    .HasConstraintName("r_Organization_Map_Areas");
            });

            modelBuilder.Entity<TOrganizationCertification>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_Certification");

                entity.ToTable("t_Organization_Certification");

                entity.HasIndex(e => new { e.PersonRef, e.CourseRef })
                    .HasName("IX_t_Organization_Certification");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.CourseRefNavigation)
                    .WithMany(p => p.TOrganizationCertification)
                    .HasForeignKey(d => d.CourseRef)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("r_Organization_Course_Certifications");

                entity.HasOne(d => d.PersonRefNavigation)
                    .WithMany(p => p.TOrganizationCertification)
                    .HasForeignKey(d => d.PersonRef)
                    .HasConstraintName("r_Organization_Person_Certifications");
            });

            modelBuilder.Entity<TOrganizationComNumber>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_ComNumber");

                entity.ToTable("t_Organization_ComNumber");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Color).HasColumnType("nchar(10)");

                entity.Property(e => e.ComNumber).HasMaxLength(50);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Symbol).HasMaxLength(50);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");
            });

            modelBuilder.Entity<TOrganizationCourse>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_Course");

                entity.ToTable("t_Organization_Course");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.CourseGroupRefNavigation)
                    .WithMany(p => p.TOrganizationCourse)
                    .HasForeignKey(d => d.CourseGroupRef)
                    .HasConstraintName("r_Organization_CourseGroup_Courses");
            });

            modelBuilder.Entity<TOrganizationCourseGroup>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_CourseGroup");

                entity.ToTable("t_Organization_CourseGroup");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");
            });

            modelBuilder.Entity<TOrganizationEquipment>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_Equipment");

                entity.ToTable("t_Organization_Equipment");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.OrganizationRefNavigation)
                    .WithMany(p => p.TOrganizationEquipment)
                    .HasForeignKey(d => d.OrganizationRef)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("r_Organization_Organization_Equipment");
            });

            modelBuilder.Entity<TOrganizationEvent>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_Event");

                entity.ToTable("t_Organization_Event");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.ContactName).HasMaxLength(255);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.InvoiceStatus).HasMaxLength(50);

                entity.Property(e => e.Location).HasMaxLength(100);

                entity.Property(e => e.LockedForSignIn).HasDefaultValueSql("0");

                entity.Property(e => e.LockedForSignOut).HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.EventTypeRefNavigation)
                    .WithMany(p => p.TOrganizationEvent)
                    .HasForeignKey(d => d.EventTypeRef)
                    .HasConstraintName("r_Organization_EventType_Events");

                entity.HasOne(d => d.OrganizationRefNavigation)
                    .WithMany(p => p.TOrganizationEvent)
                    .HasForeignKey(d => d.OrganizationRef)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("r_Organization_Organization_Events");

                entity.HasOne(d => d.ResponsibleRefNavigation)
                    .WithMany(p => p.TOrganizationEvent)
                    .HasForeignKey(d => d.ResponsibleRef)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("r_Organization_Person_ResponsibleForEvents");
            });

            modelBuilder.Entity<TOrganizationEventCrew>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_EventCrew");

                entity.ToTable("t_Organization_EventCrew");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.LogHoursAsDuty).HasDefaultValueSql("1");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.EventRefNavigation)
                    .WithMany(p => p.TOrganizationEventCrew)
                    .HasForeignKey(d => d.EventRef)
                    .HasConstraintName("r_Organization_Event_Crew");
            });

            modelBuilder.Entity<TOrganizationEventLog>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_EventLog");

                entity.ToTable("t_Organization_EventLog");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.Public).HasDefaultValueSql("0");

                entity.Property(e => e.ReportText).IsRequired();

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.EventCrewRefNavigation)
                    .WithMany(p => p.TOrganizationEventLog)
                    .HasForeignKey(d => d.EventCrewRef)
                    .HasConstraintName("r_Organization_EventCrew_Log");

                entity.HasOne(d => d.PersonRefNavigation)
                    .WithMany(p => p.TOrganizationEventLog)
                    .HasForeignKey(d => d.PersonRef)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("r_Organization_Person_EventLog");
            });

            modelBuilder.Entity<TOrganizationEventParticipant>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_EventParticipant");

                entity.ToTable("t_Organization_EventParticipant");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.Optional).HasDefaultValueSql("0");

                entity.Property(e => e.Order).HasDefaultValueSql("0");

                entity.Property(e => e.Role).HasMaxLength(50);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.EventCrewRefNavigation)
                    .WithMany(p => p.TOrganizationEventParticipant)
                    .HasForeignKey(d => d.EventCrewRef)
                    .HasConstraintName("r_Organization_EventCrew_Participants");

                entity.HasOne(d => d.EventParticipantRoleRefNavigation)
                    .WithMany(p => p.TOrganizationEventParticipant)
                    .HasForeignKey(d => d.EventParticipantRoleRef)
                    .HasConstraintName("r_Organization_EventParticipantRole_Participants");

                entity.HasOne(d => d.PersonRefNavigation)
                    .WithMany(p => p.TOrganizationEventParticipant)
                    .HasForeignKey(d => d.PersonRef)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("r_Organization_Person_EventParticipitation");
            });

            modelBuilder.Entity<TOrganizationEventParticipantRole>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_EventParticipantRole");

                entity.ToTable("t_Organization_EventParticipantRole");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.Role).HasMaxLength(50);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");
            });

            modelBuilder.Entity<TOrganizationEventType>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_EventType");

                entity.ToTable("t_Organization_EventType");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.BackgroundColor).HasColumnType("varchar(50)");

                entity.Property(e => e.CountAsDuty).HasDefaultValueSql("0");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.ForegroundColor).HasColumnType("varchar(50)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OpenForRegistration).HasDefaultValueSql("1");

                entity.Property(e => e.ShowInCalendar).HasDefaultValueSql("0");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");
            });

            modelBuilder.Entity<TOrganizationExternalMember>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_ExternalMember");

                entity.ToTable("t_Organization_ExternalMember");

                entity.HasIndex(e => new { e.OrganizationRef, e.PersonRef })
                    .HasName("IX_t_Organization_ExternalMember")
                    .IsUnique();

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.MemberGroupRefNavigation)
                    .WithMany(p => p.TOrganizationExternalMember)
                    .HasForeignKey(d => d.MemberGroupRef)
                    .HasConstraintName("r_Organization_MemberGroup_ExternalMembers");

                entity.HasOne(d => d.OrganizationRefNavigation)
                    .WithMany(p => p.TOrganizationExternalMember)
                    .HasForeignKey(d => d.OrganizationRef)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("r_Organization_Organization_ExternalMembers");

                entity.HasOne(d => d.PersonRefNavigation)
                    .WithMany(p => p.TOrganizationExternalMember)
                    .HasForeignKey(d => d.PersonRef)
                    .HasConstraintName("r_Organization_Person_ExternalMembership");
            });

            modelBuilder.Entity<TOrganizationGroup>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_Group");

                entity.ToTable("t_Organization_Group");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.OrganizationRefNavigation)
                    .WithMany(p => p.TOrganizationGroup)
                    .HasForeignKey(d => d.OrganizationRef)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("r_Organization_Organization_Groups");
            });

            modelBuilder.Entity<TOrganizationGroupMember>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_GroupMember");

                entity.ToTable("t_Organization_GroupMember");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.GroupRefNavigation)
                    .WithMany(p => p.TOrganizationGroupMember)
                    .HasForeignKey(d => d.GroupRef)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("r_Organization_Group_Members");

                entity.HasOne(d => d.PersonRefNavigation)
                    .WithMany(p => p.TOrganizationGroupMember)
                    .HasForeignKey(d => d.PersonRef)
                    .HasConstraintName("r_Organization_Person_Membership");
            });

            modelBuilder.Entity<TOrganizationHiddenCourse>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_HiddenCourse");

                entity.ToTable("t_Organization_HiddenCourse");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.CourseRefNavigation)
                    .WithMany(p => p.TOrganizationHiddenCourse)
                    .HasForeignKey(d => d.CourseRef)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("r_Organization_Course_HiddenCourses");

                entity.HasOne(d => d.OrganizationRefNavigation)
                    .WithMany(p => p.TOrganizationHiddenCourse)
                    .HasForeignKey(d => d.OrganizationRef)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("r_Organization_Organization_HiddenCourses");
            });

            modelBuilder.Entity<TOrganizationMailMessageTemplate>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_MailMessageTemplate");

                entity.ToTable("t_Organization_MailMessageTemplate");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.Subject).HasMaxLength(200);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.OrganizationRefNavigation)
                    .WithMany(p => p.TOrganizationMailMessageTemplate)
                    .HasForeignKey(d => d.OrganizationRef)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("r_Organization_Organization_MailMessageTemplates");
            });

            modelBuilder.Entity<TOrganizationMap>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_PoiCollection");

                entity.ToTable("t_Organization_Map");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.OrganizationRefNavigation)
                    .WithMany(p => p.TOrganizationMap)
                    .HasForeignKey(d => d.OrganizationRef)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("r_Organization_Organization_Maps");
            });

            modelBuilder.Entity<TOrganizationMemberGroup>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_MemberGroup");

                entity.ToTable("t_Organization_MemberGroup");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Active).HasDefaultValueSql("1");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Order).HasDefaultValueSql("0");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.OrganizationRefNavigation)
                    .WithMany(p => p.TOrganizationMemberGroup)
                    .HasForeignKey(d => d.OrganizationRef)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("r_Organization_Organization_MemberGroups");
            });

            modelBuilder.Entity<TOrganizationMessageGroup>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_MessageGroup");

                entity.ToTable("t_Organization_MessageGroup");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Restricted).HasDefaultValueSql("0");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.OrganizationRefNavigation)
                    .WithMany(p => p.TOrganizationMessageGroup)
                    .HasForeignKey(d => d.OrganizationRef)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("r_Organization_Organization_MessageGroups");
            });

            modelBuilder.Entity<TOrganizationMessageGroupMember>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_MessageGroupMember");

                entity.ToTable("t_Organization_MessageGroupMember");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.MessageGroupRefNavigation)
                    .WithMany(p => p.TOrganizationMessageGroupMember)
                    .HasForeignKey(d => d.MessageGroupRef)
                    .HasConstraintName("r_Organization_MessageGroup_Members");

                entity.HasOne(d => d.PersonRefNavigation)
                    .WithMany(p => p.TOrganizationMessageGroupMember)
                    .HasForeignKey(d => d.PersonRef)
                    .HasConstraintName("r_Organization_Person_MessageGroups");
            });

            modelBuilder.Entity<TOrganizationMessageLog>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_MessageLog");

                entity.ToTable("t_Organization_MessageLog");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.Message).IsRequired();

                entity.Property(e => e.Sender).HasMaxLength(100);

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.OrganizationRefNavigation)
                    .WithMany(p => p.TOrganizationMessageLog)
                    .HasForeignKey(d => d.OrganizationRef)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("r_Organization_Organization_MessageLog");
            });

            modelBuilder.Entity<TOrganizationOrganization>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_Organization");

                entity.ToTable("t_Organization_Organization");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.AllowSelfCertification).HasDefaultValueSql("0");

                entity.Property(e => e.AllowSmsNotifications).HasDefaultValueSql("0");

                entity.Property(e => e.ApiKey).HasMaxLength(100);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.Department).HasMaxLength(100);

                entity.Property(e => e.EmergencyPhoneNumber).HasMaxLength(50);

                entity.Property(e => e.GmailPassword).HasMaxLength(100);

                entity.Property(e => e.GmailUsername).HasMaxLength(100);

                entity.Property(e => e.LogoUrl).HasMaxLength(512);

                entity.Property(e => e.MeshFolder).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.PublicCalendarKey).HasMaxLength(100);

                entity.Property(e => e.ShortName).HasMaxLength(20);

                entity.Property(e => e.SmsProvider).HasMaxLength(50);

                entity.Property(e => e.SmsSender).HasMaxLength(50);

                entity.Property(e => e.TelemenyPassword).HasMaxLength(100);

                entity.Property(e => e.TelemenyUsername).HasMaxLength(100);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UmsGroup).HasMaxLength(100);

                entity.Property(e => e.UmsPassword).HasMaxLength(100);

                entity.Property(e => e.UmsUsername).HasMaxLength(100);

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");
            });

            modelBuilder.Entity<TOrganizationPerson>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_Person");

                entity.ToTable("t_Organization_Person");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.CardId)
                    .HasColumnName("CardID")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Employer).HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Hash).HasMaxLength(100);

                entity.Property(e => e.InRkhlist).HasColumnName("InRKHList");

                entity.Property(e => e.InRklist).HasColumnName("InRKList");

                entity.Property(e => e.Issi)
                    .HasColumnName("ISSI")
                    .HasMaxLength(50);

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MemberFrom).HasColumnType("date");

                entity.Property(e => e.MemberNumber).HasColumnType("varchar(50)");

                entity.Property(e => e.NextOfKin).HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.PhoneMobile).HasColumnType("varchar(20)");

                entity.Property(e => e.PhonePriv).HasColumnType("varchar(20)");

                entity.Property(e => e.Position).HasMaxLength(100);

                entity.Property(e => e.PostalCode).HasColumnType("varchar(50)");

                entity.Property(e => e.PublicCalendarKey).HasMaxLength(50);

                entity.Property(e => e.Salt).HasMaxLength(100);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.MemberGroupRefNavigation)
                    .WithMany(p => p.TOrganizationPerson)
                    .HasForeignKey(d => d.MemberGroupRef)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("r_Organization_MemberGroup_Persons");

                entity.HasOne(d => d.PassportPhotoRefNavigation)
                    .WithMany(p => p.TOrganizationPerson)
                    .HasForeignKey(d => d.PassportPhotoRef)
                    .HasConstraintName("r_FileStore_File_PersonPassportPhotos");
            });

            modelBuilder.Entity<TOrganizationPersonEquipment>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_PersonEquipment");

                entity.ToTable("t_Organization_PersonEquipment");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.In).HasColumnType("datetime");

                entity.Property(e => e.Lost).HasColumnType("datetime");

                entity.Property(e => e.Out).HasColumnType("datetime");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.EquipmentRefNavigation)
                    .WithMany(p => p.TOrganizationPersonEquipment)
                    .HasForeignKey(d => d.EquipmentRef)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("r_Organization_Equipment_PersonEquipment");

                entity.HasOne(d => d.PersonRefNavigation)
                    .WithMany(p => p.TOrganizationPersonEquipment)
                    .HasForeignKey(d => d.PersonRef)
                    .HasConstraintName("r_Organization_Person_PersonEquipment");
            });

            modelBuilder.Entity<TOrganizationPersonPosition>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_PersonPosition");

                entity.ToTable("t_Organization_PersonPosition");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.From).HasColumnType("date");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.To).HasColumnType("date");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.OrganizationRefNavigation)
                    .WithMany(p => p.TOrganizationPersonPosition)
                    .HasForeignKey(d => d.OrganizationRef)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("r_Organization_Organization_Positions");

                entity.HasOne(d => d.PersonRefNavigation)
                    .WithMany(p => p.TOrganizationPersonPosition)
                    .HasForeignKey(d => d.PersonRef)
                    .HasConstraintName("r_Organization_Person_Positions");

                entity.HasOne(d => d.PositionRefNavigation)
                    .WithMany(p => p.TOrganizationPersonPosition)
                    .HasForeignKey(d => d.PositionRef)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("r_Organization_Position_Persons");
            });

            modelBuilder.Entity<TOrganizationPoi>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_Poi");

                entity.ToTable("t_Organization_Poi");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.Property(e => e.Symbol).HasColumnType("varchar(50)");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.MapRefNavigation)
                    .WithMany(p => p.TOrganizationPoi)
                    .HasForeignKey(d => d.MapRef)
                    .HasConstraintName("r_Organization_Map_Pois");
            });

            modelBuilder.Entity<TOrganizationPosition>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_Position");

                entity.ToTable("t_Organization_Position");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.BoardMember).HasDefaultValueSql("0");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Order).HasDefaultValueSql("0");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");
            });

            modelBuilder.Entity<TOrganizationProject>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_Project");

                entity.ToTable("t_Organization_Project");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.OrganizationRefNavigation)
                    .WithMany(p => p.TOrganizationProject)
                    .HasForeignKey(d => d.OrganizationRef)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("r_Organization_Organization_Projects");
            });

            modelBuilder.Entity<TOrganizationQualification>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_Qualification");

                entity.ToTable("t_Organization_Qualification");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.Level).HasDefaultValueSql("0");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Track)
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");
            });

            modelBuilder.Entity<TOrganizationQualificationCourse>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_QualificationCourse");

                entity.ToTable("t_Organization_QualificationCourse");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.CourseRefNavigation)
                    .WithMany(p => p.TOrganizationQualificationCourse)
                    .HasForeignKey(d => d.CourseRef)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("r_Organization_Course_QualificationCriteria");

                entity.HasOne(d => d.CriteriaRefNavigation)
                    .WithMany(p => p.TOrganizationQualificationCourse)
                    .HasForeignKey(d => d.CriteriaRef)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("r_Organization_QualificationCriteria_Courses");
            });

            modelBuilder.Entity<TOrganizationQualificationCriteria>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_QualificationCriteria");

                entity.ToTable("t_Organization_QualificationCriteria");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.QualificationRefNavigation)
                    .WithMany(p => p.TOrganizationQualificationCriteria)
                    .HasForeignKey(d => d.QualificationRef)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("r_Organization_Qualification_Criteria");
            });

            modelBuilder.Entity<TOrganizationSmsNotificationReference>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_SmsNotificationReference");

                entity.ToTable("t_Organization_SmsNotificationReference");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.PersonRefNavigation)
                    .WithMany(p => p.TOrganizationSmsNotificationReference)
                    .HasForeignKey(d => d.PersonRef)
                    .HasConstraintName("r_Organization_Person_SmsNotificationReferences");
            });

            modelBuilder.Entity<TOrganizationTask>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_Task");

                entity.ToTable("t_Organization_Task");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.FirstDue).HasColumnType("datetime");

                entity.Property(e => e.RecurrenceEnd).HasColumnType("datetime");

                entity.Property(e => e.RecurrenceType).HasColumnType("varchar(50)");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.AssignedToRefNavigation)
                    .WithMany(p => p.TOrganizationTask)
                    .HasForeignKey(d => d.AssignedToRef)
                    .HasConstraintName("r_Organization_Person_AssignedTasks");

                entity.HasOne(d => d.OrganizationRefNavigation)
                    .WithMany(p => p.TOrganizationTask)
                    .HasForeignKey(d => d.OrganizationRef)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("r_Organization_Organization_Tasks");

                entity.HasOne(d => d.ProjectRefNavigation)
                    .WithMany(p => p.TOrganizationTask)
                    .HasForeignKey(d => d.ProjectRef)
                    .HasConstraintName("r_Organization_Project_Tasks");
            });

            modelBuilder.Entity<TOrganizationTaskLog>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_TaskLog");

                entity.ToTable("t_Organization_TaskLog");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.LogByRefNavigation)
                    .WithMany(p => p.TOrganizationTaskLog)
                    .HasForeignKey(d => d.LogByRef)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("r_Organization_Person_TaskLogEntries");

                entity.HasOne(d => d.TaskRefNavigation)
                    .WithMany(p => p.TOrganizationTaskLog)
                    .HasForeignKey(d => d.TaskRef)
                    .HasConstraintName("r_Organization_Task_LogEntries");
            });

            modelBuilder.Entity<TOrganizationTrack>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_Track");

                entity.ToTable("t_Organization_Track");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Color).HasMaxLength(10);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.MapRefNavigation)
                    .WithMany(p => p.TOrganizationTrack)
                    .HasForeignKey(d => d.MapRef)
                    .HasConstraintName("r_Organization_Map_Tracks");
            });

            modelBuilder.Entity<TOrganizationTracker>(entity =>
            {
                entity.HasKey(e => e.PrimKey)
                    .HasName("PK_t_Organization_Tracker");

                entity.ToTable("t_Organization_Tracker");

                entity.Property(e => e.PrimKey).HasDefaultValueSql("newsequentialid()");

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.ComDivision).HasMaxLength(50);

                entity.Property(e => e.ComNumber).HasMaxLength(50);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.Property(e => e.From).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Symbol).HasMaxLength(50);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.To).HasColumnType("datetime");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("suser_sname()");

                entity.HasOne(d => d.MapRefNavigation)
                    .WithMany(p => p.TOrganizationTracker)
                    .HasForeignKey(d => d.MapRef)
                    .HasConstraintName("r_Organization_Map_Trackers");
            });
        }
    }
}