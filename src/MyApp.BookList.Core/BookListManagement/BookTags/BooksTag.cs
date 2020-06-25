using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.BookList.BookListManagement.BookTags
{
    /// <summary>
    /// 书单标签
    /// </summary>
    public class BooksTag:CreationAuditedEntity<long>
    {
        /// <summary>
        /// 标签名称
        /// </summary>
        public string TagName { get; set; }
    }
}
