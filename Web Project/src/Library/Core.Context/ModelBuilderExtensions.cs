using Microsoft.EntityFrameworkCore;
using System;
using UserManagement.Entities;

namespace Core.Context.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Modules>().HasData(
               new Modules
               {
                   Id = 1,
                   name = "User Management",
                   created_by = 1,
               },
               new Modules
               {
                   Id = 2,
                   name = "CMS",
                   created_by = 1,
               });

            modelBuilder.Entity<Organization>().HasData(
                new Organization
                {
                    Id = 1,
                    organization_name = "Smart CMS",
                    created_by = 1,
                });

            modelBuilder.Entity<OrganizationModuleMap>().HasData(
                new OrganizationModuleMap
                {
                    Id = 1,
                    organization_id = 1,
                    module_id = 1,
                    created_by = 1
                });

            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = 1,
                    name = "Admin",
                    created_by = 1,
                });

            modelBuilder.Entity<RolePermissionMap>().HasData(
                new RolePermissionMap
                {
                    Id = 1,
                    permissions = "H4-0010001100120013",
                    role_id = 1,
                    created_by = 1
                });

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    username = "admin",
                    password = "1000:Q0OssukdAhOuAr8VRDN99CXP67LM3wFl:b4mKfWiU1y67bhEpjsolYhV5aP1bVNzC",
                    created_by = 1,
                    is_email_confirmed = true,
                    email = "admin@gmail.com",

                });

            modelBuilder.Entity<UserDetails>().HasData(
                new UserDetails
                {
                    Id = 1,
                    user_id = 1,
                    permanent_address = "Mechinagar",
                    primary_contact = "9814978788",
                    first_name = "Test",
                    last_name = "Bahadur",

                });

            modelBuilder.Entity<UserRoleMap>().HasData(
                new UserRoleMap
                {
                    Id = 1,
                    user_id = 1,
                    role_id = 1,
                    created_by = 1
                });

            //Menus
            modelBuilder.Entity<Menu>().HasData(
                new Menu
                {
                    Id = 1,
                    name = "User",
                    parent_menu_id = null,
                    display_icon = "",
                    display_order = 1,
                    api_url = "",
                    is_visible_to_menu = true,
                    created_by = 1,
                    module_id = 1,
                    web_url = "/usermanagement/user/index"

                },
                    new Menu
                    {
                        Id = 2,
                        name = "Create",
                        parent_menu_id = 1,
                        display_icon = "",
                        display_order = 1,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 1,
                        web_url = "/usermanagement/user/create"

                    },
                    new Menu
                    {
                        Id = 3,
                        name = "Update",
                        parent_menu_id = 1,
                        display_icon = "",
                        display_order = 2,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 1,
                        web_url = "/usermanagement/user/update"

                    },
                     new Menu
                     {
                         Id = 4,
                         name = "Delete",
                         parent_menu_id = 1,
                         display_icon = "",
                         display_order = 3,
                         api_url = "",
                         is_visible_to_menu = false,
                         created_by = 1,
                         module_id = 1,
                         web_url = "/usermanagement/user/delete"

                     },
                      new Menu
                      {
                          Id = 5,
                          name = "Enable",
                          parent_menu_id = 1,
                          display_icon = "",
                          display_order = 4,
                          api_url = "",
                          is_visible_to_menu = false,
                          created_by = 1,
                          module_id = 1,
                          web_url = "/usermanagement/user/enable"

                      },
                       new Menu
                       {
                           Id = 6,
                           name = "Disable",
                           parent_menu_id = 1,
                           display_icon = "",
                           display_order = 5,
                           api_url = "",
                           is_visible_to_menu = false,
                           created_by = 1,
                           module_id = 1,
                           web_url = "/usermanagement/user/disable"

                       },
                        new Menu
                        {
                            Id = 7,
                            name = "Change Password",
                            parent_menu_id = 1,
                            display_icon = "",
                            display_order = 6,
                            api_url = "",
                            is_visible_to_menu = false,
                            created_by = 1,
                            module_id = 1,
                            web_url = "/usermanagement/user/change-password"

                        },
                        new Menu
                        {
                            Id = 8,
                            name = "Mark Email Registered",
                            parent_menu_id = 1,
                            display_icon = "",
                            display_order = 7,
                            api_url = "",
                            is_visible_to_menu = false,
                            created_by = 1,
                            module_id = 1,
                            web_url = "/usermanagement/user/mark-email-registered"

                        },
                new Menu
                {
                    Id = 9,
                    name = "Setup",
                    parent_menu_id = null,
                    display_icon = "",
                    display_order = 1,
                    api_url = "",
                    is_visible_to_menu = true,
                    module_id = 1,
                    web_url = "#",
                    created_by = 1,
                },
                new Menu
                {
                    Id = 10,
                    name = "Role",
                    parent_menu_id = 9,
                    display_icon = "",
                    display_order = 1,
                    api_url = "",
                    is_visible_to_menu = true,
                    created_by = 1,
                    module_id = 1,
                    web_url = "/usermanagement/role/index"
                },

                    new Menu
                    {
                        Id = 11,
                        name = "Create",
                        parent_menu_id = 10,
                        display_icon = "",
                        display_order = 1,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 1,
                        web_url = "/usermanagement/role/create"

                    },
                    new Menu
                    {
                        Id = 12,
                        name = "Update",
                        parent_menu_id = 10,
                        display_icon = "",
                        display_order = 2,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 1,
                        web_url = "/usermanagement/role/update"

                    },
                     new Menu
                     {
                         Id = 13,
                         name = "Delete",
                         parent_menu_id = 10,
                         display_icon = "",
                         display_order = 3,
                         api_url = "",
                         is_visible_to_menu = false,
                         created_by = 1,
                         module_id = 1,
                         web_url = "/usermanagement/role/delete"

                     },
                      new Menu
                      {
                          Id = 14,
                          name = "Enable",
                          parent_menu_id = 10,
                          display_icon = "",
                          display_order = 4,
                          api_url = "",
                          is_visible_to_menu = false,
                          created_by = 1,
                          module_id = 1,
                          web_url = "/usermanagement/role/enable"

                      },
                       new Menu
                       {
                           Id = 15,
                           name = "Disable",
                           parent_menu_id = 10,
                           display_icon = "",
                           display_order = 5,
                           api_url = "",
                           is_visible_to_menu = false,
                           created_by = 1,
                           module_id = 1,
                           web_url = "/usermanagement/role/disable"

                       },
                       new Menu
                       {
                           Id = 16,
                           name = "Assign Role Menu",
                           parent_menu_id = 10,
                           display_icon = "",
                           display_order = 6,
                           api_url = "",
                           is_visible_to_menu = false,
                           created_by = 1,
                           module_id = 1,
                           web_url = "/usermanagement/role/assign-role-menu"

                       },

                new Menu
                {
                    Id = 17,
                    name = "Module",
                    parent_menu_id = 9,
                    display_icon = "",
                    display_order = 2,
                    api_url = "",
                    is_visible_to_menu = true,
                    created_by = 1,
                    module_id = 1,
                    web_url = "/usermanagement/module/index"
                },

                    new Menu
                    {
                        Id = 18,
                        name = "Create",
                        parent_menu_id = 17,
                        display_icon = "",
                        display_order = 1,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 1,
                        web_url = "/usermanagement/module/create"

                    },
                    new Menu
                    {
                        Id = 19,
                        name = "Update",
                        parent_menu_id = 17,
                        display_icon = "",
                        display_order = 2,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 1,
                        web_url = "/usermanagement/module/update"

                    },
                     new Menu
                     {
                         Id = 20,
                         name = "Delete",
                         parent_menu_id = 17,
                         display_icon = "",
                         display_order = 3,
                         api_url = "",
                         is_visible_to_menu = false,
                         created_by = 1,
                         module_id = 1,
                         web_url = "/usermanagement/module/delete"

                     },

                new Menu
                {
                    Id = 21,
                    name = "Menu",
                    parent_menu_id = 9,
                    display_icon = "",
                    display_order = 3,
                    api_url = "",
                    is_visible_to_menu = true,
                    created_by = 1,
                    module_id = 1,
                    web_url = "/usermanagement/menu/index"
                },
                    new Menu
                    {
                        Id = 22,
                        name = "Create",
                        parent_menu_id = 21,
                        display_icon = "",
                        display_order = 1,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 1,
                        web_url = "/usermanagement/menu/create"

                    },
                    new Menu
                    {
                        Id = 23,
                        name = "Update",
                        parent_menu_id = 21,
                        display_icon = "",
                        display_order = 2,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 1,
                        web_url = "/usermanagement/menu/update"

                    },
                     new Menu
                     {
                         Id = 24,
                         name = "Delete",
                         parent_menu_id = 21,
                         display_icon = "",
                         display_order = 3,
                         api_url = "",
                         is_visible_to_menu = false,
                         created_by = 1,
                         module_id = 1,
                         web_url = "/usermanagement/menu/delete"

                     },
                      new Menu
                      {
                          Id = 25,
                          name = "Enable",
                          parent_menu_id = 21,
                          display_icon = "",
                          display_order = 4,
                          api_url = "",
                          is_visible_to_menu = false,
                          created_by = 1,
                          module_id = 1,
                          web_url = "/usermanagement/menu/enable"

                      },
                       new Menu
                       {
                           Id = 26,
                           name = "Disable",
                           parent_menu_id = 21,
                           display_icon = "",
                           display_order = 5,
                           api_url = "",
                           is_visible_to_menu = false,
                           created_by = 1,
                           module_id = 1,
                           web_url = "/usermanagement/menu/disable"

                       },
                new Menu
                {
                    Id = 27,
                    name = "Organization",
                    parent_menu_id = null,
                    display_icon = "",
                    display_order = 2,
                    api_url = "",
                    is_visible_to_menu = false,
                    created_by = 1,
                    module_id = 1,
                    web_url = "#"
                },
                    new Menu
                    {
                        Id = 28,
                        name = "Create",
                        parent_menu_id = 27,
                        display_icon = "",
                        display_order = 1,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 1,
                        web_url = "/usermanagement/organization/create"
                    },
                     new Menu
                     {
                         Id = 29,
                         name = "Assign Module",
                         parent_menu_id = 27,
                         display_icon = "",
                         display_order = 2,
                         api_url = "",
                         is_visible_to_menu = false,
                         created_by = 1,
                         module_id = 1,
                         web_url = "/usermanagement/organization/assign-module"
                     },
                new Menu
                {
                    Id = 30,
                    name = "Reports",
                    parent_menu_id = null,
                    display_icon = "",
                    display_order = 2,
                    api_url = "",
                    is_visible_to_menu = true,
                    created_by = 1,
                    module_id = 1,
                    web_url = "#"
                },
                new Menu
                {
                    Id = 31,
                    name = "User Report",
                    parent_menu_id = 30,
                    display_icon = "",
                    display_order = 1,
                    api_url = "",
                    is_visible_to_menu = true,
                    created_by = 1,
                    module_id = 1,
                    web_url = "#"
                },
                 new Menu
                 {
                     Id = 32,
                     name = "Notices",
                     parent_menu_id = null,
                     display_icon = "",
                     display_order = 1,
                     api_url = "",
                     is_visible_to_menu = true,
                     created_by = 1,
                     module_id = 2,
                     web_url = "/cms/notice/index"

                 },
                    new Menu
                    {
                        Id = 33,
                        name = "Create",
                        parent_menu_id = 32,
                        display_icon = "",
                        display_order = 1,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/notice/create"

                    },
                    new Menu
                    {
                        Id = 34,
                        name = "Update",
                        parent_menu_id = 32,
                        display_icon = "",
                        display_order = 2,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/notice/update"

                    },
                     new Menu
                     {
                         Id = 35,
                         name = "Delete",
                         parent_menu_id = 32,
                         display_icon = "",
                         display_order = 3,
                         api_url = "",
                         is_visible_to_menu = false,
                         created_by = 1,
                         module_id = 2,
                         web_url = "/cms/notice/delete"

                     },
                      new Menu
                      {
                          Id = 36,
                          name = "Enable",
                          parent_menu_id = 32,
                          display_icon = "",
                          display_order = 4,
                          api_url = "",
                          is_visible_to_menu = false,
                          created_by = 1,
                          module_id = 2,
                          web_url = "/cms/notice/enable"

                      },
                       new Menu
                       {
                           Id = 37,
                           name = "Disable",
                           parent_menu_id = 32,
                           display_icon = "",
                           display_order = 5,
                           api_url = "",
                           is_visible_to_menu = false,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/notice/disable"

                       },
                        new Menu
                        {
                            Id = 38,
                            name = "Events",
                            parent_menu_id = null,
                            display_icon = "",
                            display_order = 2,
                            api_url = "",
                            is_visible_to_menu = true,
                            created_by = 1,
                            module_id = 2,
                            web_url = "/cms/event/index"

                        },
                    new Menu
                    {
                        Id = 39,
                        name = "Create",
                        parent_menu_id = 38,
                        display_icon = "",
                        display_order = 1,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/event/create"

                    },
                    new Menu
                    {
                        Id = 40,
                        name = "Update",
                        parent_menu_id = 38,
                        display_icon = "",
                        display_order = 2,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/event/update"

                    },
                     new Menu
                     {
                         Id = 41,
                         name = "Delete",
                         parent_menu_id = 38,
                         display_icon = "",
                         display_order = 3,
                         api_url = "",
                         is_visible_to_menu = false,
                         created_by = 1,
                         module_id = 2,
                         web_url = "/cms/event/delete"

                     },
                      new Menu
                      {
                          Id = 42,
                          name = "Enable",
                          parent_menu_id = 38,
                          display_icon = "",
                          display_order = 4,
                          api_url = "",
                          is_visible_to_menu = false,
                          created_by = 1,
                          module_id = 2,
                          web_url = "/cms/event/enable"
                      },
                       new Menu
                       {
                           Id = 43,
                           name = "Disable",
                           parent_menu_id = 38,
                           display_icon = "",
                           display_order = 5,
                           api_url = "",
                           is_visible_to_menu = false,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/event/disable"
                       },
                       new Menu
                       {
                           Id = 44,
                           name = "Careers",
                           parent_menu_id = null,
                           display_icon = "",
                           display_order = 3,
                           api_url = "",
                           is_visible_to_menu = true,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/career/index"

                       },
                    new Menu
                    {
                        Id = 45,
                        name = "Create",
                        parent_menu_id = 44,
                        display_icon = "",
                        display_order = 1,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/career/create"

                    },
                    new Menu
                    {
                        Id = 46,
                        name = "Update",
                        parent_menu_id = 44,
                        display_icon = "",
                        display_order = 2,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/career/update"

                    },
                     new Menu
                     {
                         Id = 47,
                         name = "Delete",
                         parent_menu_id = 44,
                         display_icon = "",
                         display_order = 3,
                         api_url = "",
                         is_visible_to_menu = false,
                         created_by = 1,
                         module_id = 2,
                         web_url = "/cms/career/delete"

                     },
                      new Menu
                      {
                          Id = 48,
                          name = "Enable",
                          parent_menu_id = 44,
                          display_icon = "",
                          display_order = 4,
                          api_url = "",
                          is_visible_to_menu = false,
                          created_by = 1,
                          module_id = 2,
                          web_url = "/cms/career/enable"
                      },
                       new Menu
                       {
                           Id = 49,
                           name = "Disable",
                           parent_menu_id = 44,
                           display_icon = "",
                           display_order = 5,
                           api_url = "",
                           is_visible_to_menu = false,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/career/disable"
                       },
                       new Menu
                       {
                           Id = 50,
                           name = "Pages",
                           parent_menu_id = null,
                           display_icon = "",
                           display_order = 4,
                           api_url = "",
                           is_visible_to_menu = true,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/page/index"

                       },
                    new Menu
                    {
                        Id = 51,
                        name = "Create",
                        parent_menu_id = 50,
                        display_icon = "",
                        display_order = 1,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/page/create"

                    },
                    new Menu
                    {
                        Id = 52,
                        name = "Update",
                        parent_menu_id = 50,
                        display_icon = "",
                        display_order = 2,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/page/update"

                    },
                     new Menu
                     {
                         Id = 53,
                         name = "Delete",
                         parent_menu_id = 50,
                         display_icon = "",
                         display_order = 3,
                         api_url = "",
                         is_visible_to_menu = false,
                         created_by = 1,
                         module_id = 2,
                         web_url = "/cms/page/delete"

                     },
                      new Menu
                      {
                          Id = 54,
                          name = "Enable",
                          parent_menu_id = 50,
                          display_icon = "",
                          display_order = 4,
                          api_url = "",
                          is_visible_to_menu = false,
                          created_by = 1,
                          module_id = 2,
                          web_url = "/cms/page/enable"
                      },
                       new Menu
                       {
                           Id = 55,
                           name = "Disable",
                           parent_menu_id = 50,
                           display_icon = "",
                           display_order = 5,
                           api_url = "",
                           is_visible_to_menu = false,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/page/disable"
                       },
                       new Menu
                       {
                           Id = 56,
                           name = "Gallery Images",
                           parent_menu_id = null,
                           display_icon = "",
                           display_order = 5,
                           api_url = "",
                           is_visible_to_menu = true,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/gallery-image/index"

                       },
                    new Menu
                    {
                        Id = 57,
                        name = "Create",
                        parent_menu_id = 56,
                        display_icon = "",
                        display_order = 1,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/gallery-image/create"

                    },
                    new Menu
                    {
                        Id = 58,
                        name = "Update",
                        parent_menu_id = 56,
                        display_icon = "",
                        display_order = 2,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/galleryimage/update"

                    },
                     new Menu
                     {
                         Id = 59,
                         name = "Delete",
                         parent_menu_id = 56,
                         display_icon = "",
                         display_order = 3,
                         api_url = "",
                         is_visible_to_menu = false,
                         created_by = 1,
                         module_id = 2,
                         web_url = "/cms/gallery-image/delete"

                     },
                      new Menu
                      {
                          Id = 60,
                          name = "Enable",
                          parent_menu_id = 56,
                          display_icon = "",
                          display_order = 4,
                          api_url = "",
                          is_visible_to_menu = false,
                          created_by = 1,
                          module_id = 2,
                          web_url = "/cms/gallery-image/enable"
                      },
                       new Menu
                       {
                           Id = 61,
                           name = "Disable",
                           parent_menu_id = 56,
                           display_icon = "",
                           display_order = 5,
                           api_url = "",
                           is_visible_to_menu = false,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/gallery-image/disable"
                       },
                       new Menu
                       {
                           Id = 62,
                           name = "Team",
                           parent_menu_id = null,
                           display_icon = "",
                           display_order = 6,
                           api_url = "",
                           is_visible_to_menu = true,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/team/index"

                       },
                    new Menu
                    {
                        Id = 63,
                        name = "Create",
                        parent_menu_id = 62,
                        display_icon = "",
                        display_order = 1,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/team/create"

                    },
                    new Menu
                    {
                        Id = 64,
                        name = "Update",
                        parent_menu_id = 62,
                        display_icon = "",
                        display_order = 2,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/team/update"

                    },
                     new Menu
                     {
                         Id = 65,
                         name = "Delete",
                         parent_menu_id = 62,
                         display_icon = "",
                         display_order = 3,
                         api_url = "",
                         is_visible_to_menu = false,
                         created_by = 1,
                         module_id = 2,
                         web_url = "/cms/team/delete"

                     },
                      new Menu
                      {
                          Id = 66,
                          name = "Enable",
                          parent_menu_id = 62,
                          display_icon = "",
                          display_order = 4,
                          api_url = "",
                          is_visible_to_menu = false,
                          created_by = 1,
                          module_id = 2,
                          web_url = "/cms/team/enable"
                      },
                       new Menu
                       {
                           Id = 67,
                           name = "Disable",
                           parent_menu_id = 62,
                           display_icon = "",
                           display_order = 5,
                           api_url = "",
                           is_visible_to_menu = false,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/team/disable"
                       }
                       ,
                       new Menu
                       {
                           Id = 68,
                           name = "Videos",
                           parent_menu_id = null,
                           display_icon = "",
                           display_order = 7,
                           api_url = "",
                           is_visible_to_menu = true,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/videos/index"

                       },
                    new Menu
                    {
                        Id = 69,
                        name = "Create",
                        parent_menu_id = 68,
                        display_icon = "",
                        display_order = 1,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/videos/create"

                    },
                    new Menu
                    {
                        Id = 70,
                        name = "Update",
                        parent_menu_id = 68,
                        display_icon = "",
                        display_order = 2,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/videos/update"

                    },
                     new Menu
                     {
                         Id = 71,
                         name = "Delete",
                         parent_menu_id = 68,
                         display_icon = "",
                         display_order = 3,
                         api_url = "",
                         is_visible_to_menu = false,
                         created_by = 1,
                         module_id = 2,
                         web_url = "/cms/videos/delete"

                     },
                      new Menu
                      {
                          Id = 72,
                          name = "Enable",
                          parent_menu_id = 68,
                          display_icon = "",
                          display_order = 4,
                          api_url = "",
                          is_visible_to_menu = false,
                          created_by = 1,
                          module_id = 2,
                          web_url = "/cms/videos/enable"
                      },
                       new Menu
                       {
                           Id = 73,
                           name = "Disable",
                           parent_menu_id = 68,
                           display_icon = "",
                           display_order = 5,
                           api_url = "",
                           is_visible_to_menu = false,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/videos/disable"
                       },
                       new Menu
                       {
                           Id = 74,
                           name = "Others",
                           parent_menu_id = null,
                           display_icon = "",
                           display_order = 1,
                           api_url = "",
                           is_visible_to_menu = true,
                           created_by = 1,
                           module_id = 2,
                           web_url = "#"
                       },
                       new Menu
                       {
                           Id = 75,
                           name = "Blogs",
                           parent_menu_id = 74,
                           display_icon = "",
                           display_order = 1,
                           api_url = "",
                           is_visible_to_menu = true,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/blog/index"

                       },
                    new Menu
                    {
                        Id = 76,
                        name = "Create",
                        parent_menu_id = 75,
                        display_icon = "",
                        display_order = 1,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/blog/create"

                    },
                    new Menu
                    {
                        Id = 77,
                        name = "Update",
                        parent_menu_id = 75,
                        display_icon = "",
                        display_order = 2,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/blog/update"

                    },
                     new Menu
                     {
                         Id = 78,
                         name = "Delete",
                         parent_menu_id = 75,
                         display_icon = "",
                         display_order = 3,
                         api_url = "",
                         is_visible_to_menu = false,
                         created_by = 1,
                         module_id = 2,
                         web_url = "/cms/blog/delete"

                     },
                      new Menu
                      {
                          Id = 79,
                          name = "Enable",
                          parent_menu_id = 75,
                          display_icon = "",
                          display_order = 4,
                          api_url = "",
                          is_visible_to_menu = false,
                          created_by = 1,
                          module_id = 2,
                          web_url = "/cms/blog/enable"
                      },
                       new Menu
                       {
                           Id = 80,
                           name = "Disable",
                           parent_menu_id = 75,
                           display_icon = "",
                           display_order = 5,
                           api_url = "",
                           is_visible_to_menu = false,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/blog/disable"
                       },
                       new Menu
                       {
                           Id = 81,
                           name = "News",
                           parent_menu_id = 74,
                           display_icon = "",
                           display_order = 1,
                           api_url = "",
                           is_visible_to_menu = true,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/news/index"

                       },
                    new Menu
                    {
                        Id = 82,
                        name = "Create",
                        parent_menu_id = 81,
                        display_icon = "",
                        display_order = 1,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/news/create"

                    },
                    new Menu
                    {
                        Id = 83,
                        name = "Update",
                        parent_menu_id = 81,
                        display_icon = "",
                        display_order = 2,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/news/update"

                    },
                     new Menu
                     {
                         Id = 84,
                         name = "Delete",
                         parent_menu_id = 81,
                         display_icon = "",
                         display_order = 3,
                         api_url = "",
                         is_visible_to_menu = false,
                         created_by = 1,
                         module_id = 2,
                         web_url = "/cms/news/delete"

                     },
                      new Menu
                      {
                          Id = 85,
                          name = "Enable",
                          parent_menu_id = 81,
                          display_icon = "",
                          display_order = 4,
                          api_url = "",
                          is_visible_to_menu = false,
                          created_by = 1,
                          module_id = 2,
                          web_url = "/cms/news/enable"
                      },
                       new Menu
                       {
                           Id = 86,
                           name = "Disable",
                           parent_menu_id = 81,
                           display_icon = "",
                           display_order = 5,
                           api_url = "",
                           is_visible_to_menu = false,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/news/disable"
                       },
                       new Menu
                       {
                           Id = 87,
                           name = "FAQ",
                           parent_menu_id = 74,
                           display_icon = "",
                           display_order = 1,
                           api_url = "",
                           is_visible_to_menu = true,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/faq/index"

                       },
                    new Menu
                    {
                        Id = 88,
                        name = "Create",
                        parent_menu_id = 87,
                        display_icon = "",
                        display_order = 1,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/faq/create"

                    },
                    new Menu
                    {
                        Id = 89,
                        name = "Update",
                        parent_menu_id = 87,
                        display_icon = "",
                        display_order = 2,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/faq/update"

                    },
                     new Menu
                     {
                         Id = 90,
                         name = "Delete",
                         parent_menu_id = 87,
                         display_icon = "",
                         display_order = 3,
                         api_url = "",
                         is_visible_to_menu = false,
                         created_by = 1,
                         module_id = 2,
                         web_url = "/cms/faq/delete"

                     },
                      new Menu
                      {
                          Id = 91,
                          name = "Enable",
                          parent_menu_id = 87,
                          display_icon = "",
                          display_order = 4,
                          api_url = "",
                          is_visible_to_menu = false,
                          created_by = 1,
                          module_id = 2,
                          web_url = "/cms/faq/enable"
                      },
                       new Menu
                       {
                           Id = 92,
                           name = "Disable",
                           parent_menu_id = 87,
                           display_icon = "",
                           display_order = 5,
                           api_url = "",
                           is_visible_to_menu = false,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/faq/disable"
                       }
                       ,
                       new Menu
                       {
                           Id = 93,
                           name = "Testimonials",
                           parent_menu_id = 74,
                           display_icon = "",
                           display_order = 1,
                           api_url = "",
                           is_visible_to_menu = true,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/testimonials/index"

                       },
                    new Menu
                    {
                        Id = 94,
                        name = "Create",
                        parent_menu_id = 93,
                        display_icon = "",
                        display_order = 1,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/testimonials/create"

                    },
                    new Menu
                    {
                        Id = 95,
                        name = "Update",
                        parent_menu_id = 93,
                        display_icon = "",
                        display_order = 2,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/testimonials/update"

                    },
                     new Menu
                     {
                         Id = 96,
                         name = "Delete",
                         parent_menu_id = 93,
                         display_icon = "",
                         display_order = 3,
                         api_url = "",
                         is_visible_to_menu = false,
                         created_by = 1,
                         module_id = 2,
                         web_url = "/cms/testimonials/delete"

                     },
                      new Menu
                      {
                          Id = 97,
                          name = "Enable",
                          parent_menu_id = 93,
                          display_icon = "",
                          display_order = 4,
                          api_url = "",
                          is_visible_to_menu = false,
                          created_by = 1,
                          module_id = 2,
                          web_url = "/cms/testimonials/enable"
                      },
                       new Menu
                       {
                           Id = 98,
                           name = "Disable",
                           parent_menu_id = 93,
                           display_icon = "",
                           display_order = 5,
                           api_url = "",
                           is_visible_to_menu = false,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/testimonials/disable"
                       },
                       new Menu
                       {
                           Id = 99,
                           name = "Clients",
                           parent_menu_id = 74,
                           display_icon = "",
                           display_order = 1,
                           api_url = "",
                           is_visible_to_menu = true,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/our-clients/index"

                       },
                    new Menu
                    {
                        Id = 100,
                        name = "Create",
                        parent_menu_id = 99,
                        display_icon = "",
                        display_order = 1,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/our-clients/create"

                    },
                    new Menu
                    {
                        Id = 101,
                        name = "Update",
                        parent_menu_id = 99,
                        display_icon = "",
                        display_order = 2,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/our-clients/update"

                    },
                     new Menu
                     {
                         Id = 102,
                         name = "Delete",
                         parent_menu_id = 99,
                         display_icon = "",
                         display_order = 3,
                         api_url = "",
                         is_visible_to_menu = false,
                         created_by = 1,
                         module_id = 2,
                         web_url = "/cms/our-clients/delete"

                     },
                      new Menu
                      {
                          Id = 103,
                          name = "Enable",
                          parent_menu_id = 99,
                          display_icon = "",
                          display_order = 4,
                          api_url = "",
                          is_visible_to_menu = false,
                          created_by = 1,
                          module_id = 2,
                          web_url = "/cms/our-clients/enable"
                      },
                       new Menu
                       {
                           Id = 104,
                           name = "Disable",
                           parent_menu_id = 99,
                           display_icon = "",
                           display_order = 5,
                           api_url = "",
                           is_visible_to_menu = false,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/our-clients/disable"
                       },
                       new Menu
                       {
                           Id = 105,
                           name = "Subscribers",
                           parent_menu_id = 74,
                           display_icon = "",
                           display_order = 1,
                           api_url = "",
                           is_visible_to_menu = true,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/subscriber/index"

                       },
                    new Menu
                    {
                        Id = 106,
                        name = "Create",
                        parent_menu_id = 105,
                        display_icon = "",
                        display_order = 1,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/subscriber/create"

                    },
                    new Menu
                    {
                        Id = 107,
                        name = "Update",
                        parent_menu_id = 105,
                        display_icon = "",
                        display_order = 2,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/subscriber/update"

                    },
                     new Menu
                     {
                         Id = 108,
                         name = "Delete",
                         parent_menu_id = 105,
                         display_icon = "",
                         display_order = 3,
                         api_url = "",
                         is_visible_to_menu = false,
                         created_by = 1,
                         module_id = 2,
                         web_url = "/cms/subscriber/delete"
                     },
                       new Menu
                       {
                           Id = 109,
                           name = "Advertisement",
                           parent_menu_id = 74,
                           display_icon = "",
                           display_order = 1,
                           api_url = "",
                           is_visible_to_menu = true,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/advertisement/index"

                       },
                    new Menu
                    {
                        Id = 110,
                        name = "Create",
                        parent_menu_id = 109,
                        display_icon = "",
                        display_order = 1,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/advertisement/create"

                    },
                    new Menu
                    {
                        Id = 111,
                        name = "Update",
                        parent_menu_id = 109,
                        display_icon = "",
                        display_order = 2,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/advertisement/update"

                    },
                     new Menu
                     {
                         Id = 112,
                         name = "Delete",
                         parent_menu_id = 109,
                         display_icon = "",
                         display_order = 3,
                         api_url = "",
                         is_visible_to_menu = false,
                         created_by = 1,
                         module_id = 2,
                         web_url = "/cms/advertisement/delete"

                     },
                      new Menu
                      {
                          Id = 113,
                          name = "Enable",
                          parent_menu_id = 109,
                          display_icon = "",
                          display_order = 4,
                          api_url = "",
                          is_visible_to_menu = false,
                          created_by = 1,
                          module_id = 2,
                          web_url = "/cms/advertisement/enable"
                      },
                       new Menu
                       {
                           Id = 114,
                           name = "Disable",
                           parent_menu_id = 109,
                           display_icon = "",
                           display_order = 5,
                           api_url = "",
                           is_visible_to_menu = false,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/advertisement/disable"
                       },
                       new Menu
                       {
                           Id = 115,
                           name = "Setup",
                           parent_menu_id = null,
                           display_icon = "",
                           display_order = 3,
                           api_url = "",
                           is_visible_to_menu = true,
                           created_by = 1,
                           module_id = 2,
                           web_url = "#"
                       },
                       new Menu
                       {
                           Id = 116,
                           name = "Author",
                           parent_menu_id = 115,
                           display_icon = "",
                           display_order = 1,
                           api_url = "",
                           is_visible_to_menu = true,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/author/index"

                       },
                    new Menu
                    {
                        Id = 117,
                        name = "Create",
                        parent_menu_id = 116,
                        display_icon = "",
                        display_order = 1,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/author/create"

                    },
                    new Menu
                    {
                        Id = 118,
                        name = "Update",
                        parent_menu_id = 116,
                        display_icon = "",
                        display_order = 2,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/author/update"

                    },
                     new Menu
                     {
                         Id = 119,
                         name = "Delete",
                         parent_menu_id = 116,
                         display_icon = "",
                         display_order = 3,
                         api_url = "",
                         is_visible_to_menu = false,
                         created_by = 1,
                         module_id = 2,
                         web_url = "/cms/author/delete"

                     },
                      new Menu
                      {
                          Id = 120,
                          name = "Enable",
                          parent_menu_id = 116,
                          display_icon = "",
                          display_order = 4,
                          api_url = "",
                          is_visible_to_menu = false,
                          created_by = 1,
                          module_id = 2,
                          web_url = "/cms/author/enable"
                      },
                       new Menu
                       {
                           Id = 121,
                           name = "Disable",
                           parent_menu_id = 116,
                           display_icon = "",
                           display_order = 5,
                           api_url = "",
                           is_visible_to_menu = false,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/author/disable"
                       }
                       ,
                       new Menu
                       {
                           Id = 122,
                           name = "Designation",
                           parent_menu_id = 115,
                           display_icon = "",
                           display_order = 1,
                           api_url = "",
                           is_visible_to_menu = true,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/designation/index"

                       },
                    new Menu
                    {
                        Id = 123,
                        name = "Create",
                        parent_menu_id = 122,
                        display_icon = "",
                        display_order = 1,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/designation/create"

                    },
                    new Menu
                    {
                        Id = 124,
                        name = "Update",
                        parent_menu_id = 122,
                        display_icon = "",
                        display_order = 2,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/designation/update"

                    },
                     new Menu
                     {
                         Id = 125,
                         name = "Delete",
                         parent_menu_id = 122,
                         display_icon = "",
                         display_order = 3,
                         api_url = "",
                         is_visible_to_menu = false,
                         created_by = 1,
                         module_id = 2,
                         web_url = "/cms/designation/delete"

                     },
                      new Menu
                      {
                          Id = 126,
                          name = "Enable",
                          parent_menu_id = 122,
                          display_icon = "",
                          display_order = 4,
                          api_url = "",
                          is_visible_to_menu = false,
                          created_by = 1,
                          module_id = 2,
                          web_url = "/cms/designation/enable"
                      },
                       new Menu
                       {
                           Id = 127,
                           name = "Disable",
                           parent_menu_id = 122,
                           display_icon = "",
                           display_order = 5,
                           api_url = "",
                           is_visible_to_menu = false,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/designation/disable"
                       },
                       new Menu
                       {
                           Id = 128,
                           name = "Page Category",
                           parent_menu_id = 115,
                           display_icon = "",
                           display_order = 1,
                           api_url = "",
                           is_visible_to_menu = true,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/page-category/index"

                       },
                    new Menu
                    {
                        Id = 129,
                        name = "Create",
                        parent_menu_id = 128,
                        display_icon = "",
                        display_order = 1,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/page-category/create"

                    },
                    new Menu
                    {
                        Id = 130,
                        name = "Update",
                        parent_menu_id = 128,
                        display_icon = "",
                        display_order = 2,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/page-category/update"

                    },
                     new Menu
                     {
                         Id = 131,
                         name = "Delete",
                         parent_menu_id = 128,
                         display_icon = "",
                         display_order = 3,
                         api_url = "",
                         is_visible_to_menu = false,
                         created_by = 1,
                         module_id = 2,
                         web_url = "/cms/page-category/delete"

                     },
                      new Menu
                      {
                          Id = 132,
                          name = "Enable",
                          parent_menu_id = 128,
                          display_icon = "",
                          display_order = 4,
                          api_url = "",
                          is_visible_to_menu = false,
                          created_by = 1,
                          module_id = 2,
                          web_url = "/cms/page-category/enable"
                      },
                       new Menu
                       {
                           Id = 133,
                           name = "Disable",
                           parent_menu_id = 128,
                           display_icon = "",
                           display_order = 5,
                           api_url = "",
                           is_visible_to_menu = false,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/page-category/disable"
                       },
                       new Menu
                       {
                           Id = 134,
                           name = "Blog Category",
                           parent_menu_id = 115,
                           display_icon = "",
                           display_order = 1,
                           api_url = "",
                           is_visible_to_menu = true,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/blog-category/index"

                       },
                    new Menu
                    {
                        Id = 135,
                        name = "Create",
                        parent_menu_id = 134,
                        display_icon = "",
                        display_order = 1,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/blog-category/create"

                    },
                    new Menu
                    {
                        Id = 136,
                        name = "Update",
                        parent_menu_id = 134,
                        display_icon = "",
                        display_order = 2,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/blog-category/update"

                    },
                     new Menu
                     {
                         Id = 137,
                         name = "Delete",
                         parent_menu_id = 134,
                         display_icon = "",
                         display_order = 3,
                         api_url = "",
                         is_visible_to_menu = false,
                         created_by = 1,
                         module_id = 2,
                         web_url = "/cms/blog-category/delete"

                     },
                      new Menu
                      {
                          Id = 138,
                          name = "Enable",
                          parent_menu_id = 134,
                          display_icon = "",
                          display_order = 4,
                          api_url = "",
                          is_visible_to_menu = false,
                          created_by = 1,
                          module_id = 2,
                          web_url = "/cms/blog-category/enable"
                      },
                       new Menu
                       {
                           Id = 139,
                           name = "Disable",
                           parent_menu_id = 134,
                           display_icon = "",
                           display_order = 5,
                           api_url = "",
                           is_visible_to_menu = false,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/blog-category/disable"
                       },
                       new Menu
                       {
                           Id = 140,
                           name = "News Category",
                           parent_menu_id = 115,
                           display_icon = "",
                           display_order = 1,
                           api_url = "",
                           is_visible_to_menu = true,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/news-category/index"

                       },
                    new Menu
                    {
                        Id = 141,
                        name = "Create",
                        parent_menu_id = 140,
                        display_icon = "",
                        display_order = 1,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/news-category/create"

                    },
                    new Menu
                    {
                        Id = 142,
                        name = "Update",
                        parent_menu_id = 140,
                        display_icon = "",
                        display_order = 2,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/news-category/update"

                    },
                     new Menu
                     {
                         Id = 143,
                         name = "Delete",
                         parent_menu_id = 140,
                         display_icon = "",
                         display_order = 3,
                         api_url = "",
                         is_visible_to_menu = false,
                         created_by = 1,
                         module_id = 2,
                         web_url = "/cms/news-category/delete"

                     },
                      new Menu
                      {
                          Id = 144,
                          name = "Enable",
                          parent_menu_id = 140,
                          display_icon = "",
                          display_order = 4,
                          api_url = "",
                          is_visible_to_menu = false,
                          created_by = 1,
                          module_id = 2,
                          web_url = "/cms/news-category/enable"
                      },
                       new Menu
                       {
                           Id = 145,
                           name = "Disable",
                           parent_menu_id = 140,
                           display_icon = "",
                           display_order = 5,
                           api_url = "",
                           is_visible_to_menu = false,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/news-category/disable"
                       },
                       new Menu
                       {
                           Id = 146,
                           name = "Gallery",
                           parent_menu_id = 115,
                           display_icon = "",
                           display_order = 1,
                           api_url = "",
                           is_visible_to_menu = true,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/gallery/index"

                       },
                    new Menu
                    {
                        Id = 147,
                        name = "Create",
                        parent_menu_id = 146,
                        display_icon = "",
                        display_order = 1,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/gallery/create"

                    },
                    new Menu
                    {
                        Id = 148,
                        name = "Update",
                        parent_menu_id = 146,
                        display_icon = "",
                        display_order = 2,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/gallery/update"

                    },
                     new Menu
                     {
                         Id = 149,
                         name = "Delete",
                         parent_menu_id = 146,
                         display_icon = "",
                         display_order = 3,
                         api_url = "",
                         is_visible_to_menu = false,
                         created_by = 1,
                         module_id = 2,
                         web_url = "/cms/gallery/delete"

                     },
                      new Menu
                      {
                          Id = 150,
                          name = "Enable",
                          parent_menu_id = 146,
                          display_icon = "",
                          display_order = 4,
                          api_url = "",
                          is_visible_to_menu = false,
                          created_by = 1,
                          module_id = 2,
                          web_url = "/cms/gallery/enable"
                      },
                       new Menu
                       {
                           Id = 151,
                           name = "Disable",
                           parent_menu_id = 146,
                           display_icon = "",
                           display_order = 5,
                           api_url = "",
                           is_visible_to_menu = false,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/gallery/disable"
                       },
                        new Menu
                        {
                            Id = 152,
                            name = "Make Slider",
                            parent_menu_id = 56,
                            display_icon = "",
                            display_order = 7,
                            api_url = "",
                            is_visible_to_menu = false,
                            created_by = 1,
                            module_id = 2,
                            web_url = "/cms/gallery-image/make-slider"
                        },
                       new Menu
                       {
                           Id = 153,
                           name = "Unmake Slider",
                           parent_menu_id = 56,
                           display_icon = "",
                           display_order = 8,
                           api_url = "",
                           is_visible_to_menu = false,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/gallery-image/unmake-slider"
                       }
                       ,
                        new Menu
                        {
                            Id = 154,
                            name = "Make Home Page",
                            parent_menu_id = 50,
                            display_icon = "",
                            display_order = 7,
                            api_url = "",
                            is_visible_to_menu = false,
                            created_by = 1,
                            module_id = 2,
                            web_url = "/cms/page/make-homepage"
                        },
                         new Menu
                         {
                             Id = 155,
                             name = "Links",
                             parent_menu_id = 115,
                             display_icon = "",
                             display_order = 1,
                             api_url = "",
                             is_visible_to_menu = true,
                             created_by = 1,
                             module_id = 2,
                             web_url = "/cms/links/index"

                         },
                    new Menu
                    {
                        Id = 156,
                        name = "Create",
                        parent_menu_id = 155,
                        display_icon = "",
                        display_order = 1,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/links/create"

                    },
                    new Menu
                    {
                        Id = 157,
                        name = "Update",
                        parent_menu_id = 155,
                        display_icon = "",
                        display_order = 2,
                        api_url = "",
                        is_visible_to_menu = false,
                        created_by = 1,
                        module_id = 2,
                        web_url = "/cms/links/update"

                    },
                     new Menu
                     {
                         Id = 158,
                         name = "Delete",
                         parent_menu_id = 155,
                         display_icon = "",
                         display_order = 3,
                         api_url = "",
                         is_visible_to_menu = false,
                         created_by = 1,
                         module_id = 2,
                         web_url = "/cms/links/delete"

                     },
                      new Menu
                      {
                          Id = 159,
                          name = "Enable",
                          parent_menu_id = 155,
                          display_icon = "",
                          display_order = 4,
                          api_url = "",
                          is_visible_to_menu = false,
                          created_by = 1,
                          module_id = 2,
                          web_url = "/cms/links/enable"
                      },
                       new Menu
                       {
                           Id = 160,
                           name = "Disable",
                           parent_menu_id = 155,
                           display_icon = "",
                           display_order = 5,
                           api_url = "",
                           is_visible_to_menu = false,
                           created_by = 1,
                           module_id = 2,
                           web_url = "/cms/links/disable"
                       }
                );
            //read 0010
            //create 0011
            //update 0012
            //delete 0013

            modelBuilder.Entity<MenuPermissionMap>().HasData(
                new MenuPermissionMap
                {
                    Id = 1,
                    menu_id = 1,
                    permissions = "H4-0010",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 2,
                    menu_id = 2,
                    permissions = "H4-0011",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 3,
                    menu_id = 3,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 4,
                    menu_id = 4,
                    permissions = "H4-0013",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 5,
                    menu_id = 5,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 6,
                    menu_id = 6,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 7,
                    menu_id = 7,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 8,
                    menu_id = 8,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 9,
                    menu_id = 10,
                    permissions = "H4-0010",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 10,
                    menu_id = 11,
                    permissions = "H4-0011",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 11,
                    menu_id = 12,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 12,
                    menu_id = 13,
                    permissions = "H4-0013",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 13,
                    menu_id = 14,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 14,
                    menu_id = 15,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 15,
                    menu_id = 16,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 16,
                    menu_id = 17,
                    permissions = "H4-0010",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 17,
                    menu_id = 18,
                    permissions = "H4-0011",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 18,
                    menu_id = 19,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 19,
                    menu_id = 20,
                    permissions = "H4-0013",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 20,
                    menu_id = 21,
                    permissions = "H4-0010",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 21,
                    menu_id = 22,
                    permissions = "H4-0011",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 22,
                    menu_id = 23,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 23,
                    menu_id = 24,
                    permissions = "H4-0013",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 24,
                    menu_id = 25,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 25,
                    menu_id = 26,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 26,
                    menu_id = 28,
                    permissions = "H4-0011",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 27,
                    menu_id = 29,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 28,
                    menu_id = 32,
                    permissions = "H4-0010",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 29,
                    menu_id = 33,
                    permissions = "H4-0011",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 30,
                    menu_id = 34,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 31,
                    menu_id = 35,
                    permissions = "H4-0013",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 32,
                    menu_id = 36,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 33,
                    menu_id = 37,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 34,
                    menu_id = 38,
                    permissions = "H4-0010",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 35,
                    menu_id = 39,
                    permissions = "H4-0011",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 36,
                    menu_id = 40,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 37,
                    menu_id = 41,
                    permissions = "H4-0013",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 38,
                    menu_id = 42,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 39,
                    menu_id = 43,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 40,
                    menu_id = 44,
                    permissions = "H4-0010",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 41,
                    menu_id = 45,
                    permissions = "H4-0011",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 42,
                    menu_id = 46,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 43,
                    menu_id = 47,
                    permissions = "H4-0013",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 44,
                    menu_id = 48,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 45,
                    menu_id = 49,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 46,
                    menu_id = 50,
                    permissions = "H4-0010",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 47,
                    menu_id = 51,
                    permissions = "H4-0011",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 48,
                    menu_id = 52,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 49,
                    menu_id = 53,
                    permissions = "H4-0013",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 50,
                    menu_id = 54,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 51,
                    menu_id = 55,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 52,
                    menu_id = 56,
                    permissions = "H4-0010",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 53,
                    menu_id = 57,
                    permissions = "H4-0011",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 54,
                    menu_id = 58,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 55,
                    menu_id = 59,
                    permissions = "H4-0013",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 56,
                    menu_id = 60,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 57,
                    menu_id = 61,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 58,
                    menu_id = 62,
                    permissions = "H4-0010",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 59,
                    menu_id = 63,
                    permissions = "H4-0011",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 60,
                    menu_id = 64,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 61,
                    menu_id = 65,
                    permissions = "H4-0013",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 62,
                    menu_id = 66,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 63,
                    menu_id = 67,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 64,
                    menu_id = 68,
                    permissions = "H4-0010",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 65,
                    menu_id = 69,
                    permissions = "H4-0011",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 66,
                    menu_id = 70,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 67,
                    menu_id = 71,
                    permissions = "H4-0013",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 68,
                    menu_id = 72,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 69,
                    menu_id = 73,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 70,
                    menu_id = 75,
                    permissions = "H4-0010",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 71,
                    menu_id = 76,
                    permissions = "H4-0011",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 72,
                    menu_id = 77,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 73,
                    menu_id = 78,
                    permissions = "H4-0013",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 74,
                    menu_id = 79,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 75,
                    menu_id = 80,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 76,
                    menu_id = 81,
                    permissions = "H4-0010",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 77,
                    menu_id = 82,
                    permissions = "H4-0011",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 78,
                    menu_id = 83,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 79,
                    menu_id = 84,
                    permissions = "H4-0013",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 80,
                    menu_id = 85,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 81,
                    menu_id = 86,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                 new MenuPermissionMap
                 {
                     Id = 82,
                     menu_id = 87,
                     permissions = "H4-0010",
                     created_by = 1,
                     created_date = DateTime.Now
                 },
                new MenuPermissionMap
                {
                    Id = 83,
                    menu_id = 88,
                    permissions = "H4-0011",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 84,
                    menu_id = 89,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 85,
                    menu_id = 90,
                    permissions = "H4-0013",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 86,
                    menu_id = 91,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 87,
                    menu_id = 92,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 88,
                    menu_id = 93,
                    permissions = "H4-0010",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 89,
                    menu_id = 94,
                    permissions = "H4-0011",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 90,
                    menu_id = 95,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 91,
                    menu_id = 96,
                    permissions = "H4-0013",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 92,
                    menu_id = 97,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 93,
                    menu_id = 98,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 94,
                    menu_id = 99,
                    permissions = "H4-0010",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 95,
                    menu_id = 100,
                    permissions = "H4-0011",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 96,
                    menu_id = 101,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 97,
                    menu_id = 102,
                    permissions = "H4-0013",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 98,
                    menu_id = 103,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 99,
                    menu_id = 104,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 100,
                    menu_id = 105,
                    permissions = "H4-0010",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 101,
                    menu_id = 106,
                    permissions = "H4-0011",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 102,
                    menu_id = 107,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 103,
                    menu_id = 108,
                    permissions = "H4-0013",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 104,
                    menu_id = 109,
                    permissions = "H4-0010",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 105,
                    menu_id = 110,
                    permissions = "H4-0011",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 106,
                    menu_id = 111,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 107,
                    menu_id = 112,
                    permissions = "H4-0013",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 108,
                    menu_id = 113,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 109,
                    menu_id = 114,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 110,
                    menu_id = 116,
                    permissions = "H4-0010",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 111,
                    menu_id = 117,
                    permissions = "H4-0011",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 112,
                    menu_id = 118,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 113,
                    menu_id = 119,
                    permissions = "H4-0013",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 114,
                    menu_id = 120,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 115,
                    menu_id = 121,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 116,
                    menu_id = 122,
                    permissions = "H4-0010",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 117,
                    menu_id = 123,
                    permissions = "H4-0011",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 118,
                    menu_id = 124,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 119,
                    menu_id = 125,
                    permissions = "H4-0013",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 120,
                    menu_id = 126,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 121,
                    menu_id = 127,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                 new MenuPermissionMap
                 {
                     Id = 122,
                     menu_id = 128,
                     permissions = "H4-0010",
                     created_by = 1,
                     created_date = DateTime.Now
                 },
                new MenuPermissionMap
                {
                    Id = 123,
                    menu_id = 129,
                    permissions = "H4-0011",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 124,
                    menu_id = 130,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 125,
                    menu_id = 131,
                    permissions = "H4-0013",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 126,
                    menu_id = 132,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 127,
                    menu_id = 133,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 128,
                    menu_id = 134,
                    permissions = "H4-0010",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 129,
                    menu_id = 135,
                    permissions = "H4-0011",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 130,
                    menu_id = 136,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 131,
                    menu_id = 137,
                    permissions = "H4-0013",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 132,
                    menu_id = 138,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 133,
                    menu_id = 139,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 134,
                    menu_id = 140,
                    permissions = "H4-0010",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 135,
                    menu_id = 141,
                    permissions = "H4-0011",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 136,
                    menu_id = 142,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 137,
                    menu_id = 143,
                    permissions = "H4-0013",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 138,
                    menu_id = 144,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 139,
                    menu_id = 145,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 140,
                    menu_id = 146,
                    permissions = "H4-0010",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 141,
                    menu_id = 147,
                    permissions = "H4-0011",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 142,
                    menu_id = 148,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 143,
                    menu_id = 149,
                    permissions = "H4-0013",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 144,
                    menu_id = 150,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 145,
                    menu_id = 151,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 146,
                    menu_id = 152,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 147,
                    menu_id = 153,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 148,
                    menu_id = 154,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                 new MenuPermissionMap
                 {
                     Id = 149,
                     menu_id = 155,
                     permissions = "H4-0010",
                     created_by = 1,
                     created_date = DateTime.Now
                 },
                new MenuPermissionMap
                {
                    Id = 150,
                    menu_id = 156,
                    permissions = "H4-0011",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 151,
                    menu_id = 157,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 152,
                    menu_id = 158,
                    permissions = "H4-0013",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 153,
                    menu_id = 159,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                },
                new MenuPermissionMap
                {
                    Id = 154,
                    menu_id = 160,
                    permissions = "H4-0012",
                    created_by = 1,
                    created_date = DateTime.Now
                }
                );
        }
    }
}
