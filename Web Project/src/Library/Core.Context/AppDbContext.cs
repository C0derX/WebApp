using Core.Context.Extensions;
using CMS.Entities;
using Microsoft.EntityFrameworkCore;
using UserManagement.Entities;

namespace Core.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //use management
        public DbSet<Role> role { get; set; }
        public DbSet<User> user { get; set; }
        public DbSet<UserDetails> user_details { get; set; }
        public DbSet<Modules> modules { get; set; }
        public DbSet<Menu> menu { get; set; }
        public DbSet<RoleMenuMap> role_menu_map { get; set; }
        public DbSet<UserLoggedInStatus> user_loggedin_status_setup { get; set; }
        public DbSet<RolePermissionMap> role_permission_map { get; set; }
        public DbSet<MenuPermissionMap> menu_permission_map { get; set; }
        public DbSet<UserRoleMap> user_role_map { get; set; }
        public DbSet<JwtToken> jwt_tokens { get; set; }
        public DbSet<Organization> organization { get; set; }
        public DbSet<OrganizationModuleMap> organization_module_map { get; set; }

        //cms
        public DbSet<Student> student { get; set; }
        public DbSet<Organizer> organizer { get; set; }
        public DbSet<Seminar> seminar { get; set; }
        public DbSet<Register> register { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
