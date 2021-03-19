using System;

namespace Core.Entities.Shared
{
      public class EntityBase
      {
            public int Id { get; set; }
            public DateTime DateCreated { get; set; }
            public DateTime DateModified { get; set; }
      }
}