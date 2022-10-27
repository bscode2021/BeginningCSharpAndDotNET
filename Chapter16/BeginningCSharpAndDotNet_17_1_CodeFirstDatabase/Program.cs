using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;
using static System.Console;

using (var db = new BookContext())
{
    Book book1 = new Book { Title = "Beginning C# and .NET", Author = "Perkins and Reid" };
    db.Books.Add(book1);

    Book book2 = new Book { Title = "Beginning XML", Author = "Fawcett, Quin, and Ayers" };
    db.Books.Add(book2);

    db.SaveChanges();

    var query = from b in db.Books
                orderby b.Title
                select b;

    WriteLine("All books in the database:");
    foreach (var b in query)
    {
        WriteLine($"{b.Title} by {b.Author}, code={b.Code}");
    }
    WriteLine("Press a key to exit...");
    ReadKey();
}

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    [Key] public int Code { get; set; }
}

public class Person
{
    public int PersonID { get; set; }
    public string LastName { get; set; }
    public string FirstName  { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
}

public class BookContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Database=Books;Integrated Security=True");
    }
}