namespace BooksApiMongoDb.Data.Configuration
{
    public interface IBooksDatabaseSettings
    {
        string BooksCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}