using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class ProductFuture : BaseEntity
    {
        [MaxLength(50)]
        public string Future { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
