using Core.Entities.Shared;

namespace Core.Entities
{
      public class Staff : EntityBase
      {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string AddressType { get; set; }
            public string StreetAddress { get; set; }
            public string Suburb { get; set; }
            public string City { get; set; }
            public string PostalCode { get; set; }
      }
}