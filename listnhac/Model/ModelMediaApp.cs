using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace listnhac.Model
{
    public partial class ModelMediaApp : DbContext
    {
        public ModelMediaApp()
            : base("name=ModelMediaApp")
        {
        }

        public virtual DbSet<Playlists> Playlists { get; set; }
        public virtual DbSet<PlaylistSongs> PlaylistSongs { get; set; }
        public virtual DbSet<PlaylistVideos> PlaylistVideos { get; set; }
        public virtual DbSet<Songs> Songs { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserSessions> UserSessions { get; set; }
        public virtual DbSet<Videos> Videos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Playlists>()
                .HasMany(e => e.PlaylistSongs)
                .WithRequired(e => e.Playlists)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Playlists>()
                .HasMany(e => e.PlaylistVideos)
                .WithRequired(e => e.Playlists)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Songs>()
                .HasMany(e => e.PlaylistSongs)
                .WithRequired(e => e.Songs)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Videos>()
                .HasMany(e => e.PlaylistVideos)
                .WithRequired(e => e.Videos)
                .WillCascadeOnDelete(false);
        }
    }
}
