using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    [RoutePrefix("api/Product")]
    public class ProductController : ApiController
    {
        private IList<Product> _products = new List<Product>()
        {
            new Product() { Id = 1, Name = "aa", AddressAAA = "bj"},
            new Product() { Id = 2, Name = "b", AddressAAA = "sz"},
            new Product() { Id = 3, Name = "ccc", AddressAAA = "sh"}
        };

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(o => o.Id == id);
        }

        public IList<Product> GetProducts()
        {
            return _products;
        }

        //url: api/Product/GetProducts
        //[Route("GetProducts")]
        public PagedList<Product> GetProducts(int pageIndex, int pageSize)
        {
            var aa = Request.Headers.Accept;
            var re = aa.Contains(MediaTypeWithQualityHeaderValue.Parse("application/json")) ||
            aa.Contains(MediaTypeWithQualityHeaderValue.Parse("application/xml"));

            PagedList<Product> list = new PagedList<Product>(_products.AsQueryable(), pageIndex, pageSize);

            return list;
        }
    }
}
