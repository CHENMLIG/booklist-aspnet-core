using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.BookList.新文件夹
{
    /// <summary>
    /// 用户
    /// </summary>
    public class User:CreationAuditedEntity<long>
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name{ get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }
    }
}
