using System;
using System.Collections;
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
    public class SerialiazePagedList<T> : IPagedList
    {
        public SerialiazePagedList()
        {
            Items = new T[] {};
        }

        public SerialiazePagedList(PagedList<T> list)
        {
            Items = list.GetRange(0, list.Count).ToArray();
            PageIndex = list.PageIndex;
        }

        [DataMember]
        public T[] Items { get; set; }

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

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerator"/> object that can be used to iterate through the collection.
        /// </returns>
        public IEnumerator GetEnumerator()
        {
            return Items.GetEnumerator();
        }
    }
}
