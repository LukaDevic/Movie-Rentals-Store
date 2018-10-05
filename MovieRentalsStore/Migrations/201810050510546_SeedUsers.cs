namespace MovieRentalsStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'13037cf2-bc5a-49ee-9e9c-518d3c7c5210', N'admin@prodavnica.com', 0, N'AMPMtxf8rI3y0FmSlmrW57oN/DJOQ1KlOOAELGo5zpPWqzjYLQCsShhCsQDOGVydrQ==', N'1fb8dbde-5dfc-4c35-bb74-81f93ea8ad7d', NULL, 0, 0, NULL, 1, 0, N'admin@prodavnica.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8b5923fa-1651-4030-9701-74c0ea587f5c', N'guest@prodavnica.com', 0, N'AMUKaM+i1ju0BahD4nkYZQ6afdJhK8Rjznov3A0KO9ck751l5qV+y/eWfpNFwy8KEg==', N'd83951d1-dd82-4729-a7da-b8057cf0433a', NULL, 0, 0, NULL, 1, 0, N'guest@prodavnica.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9bc80b5e-32f4-4a66-a1a9-bd046f59a945', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'13037cf2-bc5a-49ee-9e9c-518d3c7c5210', N'9bc80b5e-32f4-4a66-a1a9-bd046f59a945')

");
        }
        
        public override void Down()
        {
        }
    }
}
