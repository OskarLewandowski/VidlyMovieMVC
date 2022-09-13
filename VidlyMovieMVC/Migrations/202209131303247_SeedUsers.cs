namespace VidlyMovieMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'33855e87-c7a0-4348-a6db-a2d7475a9516', N'admin@vidly.pl', 0, N'AOgsDJ8Qh1GezbrRclyXDrTQJjA4yEU/idzLXw9xQF8i3Iabu8Y/A4K4ZkWGrpkFsg==', N'c84a0825-2ca7-44ef-85dd-45f6d48a1783', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.pl')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'36e1d6be-8770-43c3-a7ae-4e5a06db1b6c', N'guest@vidly.pl', 0, N'AExrhZX5UsMQb+EeBcozU/Fg3+SrA2MccqJS0VBPuJvTlFcE0sO/rHhOFJqSI7cXPA==', N'8ebc3eb0-acf2-424f-a7fe-a50c127d45c4', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.pl')
                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'aa18b9dd-be49-4e02-85f8-d09c74b260d8', N'CanManageMovies')
                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'33855e87-c7a0-4348-a6db-a2d7475a9516', N'aa18b9dd-be49-4e02-85f8-d09c74b260d8')
                ");
        }

        public override void Down()
        {
        }
    }
}
