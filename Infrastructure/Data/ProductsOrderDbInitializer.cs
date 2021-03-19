using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Infrastructure.Data
{
      public class ProductsOrderDbInitializer
      {
            public static async Task SeedData(ProductsOrderDbContext context)
            {
                  if (!context.Products.Any())
                  {
                        var products = new List<Product>()
                      {
                          new Product
                          {
                              Title = "MARGHERITA LARGE PIZZA",
                              Description = "The classic margherita pizza, need we say more?! Fluffy pizza base, with tomato based pizza sauce, topped with a blend of 100% cheddar and mozzarella, sprinkled with herbs and a final touch of green pepper.",
                              Price = 35.70M,
                              ImageUrl = "https://cdn.shopify.com/s/files/1/2399/2021/products/JBP7012_d8310096-c0a2-47a0-9a1a-aa041bfe2ed8_1024x1024.jpg?v=1612354124",
                              DateCreated = DateTime.Today,
                              DateModified = DateTime.Now
                          },
                           new Product
                          {
                              Title = "NAPOLI LARGE PIZZAS",
                              Description = "Pop one of our famous pizzas in your oven and watch the cheese drape over with oozy yumminess. Sublime!... We have 4 different flavours to choose from. Pizzas are 30cm, a industry standard large.",
                              Price = 42.0M,
                              ImageUrl = "https://cdn.shopify.com/s/files/1/2399/2021/products/20190911_143809_0000_1024x1024.png?v=1604659390",
                              DateCreated = DateTime.Today,
                              DateModified = DateTime.Now
                          },
                           new Product
                          {
                              Title = "Col’Cacchio Margherita Pizza",
                              Description = "This sourdough pizza base is made with local organic stoneground flour. We've smeared the base with an olive oil, tomato and onion mix – which means you can get creative when deciding which of your favourite toppings and cheese to use.",
                              Price = 45.0M,
                              ImageUrl = "https://cdn.shopify.com/s/files/1/0259/0670/8570/products/sourdough-pizza-base-15303954432090_720x.jpg?v=1609777522",
                              DateCreated = DateTime.Today,
                              DateModified = DateTime.Now
                          },
                           new Product
                          {
                              Title = "Col’Cacchio Pepperoni Pizza",
                              Description = "Freshly made Col’Cacchio Pepperoni Pizza. 425g | 30cm pizza base. Eat out while staying in with Col’Cacchio’s new Heat ‘n Eat gourmet pizza range. Enjoy SA’s favourite Italian-inspired restaurant’s delicious, piping hot.",
                              Price = 37.70M,
                              ImageUrl = "https://cdn.shopify.com/s/files/1/0360/2179/7001/products/large-margherita-pizza-base-frozen-19836722938011_1024x1024@2x.jpg?v=1615825004",
                              DateCreated = DateTime.Today,
                              DateModified = DateTime.Now
                          },
                           new Product
                          {
                              Title = "Pasta Factory | Margarita Pizza",
                              Description = "A classic favourite of homemade tomato sauce and lots of mozzarella.Our pizza range is hand-made with flavours for every taste.",
                              Price = 73.99M,
                              ImageUrl = "https://cdn.shopify.com/s/files/1/0411/5939/3439/products/PizzaMagherita-2_1024x1024@2x.jpg?v=1598264240",
                              DateCreated = DateTime.Today,
                              DateModified = DateTime.Now
                          },
                           new Product
                          {
                              Title = "Large Plain Pizza Bases",
                              Description = "Large Plain Pizza Bases (2 in a pack) (Frozen). Plain pizza bases with a delicious tomato sauce ready for you to make your own. Don't forget all the toppings around the rest of our site!",
                              Price = 78.70M,
                              ImageUrl = "https://cdn.shopify.com/s/files/1/0360/2179/7001/products/large-plain-pizza-bases-2-in-a-pack-frozen-19836688924827_1024x1024@2x.jpg?v=1615825003",
                              DateCreated = DateTime.Today,
                              DateModified = DateTime.Now
                          },
                           new Product
                          {
                              Title = "Earthfire Pizza Oven",
                              Description = "Making authentic wood-fired pizzas at home just got a whole lot easier. If you are without a pizza igloo in your back garden, an answer is here in the form of the ceramic Earthfire pizza oven.",
                              Price = 4229.70M,
                              ImageUrl = "https://res.cloudinary.com/yuppiechef/image/upload/c_lpad,f_auto,h_556,q_auto,w_556/v1/contentdocs/4060/otherpicture36421203135454",
                              DateCreated = DateTime.Today,
                              DateModified = DateTime.Now
                          },
                           new Product
                          {
                              Title = "Buyfresh Fresh Butternut Girasoli",
                              Description = "Buyfresh Fresh Butternut Girasoli. Made with free range eggs. Enjoy our fresh pasta range with your favourite sauce. Italian inspired, made locally.",
                              Price = 8.70M,
                              ImageUrl = "https://www.italiandelionline.co.za/collections/pasta-flour/products/sgambaro-bio-farro-monococco-penne-rigate-500g",
                              DateCreated = DateTime.Today,
                              DateModified = DateTime.Now
                          },
                           new Product
                          {
                              Title = "Alce Nero | Organic Penne 500G",
                              Description = "Alce Nero organic whole penne rigate is made using only whole semolina from organic durum wheat, which comes from milling the whole grain and which has undergone no refinement and features no additives.",
                              Price = 48.07M,
                              ImageUrl = "https://www.italiandelionline.co.za/collections/pasta-flour/products/alce-nero-organic-penne-500g",
                              DateCreated = DateTime.Today,
                              DateModified = DateTime.Now
                          },
                           new Product
                          {
                              Title = "San Pellegrino | Acqua Tonica 330ML",
                              Description = "Fresh and delicate, noted with a sparkling effervescence that feels crisp and light on the palate.It is characterised by its bitter-sweet taste with oak wood essence that adds a level of complexity unfound in other tonics.",
                              Price = 66.54M,
                              ImageUrl = "https://cdn.shopify.com/s/files/1/0411/5939/3439/products/SanPellegrino_AcquaTonica_1024x1024@2x.png?v=1598892184",
                              DateCreated = DateTime.Today,
                              DateModified = DateTime.Now
                          }
                      };

                        context.Products.AddRange(products);
                        await context.SaveChangesAsync();
                  }

                  if (!context.Staffs.Any())
                  {
                        var staff = new List<Staff>()
                        {
                              new Staff
                              {
                                FirstName = "Kade",
                                LastName = "Walker",
                                AddressType = "Residential",
                                StreetAddress = "290 Langley St",
                                Suburb = "Uniondale",
                                City = "Johannesburg",
                                PostalCode = "2000",
                                DateCreated = DateTime.Today,
                                DateModified = DateTime.Now
                              },
                               new Staff
                              {
                                FirstName = "Jeffreys",
                                LastName = "Masaraure",
                                AddressType = "Business",
                                StreetAddress = "59 Woodlands Ave",
                                Suburb = "Hurlingham",
                                City = "Sandton",
                                PostalCode = "0051",
                                DateCreated = DateTime.Today,
                                DateModified = DateTime.Now
                              }
                        };

                        context.Staffs.AddRange(staff);
                        await context.SaveChangesAsync();
                  }
            }
      }
}