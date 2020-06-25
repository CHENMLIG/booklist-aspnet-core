using Abp.Domain.Entities.Auditing;
using Microsoft.EntityFrameworkCore.Query.ExpressionVisitors.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.BookList.BookListManagement.BookList
{
    /// <summary>
    /// 书单
    /// </summary>
    public class CloudBooksList:CreationAuditedEntity<long>
    {
        /// <summary>
        /// 书单名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 书单简介
        /// </summary>
        public string Intro { get; set; }
    }
}
