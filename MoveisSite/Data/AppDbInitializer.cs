using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MoveisSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveisSite.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if(!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "20th century fox",
                            Logo = @"D:\Project\CSharp\MoveisSite\MoveisSite\wwwroot\Image\Cinema\20th century fox.jpg",
                            Description = "20th Century Studios, Inc., also known as 20th Century for short, is an American " +
                                          "film production studio headquartered at the Fox Studio Lot in the Century City area of Los Angeles."
                        },

                        new Cinema()
                        {
                            Name = "Universal",
                            Logo = @"D:\Project\CSharp\MoveisSite\MoveisSite\wwwroot\Image\Cinema\Universal.png",
                            Description = "Universal Pictures is an American film production and distribution company owned " +
                                          "by Comcast through the NBCUniversal Film and Entertainment division of ..."
                        },
                            new Cinema()
                        {
                            Name = "Warner Brosers",
                            Logo = @"D:\Project\CSharp\MoveisSite\MoveisSite\wwwroot\Image\Cinema\Warner Brosers.jpg",
                            Description = "Warner Bros. Entertainment Inc is an American film and entertainment company " +
                                          "headquartered at the Warner Bros. Studios complex in Burbank, California, ..."
                        },

                        new Cinema()
                        {
                            Name = "Disney",
                            Logo = @"D:\Project\CSharp\MoveisSite\MoveisSite\wwwroot\Image\Cinema\Disney.jpg",
                            Description = "The best Disney movies of all time are guarantee tons of family fun! ..." +
                                          " Oh Toy Story, the film that stole the hearts of millennials ..."
                        }
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Arnold Shwarsneger",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = @"D:\Project\CSharp\MoveisSite\MoveisSite\wwwroot\Image\Actor\Arnold Shwarsneger.jpg"
                        },

                        new Actor()
                        {
                            FullName = "Al Dillon",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = @"D:\Project\CSharp\MoveisSite\MoveisSite\wwwroot\Image\Actor\Al Dillon.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Alegov Sobul",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = @"D:\Project\CSharp\MoveisSite\MoveisSite\wwwroot\Image\Actor\Alegov Sobul.jpg"
                        },

                        new Actor()
                        {
                            FullName = "Boyd Holbrook",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = @"D:\Project\CSharp\MoveisSite\MoveisSite\wwwroot\Image\Actor\Boyd Holbrook.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Danny Glover",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = @"D:\Project\CSharp\MoveisSite\MoveisSite\wwwroot\Image\Actor\Danny Glover.jpg"
                        },

                        new Actor()
                        {
                            FullName = "Jujutsu Kaisen",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = @"D:\Project\CSharp\MoveisSite\MoveisSite\wwwroot\Image\Actor\Jujutsu Kaisen.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Michael Key",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = @"D:\Project\CSharp\MoveisSite\MoveisSite\wwwroot\Image\Actor\Michael Key.jpg"
                        },

                        new Actor()
                        {
                            FullName = "Nimrod Antal",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = @"D:\Project\CSharp\MoveisSite\MoveisSite\wwwroot\Image\Actor\Nimrod Antal.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Salmon Signed",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = @"D:\Project\CSharp\MoveisSite\MoveisSite\wwwroot\Image\Actor\Salmon Signed.jpg"
                        },

                        new Actor()
                        {
                            FullName = "Shane Black",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = @"D:\Project\CSharp\MoveisSite\MoveisSite\wwwroot\Image\Actor\Shane Black.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Stephen Hopkins",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = @"D:\Project\CSharp\MoveisSite\MoveisSite\wwwroot\Image\Actor\Stephen Hopkins.jpg"
                        },

                        new Actor()
                        {
                            FullName = "Tomy King",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = @"D:\Project\CSharp\MoveisSite\MoveisSite\wwwroot\Image\Actor\Tomy King.jpg"
                        }

                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Elizabeth Avellan",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = @"D:\Project\CSharp\MoveisSite\MoveisSite\wwwroot\Image\Producer\Elizabeth Avellan.jpg"
                        },

                        new Producer()
                        {
                            FullName = "Joel Silver",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = @"D:\Project\CSharp\MoveisSite\MoveisSite\wwwroot\Image\Producer\Joel Silver.jpg"
                        },
                        
                        new Producer()
                        {
                            FullName = "John Davis",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = @"D:\Project\CSharp\MoveisSite\MoveisSite\wwwroot\Image\Producer\John Davis.jpg"
                        },

                        new Producer()
                        {
                            FullName = "Lawrnce Gordon",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = @"D:\Project\CSharp\MoveisSite\MoveisSite\wwwroot\Image\Producer\Lawrnce Gordon.jpg"
                        },

                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Predator",
                            Country = "USA",
                            Year = "1987",
                            Description = "Dutch and his team are out on a mission to rescue a group of hostages in Central America. There, they discover that they are being targeted by an extraterrestrial warrior.",
                            Price = 32.32,
                            ImageURL = @"D:\Project\CSharp\MoveisSite\MoveisSite\wwwroot\Image\Movie\Predator.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            MovieCategory = MovieCategory.Horror,
                            CinemaId = 1,
                            ProducerId = 1

                         },

                        new Movie()
                        {
                            Name = "Predator 2",
                            Country = "USA",
                            Year = "1990",
                            Description = "Lieutenant Mike Harrigan and his police force try to hunt down a vicious alien hunter killing drug gangs in Los Angeles despite the warnings of a mysterious government agent.",
                            Price = 45.32,
                            ImageURL = @"D:\Project\CSharp\MoveisSite\MoveisSite\wwwroot\Image\Movie\Predator 2.jpg",
                            StartDate = DateTime.Now.AddDays(2),
                            EndDate = DateTime.Now.AddDays(40),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Horror

                         },

                        new Movie()
                        {
                            Name = "Predator 3",
                            Country = "USA",
                            Year = "2010",
                            Description = "A mixed bag of mercenaries and militia people find themselves on an alien planet that acts as a game preserve where they are being hunted. They must join forces to combat a merciless race of aliens.",
                            Price = 68.10,
                            ImageURL = @"D:\Project\CSharp\MoveisSite\MoveisSite\wwwroot\Image\Movie\Predator 3.jpg",
                            StartDate = DateTime.Now.AddDays(1),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 2,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Horror

                        },

                        new Movie()
                        {
                            Name = "Predator 4",
                            Country = "USA",
                            Year = "1987",
                            Description = "Quinn McKenna, an army sniper, along with some fugitives and a scientist, sets out to kill the Predator and save Rory, his son, who was abducted as his autism reflects advancement in human evolution.",
                            Price = 38.32,
                            ImageURL = @"D:\Project\CSharp\MoveisSite\MoveisSite\wwwroot\Image\Movie\Predator 4.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(50),
                            CinemaId = 3,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Horror

                        },

                        new Movie()
                        {
                            Name = "AVP",
                            Country = "USA",
                            Year = "1987",
                            Description = "A team of archaeologists investigate a suspicious spot in Antarctica and discover an alien species. Their life is further endangered when they are caught between and hunted by aliens and predators.",
                            Price = 45.32,
                            ImageURL = @"D:\Project\CSharp\MoveisSite\MoveisSite\wwwroot\Image\Movie\AVP.jpg",
                            StartDate = DateTime.Now.AddDays(4),
                            EndDate = DateTime.Now.AddDays(11),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Horror

                        },
                        new Movie()
                        {
                            Name = "AVP 2",
                            Country = "USA",
                            Year = "1987",
                            Description = "A spacecraft brings a lethal alien to Earth, followed by another predator who aims to kill the former. Meanwhile, a bunch of survivors too split into two rivalling groups in a bid to save themselves.",
                            Price = 87.65,
                            ImageURL = @"D:\Project\CSharp\MoveisSite\MoveisSite\wwwroot\Image\Movie\AVP 2.jpg",
                            StartDate = DateTime.Now.AddDays(7),
                            EndDate = DateTime.Now.AddDays(45),
                            CinemaId = 2,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Horror

                         }

                    });
                    context.SaveChanges();
                }
                //Actors &  Movies
                if (!context.Actor_Movies.Any())
                {
                    context.Actor_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },

                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },

                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 1
                        },

                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 1
                        },

                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
