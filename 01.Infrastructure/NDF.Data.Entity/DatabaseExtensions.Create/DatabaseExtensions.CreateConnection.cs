﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDF.Data.Entity
{
    public static partial class DatabaseExtensions
    {

        /// <summary>
        /// 创建并返回与当前 <see cref="DbProviderFactory"/> 关联的 <see cref="DbConnection"/> 对象。
        /// </summary>
        /// <param name="database">表示当前 <see cref="System.Data.Entity.Database"/> 对象。</param>
        /// <returns>与当前 <see cref="DbProviderFactory"/> 关联的 <see cref="DbConnection"/> 对象。</returns>
        public static DbConnection CreateConnection(this Database database)
        {
            return GetGeneralDatabase(database).CreateConnection();
        }

    }
}
