using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MemoSystem.Models
{
    public partial class MemoSystemContext : DbContext
    {
        public MemoSystemContext()
        {
        }

        public MemoSystemContext(DbContextOptions<MemoSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<TbAdmin> TbAdmins { get; set; }
        public virtual DbSet<TbAuthour> TbAuthours { get; set; }
        public virtual DbSet<TbAuthourBook> TbAuthourBooks { get; set; }
        public virtual DbSet<TbBook> TbBooks { get; set; }
        public virtual DbSet<TbBookGenre> TbBookGenres { get; set; }
        public virtual DbSet<TbBookLanguage> TbBookLanguages { get; set; }
        public virtual DbSet<TbBookTopic> TbBookTopics { get; set; }
        public virtual DbSet<TbComment> TbComments { get; set; }
        public virtual DbSet<TbFormat> TbFormats { get; set; }
        public virtual DbSet<TbGenre> TbGenres { get; set; }
        public virtual DbSet<TbLanguage> TbLanguages { get; set; }
        public virtual DbSet<TbMediaAccount> TbMediaAccounts { get; set; }
        public virtual DbSet<TbPost> TbPosts { get; set; }
        public virtual DbSet<TbPublisher> TbPublishers { get; set; }
        public virtual DbSet<TbPublisherBook> TbPublisherBooks { get; set; }
        public virtual DbSet<TbRate> TbRates { get; set; }
        public virtual DbSet<TbReader> TbReaders { get; set; }
        public virtual DbSet<TbReaderBook> TbReaderBooks { get; set; }
        public virtual DbSet<TbSlider> TbSliders { get; set; }
        public virtual DbSet<TbSystemInfo> TbSystemInfos { get; set; }
        public virtual DbSet<TbTopic> TbTopics { get; set; }
        public virtual DbSet<VwDrawBook> VwDrawBooks { get; set; }
        public virtual DbSet<VwUserBook> VwUserBooks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-OTG38DM;Database=MemoSystem;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId, "IX_AspNetUserRoles_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<TbAdmin>(entity =>
            {
                entity.HasKey(e => e.AdminId);

                entity.HasIndex(e => e.MediaId, "IX_TbAdmins_MediaId");

                entity.Property(e => e.AdminBio)
                    .HasMaxLength(3000)
                    .IsFixedLength(true);

                entity.Property(e => e.AdminEmail)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.AdminImageName)
                    .HasMaxLength(200)
                    .IsFixedLength(true);

                entity.Property(e => e.AdminName)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.AdminPassword)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Media)
                    .WithMany(p => p.TbAdmins)
                    .HasForeignKey(d => d.MediaId)
                    .HasConstraintName("FK_TbAdmins_TbMediaAccounts");
            });

            modelBuilder.Entity<TbAuthour>(entity =>
            {
                entity.HasKey(e => e.AuthourId);

                entity.Property(e => e.AuthourBio).HasMaxLength(3000);

                entity.Property(e => e.AuthourName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TbAuthourBook>(entity =>
            {
                entity.HasKey(e => new { e.AuthourId, e.BookId });

                entity.HasIndex(e => e.BookId, "IX_TbAuthourBooks_BookId");

                entity.HasOne(d => d.Authour)
                    .WithMany(p => p.TbAuthourBooks)
                    .HasForeignKey(d => d.AuthourId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbAuthourBooks_TbAuthours");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.TbAuthourBooks)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbAuthourBooks_TbBooks");
            });

            modelBuilder.Entity<TbBook>(entity =>
            {
                entity.HasKey(e => e.BookId);

                entity.HasIndex(e => e.FormatId, "IX_TbBooks_FormatId");

                entity.Property(e => e.BookIsbn)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsFixedLength(true);

                entity.Property(e => e.BookName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsFixedLength(true);

                entity.Property(e => e.Edition)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.ImageName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.Summary).HasMaxLength(4000);

                entity.HasOne(d => d.Format)
                    .WithMany(p => p.TbBooks)
                    .HasForeignKey(d => d.FormatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbBooks_TbFormats");
            });

            modelBuilder.Entity<TbBookGenre>(entity =>
            {
                entity.HasKey(e => new { e.BookId, e.GenreId });

                entity.HasIndex(e => e.GenreId, "IX_TbBookGenres_GenreId");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.TbBookGenres)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbBookGenres_TbBooks");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.TbBookGenres)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbBookGenres_TbGenres");
            });

            modelBuilder.Entity<TbBookLanguage>(entity =>
            {
                entity.HasKey(e => new { e.BookId, e.LanguageId });

                entity.HasIndex(e => e.LanguageId, "IX_TbBookLanguages_LanguageId");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.TbBookLanguages)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbBookLanguages_TbBooks");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.TbBookLanguages)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbBookLanguages_TbLanguages");
            });

            modelBuilder.Entity<TbBookTopic>(entity =>
            {
                entity.HasKey(e => new { e.BookId, e.TopicId });

                entity.HasIndex(e => e.TopicId, "IX_TbBookTopics_TopicId");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.TbBookTopics)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbBookTopics_TbBooks");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.TbBookTopics)
                    .HasForeignKey(d => d.TopicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbBookTopics_TbTopics");
            });

            modelBuilder.Entity<TbComment>(entity =>
            {
                entity.HasKey(e => e.CommentId)
                    .HasName("PK_Comments");

                entity.HasIndex(e => e.ApplicationUserId, "IX_TbComments_ApplicationUserId");

                entity.HasIndex(e => e.PostId, "IX_TbComments_PostId");

                entity.Property(e => e.CommentId).HasColumnName("commentId");

                entity.Property(e => e.CommentContent)
                    .IsRequired()
                    .HasMaxLength(3000)
                    .IsFixedLength(true);

                entity.Property(e => e.CommentDate).HasColumnType("date");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.TbComments)
                    .HasForeignKey(d => d.ApplicationUserId);

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.TbComments)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbComments_TbPosts");
            });

            modelBuilder.Entity<TbFormat>(entity =>
            {
                entity.HasKey(e => e.FormatId);

                entity.Property(e => e.FormatName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.NumberOfbooks).HasColumnName("NumberOFbooks");
            });

            modelBuilder.Entity<TbGenre>(entity =>
            {
                entity.HasKey(e => e.GenreId)
                    .HasName("PK_Genres");

                entity.Property(e => e.GenreName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TbLanguage>(entity =>
            {
                entity.HasKey(e => e.LanguageId);

                entity.Property(e => e.LanguageName)
                    .HasMaxLength(100)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TbMediaAccount>(entity =>
            {
                entity.HasKey(e => e.MediaId);

                entity.Property(e => e.FaceBook)
                    .HasMaxLength(300)
                    .IsFixedLength(true);

                entity.Property(e => e.GooglePlus)
                    .HasMaxLength(300)
                    .IsFixedLength(true);

                entity.Property(e => e.Linkedin)
                    .HasMaxLength(300)
                    .HasColumnName("linkedin")
                    .IsFixedLength(true);

                entity.Property(e => e.Twiter)
                    .HasMaxLength(300)
                    .IsFixedLength(true);

                entity.Property(e => e.Youtube)
                    .HasMaxLength(300)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TbPost>(entity =>
            {
                entity.HasKey(e => e.PostId);

                entity.HasIndex(e => e.ApplicationUserId, "IX_TbPosts_ApplicationUserId");

                entity.HasIndex(e => e.BookId, "IX_TbPosts_BookId");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.PostContent)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.PostTitle)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsFixedLength(true);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.TbPosts)
                    .HasForeignKey(d => d.ApplicationUserId);

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.TbPosts)
                    .HasForeignKey(d => d.BookId);
            });

            modelBuilder.Entity<TbPublisher>(entity =>
            {
                entity.HasKey(e => e.PublisherId)
                    .HasName("PK_Publishers");

                entity.Property(e => e.PublisherBio)
                    .HasMaxLength(3000)
                    .IsFixedLength(true);

                entity.Property(e => e.PublisherName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TbPublisherBook>(entity =>
            {
                entity.HasKey(e => new { e.PublisherId, e.BookId });

                entity.HasIndex(e => e.BookId, "IX_TbPublisherBooks_BookId");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.TbPublisherBooks)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbPublisherBooks_TbBooks");

                entity.HasOne(d => d.Publisher)
                    .WithMany(p => p.TbPublisherBooks)
                    .HasForeignKey(d => d.PublisherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbPublisherBooks_TbPublishers");
            });

            modelBuilder.Entity<TbRate>(entity =>
            {
                entity.HasKey(e => e.RateId);

                entity.HasIndex(e => e.ApplicationUserId, "IX_TbRates_ApplicationUserId");

                entity.HasIndex(e => e.BookId, "IX_TbRates_BookId");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.TbRates)
                    .HasForeignKey(d => d.ApplicationUserId);

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.TbRates)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbRates_TbBooks");
            });

            modelBuilder.Entity<TbReader>(entity =>
            {
                entity.HasKey(e => e.ReaderId);

                entity.Property(e => e.Quotes)
                    .HasMaxLength(300)
                    .IsFixedLength(true);

                entity.Property(e => e.ReaderEmail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.ReaderName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.ReaderPassword)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TbReaderBook>(entity =>
            {
                entity.HasKey(e => e.ReaderBookId);

                entity.HasIndex(e => e.ApplicationUserId, "IX_TbReaderBooks_ApplicationUserId");

                entity.HasIndex(e => e.BookId, "IX_TbReaderBooks_BookId");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.TbReaderBooks)
                    .HasForeignKey(d => d.ApplicationUserId);

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.TbReaderBooks)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbReaderBooks_TbBooks");
            });

            modelBuilder.Entity<TbSlider>(entity =>
            {
                entity.HasKey(e => e.SliderId);

                entity.ToTable("TbSlider");

                entity.Property(e => e.SliderDiscription)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsFixedLength(true);

                entity.Property(e => e.SliderImageName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("sliderImageName")
                    .IsFixedLength(true);

                entity.Property(e => e.SliderName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TbSystemInfo>(entity =>
            {
                entity.HasKey(e => e.SystemId);

                entity.ToTable("TbSystemInfo");

                entity.HasIndex(e => e.MediaId, "IX_TbSystemInfo_MediaId");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Bio)
                    .IsRequired()
                    .HasMaxLength(3000)
                    .IsFixedLength(true);

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.GoogleMapsAddres)
                    .HasMaxLength(300)
                    .IsFixedLength(true);

                entity.Property(e => e.InfoEmail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.SupportEmail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.WebsiteEmai)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Media)
                    .WithMany(p => p.TbSystemInfos)
                    .HasForeignKey(d => d.MediaId)
                    .HasConstraintName("FK_TbSystemInfo_TbMediaAccounts");
            });

            modelBuilder.Entity<TbTopic>(entity =>
            {
                entity.HasKey(e => e.TopicId);

                entity.Property(e => e.TopicName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VwDrawBook>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwDrawBooks");

                entity.Property(e => e.BookIsbn)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsFixedLength(true);

                entity.Property(e => e.BookName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsFixedLength(true);

                entity.Property(e => e.Edition)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.FormatName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.ImageName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.Summary).HasMaxLength(4000);
            });

            modelBuilder.Entity<VwUserBook>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwUserBook");

                entity.Property(e => e.BookIsbn)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsFixedLength(true);

                entity.Property(e => e.BookName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsFixedLength(true);

                entity.Property(e => e.Edition)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.ImageName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.Summary).HasMaxLength(4000);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
