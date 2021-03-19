using System.ComponentModel.DataAnnotations;
using Core.Entities.Shared;

namespace Core.Entities
{
      public class Product : EntityBase
      {
            public string Title { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
            public string ImageUrl { get; set; }
      }
}