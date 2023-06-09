﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ISpan.Inseparable.DAL.EFCore
{
    public partial class InseparableContext : DbContext
    {
        public InseparableContext()
        {
        }

        public InseparableContext(DbContextOptions<InseparableContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TActivity> TActivities { get; set; } = null!;
        public virtual DbSet<TActivityParticipant> TActivityParticipants { get; set; } = null!;
        public virtual DbSet<TActor> TActors { get; set; } = null!;
        public virtual DbSet<TAdministrator> TAdministrators { get; set; } = null!;
        public virtual DbSet<TArea> TAreas { get; set; } = null!;
        public virtual DbSet<TArticle> TArticles { get; set; } = null!;
        public virtual DbSet<TArticleKeywordDetail> TArticleKeywordDetails { get; set; } = null!;
        public virtual DbSet<TCinema> TCinemas { get; set; } = null!;
        public virtual DbSet<TCity> TCities { get; set; } = null!;
        public virtual DbSet<TComment> TComments { get; set; } = null!;
        public virtual DbSet<TDirector> TDirectors { get; set; } = null!;
        public virtual DbSet<TFriend> TFriends { get; set; } = null!;
        public virtual DbSet<TGender> TGenders { get; set; } = null!;
        public virtual DbSet<TKeyword> TKeywords { get; set; } = null!;
        public virtual DbSet<TMember> TMembers { get; set; } = null!;
        public virtual DbSet<TMemberFavoriteMovieCategory> TMemberFavoriteMovieCategories { get; set; } = null!;
        public virtual DbSet<TMemberPoint> TMemberPoints { get; set; } = null!;
        public virtual DbSet<TMemberStatus> TMemberStatuses { get; set; } = null!;
        public virtual DbSet<TMovie> TMovies { get; set; } = null!;
        public virtual DbSet<TMovieActorDetail> TMovieActorDetails { get; set; } = null!;
        public virtual DbSet<TMovieCategory> TMovieCategories { get; set; } = null!;
        public virtual DbSet<TMovieCategoryDetail> TMovieCategoryDetails { get; set; } = null!;
        public virtual DbSet<TMovieDirectorDetail> TMovieDirectorDetails { get; set; } = null!;
        public virtual DbSet<TMovieKeywordDetail> TMovieKeywordDetails { get; set; } = null!;
        public virtual DbSet<TMovieLevel> TMovieLevels { get; set; } = null!;
        public virtual DbSet<TOrder> TOrders { get; set; } = null!;
        public virtual DbSet<TProduct> TProducts { get; set; } = null!;
        public virtual DbSet<TProductCategory> TProductCategories { get; set; } = null!;
        public virtual DbSet<TProductOrderDetail> TProductOrderDetails { get; set; } = null!;
        public virtual DbSet<TReport> TReports { get; set; } = null!;
        public virtual DbSet<TRoom> TRooms { get; set; } = null!;
        public virtual DbSet<TSeat> TSeats { get; set; } = null!;
        public virtual DbSet<TSession> TSessions { get; set; } = null!;
        public virtual DbSet<TTicketOrderDetail> TTicketOrderDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=inseparable.database.windows.net;Initial Catalog=Inseparable;Persist Security Info=True;User ID=ISpan230117;Password=IN2023Separable_0117");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Chinese_Taiwan_Stroke_CI_AS");

            modelBuilder.Entity<TActivity>(entity =>
            {
                entity.HasKey(e => e.FId);

                entity.ToTable("tActivities");

                entity.Property(e => e.FId).HasColumnName("fID");

                entity.Property(e => e.FActivityId)
                    .HasMaxLength(50)
                    .HasColumnName("fActivityID");

                entity.Property(e => e.FActivityTitle)
                    .HasMaxLength(200)
                    .HasColumnName("fActivityTitle");

                entity.Property(e => e.FCreateTime)
                    .HasMaxLength(50)
                    .HasColumnName("fCreateTime");

                entity.Property(e => e.FDateTime)
                    .HasMaxLength(50)
                    .HasColumnName("fDateTime");

                entity.Property(e => e.FDescription)
                    .HasMaxLength(2000)
                    .HasColumnName("fDescription");

                entity.Property(e => e.FmaxParticipants).HasColumnName("fmaxParticipants");
            });

            modelBuilder.Entity<TActivityParticipant>(entity =>
            {
                entity.HasKey(e => e.FId);

                entity.ToTable("tActivityParticipants");

                entity.Property(e => e.FId).HasColumnName("fID");

                entity.Property(e => e.FActivityId).HasColumnName("fActivityID");

                entity.Property(e => e.FMemberId).HasColumnName("fMemberID");

                entity.Property(e => e.FParticipantNo).HasColumnName("fParticipantNO");

                entity.Property(e => e.FRegisteredTime)
                    .HasMaxLength(50)
                    .HasColumnName("fRegisteredTime");

                entity.HasOne(d => d.FActivity)
                    .WithMany(p => p.TActivityParticipants)
                    .HasForeignKey(d => d.FActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tActivityParticipants_tActivities");

                entity.HasOne(d => d.FMember)
                    .WithMany(p => p.TActivityParticipants)
                    .HasForeignKey(d => d.FMemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tActivityParticipants_tMembers");
            });

            modelBuilder.Entity<TActor>(entity =>
            {
                entity.HasKey(e => e.FActorId);

                entity.ToTable("tActors");

                entity.Property(e => e.FActorId).HasColumnName("fActorID");

                entity.Property(e => e.FActorName)
                    .HasMaxLength(50)
                    .HasColumnName("fActorName");
            });

            modelBuilder.Entity<TAdministrator>(entity =>
            {
                entity.HasKey(e => e.FId);

                entity.ToTable("tAdministrators");

                entity.Property(e => e.FId).HasColumnName("fID");

                entity.Property(e => e.FAdministratorId)
                    .HasMaxLength(50)
                    .HasColumnName("fAdministratorID");

                entity.Property(e => e.FEmail)
                    .HasMaxLength(256)
                    .HasColumnName("fEmail");

                entity.Property(e => e.FFirstName)
                    .HasMaxLength(200)
                    .HasColumnName("fFirstName");

                entity.Property(e => e.FLastName)
                    .HasMaxLength(100)
                    .HasColumnName("fLastName");

                entity.Property(e => e.FPasswordHash)
                    .HasMaxLength(100)
                    .HasColumnName("fPasswordHash");

                entity.Property(e => e.FPasswordSalt)
                    .HasMaxLength(50)
                    .HasColumnName("fPasswordSalt");

                entity.Property(e => e.FSignUpTime)
                    .HasMaxLength(50)
                    .HasColumnName("fSignUpTime");
            });

            modelBuilder.Entity<TArea>(entity =>
            {
                entity.HasKey(e => e.FAreaId)
                    .HasName("PK_areas_1");

                entity.ToTable("tAreas");

                entity.Property(e => e.FAreaId).HasColumnName("fAreaID");

                entity.Property(e => e.FCityId).HasColumnName("fCityID");

                entity.Property(e => e.FName)
                    .HasMaxLength(100)
                    .HasColumnName("fName");

                entity.HasOne(d => d.FCity)
                    .WithMany(p => p.TAreas)
                    .HasForeignKey(d => d.FCityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Areas_Cities");
            });

            modelBuilder.Entity<TArticle>(entity =>
            {
                entity.HasKey(e => e.FArticleId)
                    .HasName("PK_Article");

                entity.ToTable("tArticles");

                entity.Property(e => e.FArticleId).HasColumnName("fArticleID");

                entity.Property(e => e.FArticleCategoryId).HasColumnName("fArticleCategoryID");

                entity.Property(e => e.FArticleClicks).HasColumnName("fArticleClicks");

                entity.Property(e => e.FArticleContent)
                    .HasMaxLength(4000)
                    .HasColumnName("fArticleContent");

                entity.Property(e => e.FArticleLikes).HasColumnName("fArticleLikes");

                entity.Property(e => e.FArticlePostingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("fArticlePostingDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FArticleTitle)
                    .HasMaxLength(50)
                    .HasColumnName("fArticleTitle");

                entity.Property(e => e.FMemberId).HasColumnName("fMemberID");

                entity.HasOne(d => d.FMember)
                    .WithMany(p => p.TArticles)
                    .HasForeignKey(d => d.FMemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tArticles_tMembers");
            });

            modelBuilder.Entity<TArticleKeywordDetail>(entity =>
            {
                entity.HasKey(e => e.FSerialNumber)
                    .HasName("PK_ArticleCategoryDetails");

                entity.ToTable("tArticleKeywordDetails");

                entity.Property(e => e.FSerialNumber).HasColumnName("fSerialNumber");

                entity.Property(e => e.FArticleId).HasColumnName("fArticleID");

                entity.Property(e => e.FKeywordId).HasColumnName("fKeywordID");

                entity.HasOne(d => d.FArticle)
                    .WithMany(p => p.TArticleKeywordDetails)
                    .HasForeignKey(d => d.FArticleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tKeywordDetails_Articles");

                entity.HasOne(d => d.FKeyword)
                    .WithMany(p => p.TArticleKeywordDetails)
                    .HasForeignKey(d => d.FKeywordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArticleCategoryDetails_ArticleCategories");
            });

            modelBuilder.Entity<TCinema>(entity =>
            {
                entity.HasKey(e => e.FCinemaId)
                    .HasName("PK_MovieManages");

                entity.ToTable("tCinemas");

                entity.HasIndex(e => e.FCinemaName, "IX_Cinemas")
                    .IsUnique();

                entity.Property(e => e.FCinemaId).HasColumnName("fCinemaID");

                entity.Property(e => e.FCinemaAddress)
                    .HasMaxLength(100)
                    .HasColumnName("fCinemaAddress");

                entity.Property(e => e.FCinemaName)
                    .HasMaxLength(50)
                    .HasColumnName("fCinemaName");

                entity.Property(e => e.FCinemaRegion)
                    .HasMaxLength(50)
                    .HasColumnName("fCinemaRegion");

                entity.Property(e => e.FCinemaTel)
                    .HasMaxLength(50)
                    .HasColumnName("fCinemaTel");
            });

            modelBuilder.Entity<TCity>(entity =>
            {
                entity.HasKey(e => e.FCityId)
                    .HasName("PK_Cities");

                entity.ToTable("tCities");

                entity.Property(e => e.FCityId)
                    .ValueGeneratedNever()
                    .HasColumnName("fCityID");

                entity.Property(e => e.FCityName)
                    .HasMaxLength(100)
                    .HasColumnName("fCityName");
            });

            modelBuilder.Entity<TComment>(entity =>
            {
                entity.HasKey(e => e.FCommentId);

                entity.ToTable("tComments");

                entity.Property(e => e.FCommentId).HasColumnName("fCommentID");

                entity.Property(e => e.FArticleId).HasColumnName("fArticleID");

                entity.Property(e => e.FCommentContent)
                    .HasMaxLength(4000)
                    .HasColumnName("fCommentContent");

                entity.Property(e => e.FCommentLikes).HasColumnName("fCommentLikes");

                entity.Property(e => e.FCommentPostingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("fCommentPostingDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FItemNumber).HasColumnName("fItemNumber");

                entity.Property(e => e.FMemberId).HasColumnName("fMemberID");

                entity.HasOne(d => d.FArticle)
                    .WithMany(p => p.TComments)
                    .HasForeignKey(d => d.FArticleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comments_Article");

                entity.HasOne(d => d.FMember)
                    .WithMany(p => p.TComments)
                    .HasForeignKey(d => d.FMemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tComments_tMembers");
            });

            modelBuilder.Entity<TDirector>(entity =>
            {
                entity.HasKey(e => e.FDirectorId);

                entity.ToTable("tDirectors");

                entity.Property(e => e.FDirectorId).HasColumnName("fDirectorID");

                entity.Property(e => e.FDitectorName)
                    .HasMaxLength(50)
                    .HasColumnName("fDitectorName");
            });

            modelBuilder.Entity<TFriend>(entity =>
            {
                entity.HasKey(e => e.FId);

                entity.ToTable("tFriends");

                entity.Property(e => e.FId).HasColumnName("fID");

                entity.Property(e => e.FFriendDateTime)
                    .HasMaxLength(50)
                    .HasColumnName("fFriendDateTime")
                    .HasComment("成為好友的時間");

                entity.Property(e => e.FFriendId)
                    .HasColumnName("fFriendID")
                    .HasComment("好友的ID");

                entity.Property(e => e.FFriendNo).HasColumnName("fFriendNo");

                entity.Property(e => e.FMemberId).HasColumnName("fMemberID");

                entity.HasOne(d => d.FMember)
                    .WithMany(p => p.TFriends)
                    .HasForeignKey(d => d.FMemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tFriends_tMembers");
            });

            modelBuilder.Entity<TGender>(entity =>
            {
                entity.HasKey(e => e.FGenderId)
                    .HasName("PK_Gender");

                entity.ToTable("tGender");

                entity.Property(e => e.FGenderId).HasColumnName("fGenderID");

                entity.Property(e => e.FGenderType)
                    .HasMaxLength(20)
                    .HasColumnName("fGenderType");
            });

            modelBuilder.Entity<TKeyword>(entity =>
            {
                entity.HasKey(e => e.FKeywordId)
                    .HasName("PK_ArticleCategories");

                entity.ToTable("tKeywords");

                entity.Property(e => e.FKeywordId).HasColumnName("fKeywordID");

                entity.Property(e => e.FKeywordName)
                    .HasMaxLength(50)
                    .HasColumnName("fKeywordName");
            });

            modelBuilder.Entity<TMember>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK_Members");

                entity.ToTable("tMembers");

                entity.Property(e => e.FId).HasColumnName("fID");

                entity.Property(e => e.FAddress)
                    .HasMaxLength(100)
                    .HasColumnName("fAddress");

                entity.Property(e => e.FAreaId).HasColumnName("fAreaID");

                entity.Property(e => e.FCellphone)
                    .HasMaxLength(50)
                    .HasColumnName("fCellphone")
                    .HasComment("手機號碼");

                entity.Property(e => e.FDateOfBirth)
                    .HasMaxLength(50)
                    .HasColumnName("fDateOfBirth");

                entity.Property(e => e.FEmail)
                    .HasMaxLength(256)
                    .HasColumnName("fEmail");

                entity.Property(e => e.FFirstName)
                    .HasMaxLength(100)
                    .HasColumnName("fFirstName")
                    .HasComment("名字");

                entity.Property(e => e.FGenderId).HasColumnName("fGenderID");

                entity.Property(e => e.FIntroduction)
                    .HasMaxLength(500)
                    .HasColumnName("fIntroduction")
                    .HasComment("個人簡介");

                entity.Property(e => e.FLastName)
                    .HasMaxLength(200)
                    .HasColumnName("fLastName")
                    .HasComment("姓氏");

                entity.Property(e => e.FMemberId)
                    .HasMaxLength(50)
                    .HasColumnName("fMemberID");

                entity.Property(e => e.FPasswordHash)
                    .HasMaxLength(100)
                    .HasColumnName("fPasswordHash")
                    .HasComment("密碼");

                entity.Property(e => e.FPasswordSalt)
                    .HasMaxLength(50)
                    .HasColumnName("fPasswordSalt");

                entity.Property(e => e.FPhotoPath)
                    .HasMaxLength(200)
                    .HasColumnName("fPhotoPath");

                entity.Property(e => e.FSignUpTime)
                    .HasMaxLength(50)
                    .HasColumnName("fSignUpTime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("註冊時間");

                entity.Property(e => e.FTotalMemberPoint).HasColumnName("fTotalMemberPoint");

                entity.HasOne(d => d.FArea)
                    .WithMany(p => p.TMembers)
                    .HasForeignKey(d => d.FAreaId)
                    .HasConstraintName("FK_tMembers_tAreas");

                entity.HasOne(d => d.FGender)
                    .WithMany(p => p.TMembers)
                    .HasForeignKey(d => d.FGenderId)
                    .HasConstraintName("FK_tMembers_tGender");
            });

            modelBuilder.Entity<TMemberFavoriteMovieCategory>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK_MemberFavoriteMovieCategories");

                entity.ToTable("tMemberFavoriteMovieCategories");

                entity.Property(e => e.FId).HasColumnName("fID");

                entity.Property(e => e.FMemberId).HasColumnName("fMemberID");

                entity.Property(e => e.FMovieCategoryId).HasColumnName("fMovieCategoryID");

                entity.HasOne(d => d.FMember)
                    .WithMany(p => p.TMemberFavoriteMovieCategories)
                    .HasForeignKey(d => d.FMemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMemberFavoriteMovieCategories_tMembers");

                entity.HasOne(d => d.FMovieCategory)
                    .WithMany(p => p.TMemberFavoriteMovieCategories)
                    .HasForeignKey(d => d.FMovieCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemberFavoriteMovieCategories_MovieCategories");
            });

            modelBuilder.Entity<TMemberPoint>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK_MemberPoints");

                entity.ToTable("tMemberPoints");

                entity.Property(e => e.FId).HasColumnName("fID");

                entity.Property(e => e.FCreateTime)
                    .HasMaxLength(50)
                    .HasColumnName("fCreateTime");

                entity.Property(e => e.FDescription)
                    .HasMaxLength(100)
                    .HasColumnName("fDescription");

                entity.Property(e => e.FItemNo).HasColumnName("fItemNO");

                entity.Property(e => e.FMemberId).HasColumnName("fMemberID");

                entity.Property(e => e.FPointDeducted).HasColumnName("fPointDeducted");

                entity.Property(e => e.FPointsAdded).HasColumnName("fPointsAdded");

                entity.HasOne(d => d.FMember)
                    .WithMany(p => p.TMemberPoints)
                    .HasForeignKey(d => d.FMemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMemberPoints_tMembers");
            });

            modelBuilder.Entity<TMemberStatus>(entity =>
            {
                entity.HasKey(e => e.FStatusId);

                entity.ToTable("tMemberStatus");

                entity.Property(e => e.FStatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("fStatusID");

                entity.Property(e => e.FDescription)
                    .HasMaxLength(200)
                    .HasColumnName("fDescription");

                entity.Property(e => e.FStatus)
                    .HasMaxLength(50)
                    .HasColumnName("fStatus");
            });

            modelBuilder.Entity<TMovie>(entity =>
            {
                entity.HasKey(e => e.FMovieId)
                    .HasName("PK_Movies");

                entity.ToTable("tMovies");

                entity.Property(e => e.FMovieId).HasColumnName("fMovieID");

                entity.Property(e => e.FMovieImagePath)
                    .HasMaxLength(50)
                    .HasColumnName("fMovieImagePath")
                    .HasDefaultValueSql("(N'not image')");

                entity.Property(e => e.FMovieIntroduction)
                    .HasMaxLength(4000)
                    .HasColumnName("fMovieIntroduction");

                entity.Property(e => e.FMovieLength).HasColumnName("fMovieLength");

                entity.Property(e => e.FMovieLevelId).HasColumnName("fMovieLevelID");

                entity.Property(e => e.FMovieName)
                    .HasMaxLength(50)
                    .HasColumnName("fMovieName");

                entity.Property(e => e.FMovieOffDate)
                    .HasColumnType("date")
                    .HasColumnName("fMovieOffDate");

                entity.Property(e => e.FMovieOnDate)
                    .HasColumnType("date")
                    .HasColumnName("fMovieOnDate");

                entity.Property(e => e.FMovieScore).HasColumnName("fMovieScore");

                entity.HasOne(d => d.FMovieLevel)
                    .WithMany(p => p.TMovies)
                    .HasForeignKey(d => d.FMovieLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Movies_MovieLevels");
            });

            modelBuilder.Entity<TMovieActorDetail>(entity =>
            {
                entity.HasKey(e => e.FSerialNumber)
                    .HasName("PK_MovieActorDetails");

                entity.ToTable("tMovieActorDetails");

                entity.Property(e => e.FSerialNumber).HasColumnName("fSerialNumber");

                entity.Property(e => e.FActorId).HasColumnName("fActorID");

                entity.Property(e => e.FMovieId).HasColumnName("fMovieID");

                entity.HasOne(d => d.FActor)
                    .WithMany(p => p.TMovieActorDetails)
                    .HasForeignKey(d => d.FActorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MovieActorDetails_tActors");

                entity.HasOne(d => d.FMovie)
                    .WithMany(p => p.TMovieActorDetails)
                    .HasForeignKey(d => d.FMovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MovieActorDetails_tMovies");
            });

            modelBuilder.Entity<TMovieCategory>(entity =>
            {
                entity.HasKey(e => e.FMovieCategoryId)
                    .HasName("PK_MovieCategories");

                entity.ToTable("tMovieCategories");

                entity.Property(e => e.FMovieCategoryId).HasColumnName("fMovieCategoryID");

                entity.Property(e => e.FMovieCategoryName)
                    .HasMaxLength(50)
                    .HasColumnName("fMovieCategoryName");
            });

            modelBuilder.Entity<TMovieCategoryDetail>(entity =>
            {
                entity.HasKey(e => e.FSerialNumber)
                    .HasName("PK_MovieCategoryDetails_1");

                entity.ToTable("tMovieCategoryDetails");

                entity.Property(e => e.FSerialNumber).HasColumnName("fSerialNumber");

                entity.Property(e => e.FMovieCategoryId).HasColumnName("fMovieCategoryID");

                entity.Property(e => e.FMovieId).HasColumnName("fMovieID");

                entity.HasOne(d => d.FMovieCategory)
                    .WithMany(p => p.TMovieCategoryDetails)
                    .HasForeignKey(d => d.FMovieCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MovieCategoryDetails_MovieCategories");

                entity.HasOne(d => d.FMovie)
                    .WithMany(p => p.TMovieCategoryDetails)
                    .HasForeignKey(d => d.FMovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MovieCategoryDetails_Movies");
            });

            modelBuilder.Entity<TMovieDirectorDetail>(entity =>
            {
                entity.HasKey(e => e.FSerialNumber);

                entity.ToTable("tMovieDirectorDetails");

                entity.Property(e => e.FSerialNumber).HasColumnName("fSerialNumber");

                entity.Property(e => e.FDirectorId).HasColumnName("fDirectorID");

                entity.Property(e => e.FMovieId).HasColumnName("fMovieID");

                entity.HasOne(d => d.FDirector)
                    .WithMany(p => p.TMovieDirectorDetails)
                    .HasForeignKey(d => d.FDirectorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMovieDirectorDetails_tDirectors");

                entity.HasOne(d => d.FMovie)
                    .WithMany(p => p.TMovieDirectorDetails)
                    .HasForeignKey(d => d.FMovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMovieDirectorDetails_tMovies");
            });

            modelBuilder.Entity<TMovieKeywordDetail>(entity =>
            {
                entity.HasKey(e => e.FSerialNumber);

                entity.ToTable("tMovieKeywordDetails");

                entity.Property(e => e.FSerialNumber).HasColumnName("fSerialNumber");

                entity.Property(e => e.FKeywordId).HasColumnName("fKeywordID");

                entity.Property(e => e.FMovieId).HasColumnName("fMovieID");

                entity.HasOne(d => d.FKeyword)
                    .WithMany(p => p.TMovieKeywordDetails)
                    .HasForeignKey(d => d.FKeywordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMovieKeywordDetails_tKeywords");

                entity.HasOne(d => d.FMovie)
                    .WithMany(p => p.TMovieKeywordDetails)
                    .HasForeignKey(d => d.FMovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMovieKeywordDetails_tMovies");
            });

            modelBuilder.Entity<TMovieLevel>(entity =>
            {
                entity.HasKey(e => e.FLevelId)
                    .HasName("PK_MovieLevels");

                entity.ToTable("tMovieLevels");

                entity.Property(e => e.FLevelId).HasColumnName("fLevelID");

                entity.Property(e => e.FLevelName)
                    .HasMaxLength(50)
                    .HasColumnName("fLevelName");
            });

            modelBuilder.Entity<TOrder>(entity =>
            {
                entity.HasKey(e => e.FOrderId)
                    .HasName("PK_Order");

                entity.ToTable("tOrders");

                entity.Property(e => e.FOrderId).HasColumnName("fOrderID");

                entity.Property(e => e.FCinemaId).HasColumnName("fCinemaID");

                entity.Property(e => e.FMemberId).HasColumnName("fMemberID");

                entity.Property(e => e.FModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("fModifiedTime");

                entity.Property(e => e.FOrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("fOrderDate");

                entity.Property(e => e.FTotalMoney)
                    .HasColumnType("money")
                    .HasColumnName("fTotalMoney");

                entity.HasOne(d => d.FCinema)
                    .WithMany(p => p.TOrders)
                    .HasForeignKey(d => d.FCinemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Cinemas");

                entity.HasOne(d => d.FMember)
                    .WithMany(p => p.TOrders)
                    .HasForeignKey(d => d.FMemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tOrders_tMembers");
            });

            modelBuilder.Entity<TProduct>(entity =>
            {
                entity.HasKey(e => e.FProductId)
                    .HasName("PK_Products");

                entity.ToTable("tProducts");

                entity.Property(e => e.FProductId).HasColumnName("fProductId");

                entity.Property(e => e.FCinemaId).HasColumnName("fCinemaID");

                entity.Property(e => e.FProductCategoryId).HasColumnName("fProductCategoryId");

                entity.Property(e => e.FProductName)
                    .HasMaxLength(50)
                    .HasColumnName("fProductName");

                entity.Property(e => e.FProductPicturePath)
                    .HasMaxLength(50)
                    .HasColumnName("fProductPicturePath");

                entity.Property(e => e.FProductStock).HasColumnName("fProductStock");

                entity.Property(e => e.FProductUnitprice)
                    .HasColumnType("money")
                    .HasColumnName("fProductUnitprice");

                entity.HasOne(d => d.FCinema)
                    .WithMany(p => p.TProducts)
                    .HasForeignKey(d => d.FCinemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products_Cinemas");

                entity.HasOne(d => d.FProductCategory)
                    .WithMany(p => p.TProducts)
                    .HasForeignKey(d => d.FProductCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products_ProductCategories");
            });

            modelBuilder.Entity<TProductCategory>(entity =>
            {
                entity.HasKey(e => e.FProductCategoryId)
                    .HasName("PK_ProductCategories");

                entity.ToTable("tProductCategories");

                entity.Property(e => e.FProductCategoryId).HasColumnName("fProductCategoryID");

                entity.Property(e => e.FProductCategoryName)
                    .HasMaxLength(50)
                    .HasColumnName("fProductCategoryName");
            });

            modelBuilder.Entity<TProductOrderDetail>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK_ProductOrderDetials");

                entity.ToTable("tProductOrderDetails");

                entity.Property(e => e.FId).HasColumnName("fID");

                entity.Property(e => e.FOrderId).HasColumnName("fOrderID");

                entity.Property(e => e.FProductDiscount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fProductDiscount");

                entity.Property(e => e.FProductId).HasColumnName("fProductID");

                entity.Property(e => e.FProductItemNo).HasColumnName("fProductItem_no");

                entity.Property(e => e.FProductName)
                    .HasMaxLength(50)
                    .HasColumnName("fProductName");

                entity.Property(e => e.FProductQty).HasColumnName("fProductQty");

                entity.Property(e => e.FProductSubtotal)
                    .HasColumnType("money")
                    .HasColumnName("fProductSubtotal");

                entity.Property(e => e.FProductUnitprice)
                    .HasColumnType("money")
                    .HasColumnName("fProductUnitprice");

                entity.HasOne(d => d.FOrder)
                    .WithMany(p => p.TProductOrderDetails)
                    .HasForeignKey(d => d.FOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductOrderDetails_Orders");

                entity.HasOne(d => d.FProduct)
                    .WithMany(p => p.TProductOrderDetails)
                    .HasForeignKey(d => d.FProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductOrderDetails_Products");
            });

            modelBuilder.Entity<TReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tReport");

                entity.Property(e => e.FId).HasColumnName("fID");

                entity.Property(e => e.FMemberId).HasColumnName("fMemberID");
            });

            modelBuilder.Entity<TRoom>(entity =>
            {
                entity.HasKey(e => e.FRoomId)
                    .HasName("PK_Rooms");

                entity.ToTable("tRooms");

                entity.Property(e => e.FRoomId).HasColumnName("fRoomID");

                entity.Property(e => e.FCinemaId).HasColumnName("fCinemaID");

                entity.Property(e => e.FRoomName)
                    .HasMaxLength(50)
                    .HasColumnName("fRoomName");

                entity.HasOne(d => d.FCinema)
                    .WithMany(p => p.TRooms)
                    .HasForeignKey(d => d.FCinemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rooms_Cinemas");
            });

            modelBuilder.Entity<TSeat>(entity =>
            {
                entity.HasKey(e => e.FSeatId)
                    .HasName("PK_Seats");

                entity.ToTable("tSeats");

                entity.Property(e => e.FSeatId).HasColumnName("fSeatID");

                entity.Property(e => e.FSeatColumn).HasColumnName("fSeatColumn");

                entity.Property(e => e.FSeatRow)
                    .HasMaxLength(50)
                    .HasColumnName("fSeatRow");
            });

            modelBuilder.Entity<TSession>(entity =>
            {
                entity.HasKey(e => e.FSessionId)
                    .HasName("PK_Session");

                entity.ToTable("tSessions");

                entity.Property(e => e.FSessionId).HasColumnName("fSessionId");

                entity.Property(e => e.FCinemaId).HasColumnName("fCinemaID");

                entity.Property(e => e.FMovieId).HasColumnName("fMovieId");

                entity.Property(e => e.FRoomId).HasColumnName("fRoomId");

                entity.Property(e => e.FSessionDate)
                    .HasColumnType("date")
                    .HasColumnName("fSessionDate");

                entity.Property(e => e.FSessionTime).HasColumnName("fSessionTime");

                entity.Property(e => e.FTicketPrice)
                    .HasColumnType("money")
                    .HasColumnName("fTicketPrice");

                entity.HasOne(d => d.FCinema)
                    .WithMany(p => p.TSessions)
                    .HasForeignKey(d => d.FCinemaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sessions_Cinemas");

                entity.HasOne(d => d.FMovie)
                    .WithMany(p => p.TSessions)
                    .HasForeignKey(d => d.FMovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sessions_Movies");

                entity.HasOne(d => d.FRoom)
                    .WithMany(p => p.TSessions)
                    .HasForeignKey(d => d.FRoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sessions_Rooms");
            });

            modelBuilder.Entity<TTicketOrderDetail>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK_TicketOrderDetial");

                entity.ToTable("tTicketOrderDetails");

                entity.Property(e => e.FId).HasColumnName("fID");

                entity.Property(e => e.FMovieId).HasColumnName("fMovieID");

                entity.Property(e => e.FOrderId).HasColumnName("fOrderID");

                entity.Property(e => e.FRoomId).HasColumnName("fRoomID");

                entity.Property(e => e.FSeatId).HasColumnName("fSeatID");

                entity.Property(e => e.FSessionId).HasColumnName("fSessionID");

                entity.Property(e => e.FTicketDiscount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fTicketDiscount");

                entity.Property(e => e.FTicketItemNo).HasColumnName("fTicketItem_no");

                entity.Property(e => e.FTicketSubtotal)
                    .HasColumnType("money")
                    .HasColumnName("fTicketSubtotal");

                entity.Property(e => e.FTicketUnitprice)
                    .HasColumnType("money")
                    .HasColumnName("fTicketUnitprice");

                entity.HasOne(d => d.FMovie)
                    .WithMany(p => p.TTicketOrderDetails)
                    .HasForeignKey(d => d.FMovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketOrderDetails_Movies");

                entity.HasOne(d => d.FOrder)
                    .WithMany(p => p.TTicketOrderDetails)
                    .HasForeignKey(d => d.FOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketOrderDetails_Orders");

                entity.HasOne(d => d.FRoom)
                    .WithMany(p => p.TTicketOrderDetails)
                    .HasForeignKey(d => d.FRoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketOrderDetails_Rooms");

                entity.HasOne(d => d.FSeat)
                    .WithMany(p => p.TTicketOrderDetails)
                    .HasForeignKey(d => d.FSeatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketOrderDetails_Seats");

                entity.HasOne(d => d.FSession)
                    .WithMany(p => p.TTicketOrderDetails)
                    .HasForeignKey(d => d.FSessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketOrderDetails_Sessions");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
