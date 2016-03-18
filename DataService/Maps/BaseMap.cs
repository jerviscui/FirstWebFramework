﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace DataService.Maps
{
    public class BaseMap<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseMap(string tableName = "")
        {
            if (!string.IsNullOrEmpty(tableName))
            {
                this.ToTable(tableName);
            }

            this.HasKey(o => o.Id);
        }
    }
}
