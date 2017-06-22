namespace Movies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'342667be-c661-425e-9c84-4ca3cb737953', N'admin@pedro.com', 0, N'AFmChqM17422JkWCnQ3Jz1hfTuiXFqwOWUMElDi8oxEyDqeZvU6OcJ1OZz15lFDiIA==', N'b6a27001-5c23-4f3a-9e94-d3ca3488f541', NULL, 0, 0, NULL, 1, 0, N'admin@pedro.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'50e55daf-0692-45f4-b88a-6e2b429ba1d5', N'guest@pedro.com', 0, N'AJHYKxmQCiI1wwD/diUwEejmKsIu3cw677yy6azDNrDYviI3COYai5qyjTcuSUeiBw==', N'efbe2323-e67f-4a0f-8639-a3ff796a865f', NULL, 0, 0, NULL, 1, 0, N'guest@pedro.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f47c9cee-7031-4fe4-84ab-1ceb3d52fca9', N'pedro.tavares@mydit.ie', 0, N'AIYhytUbFcJuMGP90GPRDxZW0rP29hMqstcK0Dr6j6VeN+cyc4ygQA8sCJUYzS0gKA==', N'0043d700-813d-4f21-a5d6-46f7fe45c534', NULL, 0, 0, NULL, 1, 0, N'pedro.tavares@mydit.ie')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f480e193-7165-4118-9fd0-1753a8dc23b7', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'342667be-c661-425e-9c84-4ca3cb737953', N'f480e193-7165-4118-9fd0-1753a8dc23b7')

");
        }
        
        public override void Down()
        {
        }
    }
}
