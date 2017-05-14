namespace Movies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDbGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MoviesGenres (Id, Genre) VALUES (1, 'Comedy')");
            Sql("INSERT INTO MoviesGenres (Id, Genre) VALUES (2, 'Horror')");
            Sql("INSERT INTO MoviesGenres (Id, Genre) VALUES (3, 'Fiction')");
        }
        
        public override void Down()
        {
        }
    }
}
