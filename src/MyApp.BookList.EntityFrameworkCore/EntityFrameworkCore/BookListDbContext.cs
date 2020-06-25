using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyApp.BookList.Authorization.Roles;
using MyApp.BookList.Authorization.Users;
using MyApp.BookList.MultiTenancy;
using MyApp.BookList.BookListManagement.Books;
using MyApp.BookList.BookListManagement.BookTags;
using MyApp.BookList.BookListManagement.BookList;

namespace MyApp.BookList.EntityFrameworkCore
{
    public class BookListDbContext : AbpZeroDbContext<Tenant, Role, User, BookListDbContext>
    {
        /* Define a DbSet for each entity of the application */

        #region 书单功能实体
            public DbSet<Books> Books { get; set; }

            public DbSet<CloudBooksList> BookLists { get; set; }
        
            public DbSet<BooksTag> BooksTags { get; set; }

        #endregion



        public BookListDbContext(DbContextOptions<BookListDbContext> options)
            : base(options)
        {
        }
    }
}
