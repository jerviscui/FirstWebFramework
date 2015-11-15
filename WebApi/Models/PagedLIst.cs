using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace WebApi.Models
{
    [DataContract]
    public class PagedList<T> : List<T>, IPagedList
    {
        public PagedList()
        {
            this.AddRange(new List<T>());
            PageIndex = 0;
        }

        public PagedList(IQueryable<T> query, int pageIndex, int pageSize)
        {
            if (pageSize < 1)
            {
                throw new ArgumentException();
            }

            TotalCount = query.Count();
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalPages = (TotalCount + pageSize - 1) / pageSize;
            this.AddRange(query.Skip(pageIndex * pageSize).Take(pageSize));

            HasPreviousPage = PageIndex > 0;
            HasNextPage = PageIndex + 1 < TotalPages;
        }

        [DataMember]
        public int PageIndex { get; set; }

        [DataMember]
        public int PageSize { get; set; }
        
        [DataMember]
        public int TotalCount { get; private set; }

        [DataMember(Order = 1)]
        public int TotalPages { get; private set; }

        [DataMember(Order = 10)]
        public bool HasPreviousPage { get; private set; }

        [DataMember(Order = 10)]
        public bool HasNextPage { get; private set; }
    }
}
