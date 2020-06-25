using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.BookList.BookListManagement.Books
{
    /// <summary>
    /// 书籍
    /// </summary>
   public class Books:CreationAuditedEntity<long>
    {
        /// <summary>
        /// 书名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 简介
        /// </summary>
        public string Info { get; set; }
        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }
         /// <summary>
         /// 链接
         /// </summary>
        public string Url { get; set; }
    }
}
