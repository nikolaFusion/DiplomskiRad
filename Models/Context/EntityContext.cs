
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Models.Context
{
    public class EntityContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<Arrangement> Arrangements { get; set; }
        public DbSet<TravelPlace> TravelPlaces { get; set; }
        public DbSet<TravelCompany> TravelCompanies { get; set; }
        public DbSet<ArrangementGroup> ArrangementGroups { get; set; }

        public DbSet<UserArrangementGroup> UserArrangementGroups { get; set; }

        public EntityContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ConfigureRelationships(modelBuilder);

            InsertDataInTable(modelBuilder);
        }

        public static void ConfigureRelationships(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>()
                .HasKey(x => x.RoleID);

            modelBuilder.Entity<Role>()
             .HasMany(x => x.UserRoles)
             .WithOne(x => x.Role);

            modelBuilder.Entity<Role>()
             .HasMany(x => x.RolePermissions)
             .WithOne(x => x.Role);


            modelBuilder.Entity<User>()
                .HasKey(x => x.UserID);

            modelBuilder.Entity<User>()
                .HasMany(x => x.UserRoles)
                .WithOne(x => x.User);


            modelBuilder.Entity<Permission>()
                .HasKey(x => x.PermissionID);

            modelBuilder.Entity<Permission>()
             .HasMany(x => x.RolePermissions)
             .WithOne(x => x.Permission);


            modelBuilder.Entity<RolePermission>()
                .HasKey(x => new { x.RoleID, x.PermissionID });

            modelBuilder.Entity<UserRole>()
                .HasKey(x => new { x.UserID, x.RoleID });

            modelBuilder.Entity<TravelCompany>()
                .HasKey(x => x.TravelCompanyID);

            modelBuilder.Entity<TravelPlace>()
                .HasKey(x => x.TravelPlaceID);

            modelBuilder.Entity<Arrangement>()
                .HasKey(x =>new { x.ArrangementID,x.TravelCompanyID,x.TravelPlaceID });

            modelBuilder.Entity<TravelCompany>()
             .HasMany(x => x.Arrangements)
             .WithOne(x => x.TravelCompany);

            modelBuilder.Entity<TravelPlace>()
             .HasMany(x => x.Arrangements)
             .WithOne(x => x.TravelPlace);

            modelBuilder.Entity<UserArrangementGroup>()
                .HasKey(x => new { x.UserID, x.ArrangementGroupID });

            modelBuilder.Entity<User>()
             .HasMany(x => x.UserArrangements)
             .WithOne(x => x.User);

            modelBuilder.Entity<ArrangementGroup>()
             .HasKey(x => x.ArrangementGroupID);

            modelBuilder.Entity<ArrangementGroup>()
                .HasMany(x => x.UserArrangementGroups)
                .WithOne(x => x.ArrangementGroup);

            modelBuilder.Entity<Arrangement>()
                .HasMany(x => x.ArrangementsGroup)
                .WithMany(x => x.Arrangements);


        }

        public static void InsertDataInTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User { UserID = 1, FirstName = "Nikola", LastName = "Golubovic", Age = 23, Username="nikola", Password="nikola" },
                                                new User { UserID = 2, FirstName = "Nenad", LastName = "Golubovic", Age = 23, Username="nenad", Password="nenad" });

            modelBuilder.Entity<Role>().HasData(new Role { RoleID = 1, Name = "Administrator" },
                                                new Role { RoleID = 2, Name = "User" });

            modelBuilder.Entity<Permission>().HasData(new Permission { PermissionID = 1, NamePermission = "Delete user" },
                                                      new Permission { PermissionID = 2, NamePermission = "Insert user" },
                                                      new Permission { PermissionID = 3, NamePermission = "Access basic data" },
                                                      new Permission { PermissionID = 4, NamePermission = "Access advences data" });

            modelBuilder.Entity<RolePermission>().HasData(new RolePermission { PermissionID = 1, RoleID = 1 },
                                                          new RolePermission { PermissionID = 2, RoleID = 1 },
                                                          new RolePermission { PermissionID = 3, RoleID = 1 },
                                                          new RolePermission { PermissionID = 4, RoleID = 1 },
                                                          new RolePermission { PermissionID = 3, RoleID = 2 });

            modelBuilder.Entity<UserRole>().HasData(new UserRole { UserID = 1, RoleID = 1 },
                                                    new UserRole { UserID = 2, RoleID = 1 });

            modelBuilder.Entity<TravelCompany>().HasData(new TravelCompany { TravelCompanyID = 1, Name = "Expedia Group", ImageUrl = "https://i.pinimg.com/originals/36/60/eb/3660eb409de95cf3b7845fbd529672d5.jpg" },
                                                         new TravelCompany { TravelCompanyID = 2, Name = "American Express Global Business Travel", ImageUrl = "https://www.breakingtravelnews.com/images/sized/images/uploads/association/American_Express_Global_Business_travel-410x250.png" },
                                                         new TravelCompany { TravelCompanyID = 3, Name = "BCD Travel", ImageUrl = "https://www.logolynx.com/images/logolynx/45/45e2d21832a6c5bd9b8535500eb6f988.jpeg" },
                                                         new TravelCompany { TravelCompanyID = 4, Name = "CWT", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRGFY6ACLcnZRRQHxCfeAoarnhQ2WFYNGIjYwj1--ROVHv8KSC3rh0BBn7LJM4mzy8gT_w&usqp=CAU" },
                                                         new TravelCompany { TravelCompanyID = 5, Name = "Flight Centre Travel Group", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/c9/Flight_Centre_Canada_Logo.png" },
                                                         new TravelCompany { TravelCompanyID = 6, Name = "Travel Leaders Group", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRpPcnJXpBYR9oWJNGY8Y61X4dMaHZbuPZ8ab8GOeTTjCDsXX9afgWFFrhSzqm9707ati8&usqp=CAU" },
                                                         new TravelCompany { TravelCompanyID = 7, Name = "American Express", ImageUrl = "https://cdn.travelpulse.com/images/bd2ed357-9adc-bb59-4f8f-1e08b5932b51/0b77cb8d-aa17-4bd4-b861-bebe0b369269/500x309.jpg" });

            modelBuilder.Entity<TravelPlace>().HasData(new TravelPlace { TravelPlaceID = 1, Name = "Kopaonik - Skiing", Country = "Serbia",ImageUrl= "https://www.infokop.net/mambots/content/multithumb/images/b.800.600.0.1.stories.vesti.2019.zima.ski-opening-2018.jpg", Description= "Welcome to Kopaonik - a tourist destination that provides the best vacations. Here you will find everything you need to organize your stay on the mountain. Kopaonik has a lot to offer, so you need a reliable guide through its offer. Find quality accommodation units, choose restaurants with the most varied menu, discover which are the most attractive mountain facilities. Choose the options that best fit the image of your ideal vacation. Prepare to travel in the best way and provide yourself and your companions with the perfect mountain experience." },
                                                       new TravelPlace { TravelPlaceID = 2, Name = "Paris - Museum", Country = "France", ImageUrl = "https://www.ceeh.es/wp-content/uploads/2021/06/b.jpg", Description = "There are over 150 museums in Paris, including some of the most-visited in the world. As a visitor, the real challenge is choosing the right museums for you, the ones that match your interests, needs, and time. Right now we're going to concentrate on the biggest and the best. Paris is very popular, and so are its museums. You likely will encounter long ticket line-ups at the top museums. If you know us, you'll know we hate standing in lines. So, we appreciate the benefits of the Paris Insiders Pass — a worthwhile tool both to save money and to skip the long lines." },
                                                       new TravelPlace { TravelPlaceID = 3, Name = "Iceland - Country of ice and fire", Country = "Iceland", ImageUrl = "https://www.telegraph.co.uk/content/dam/Travel/Destinations/Europe/Iceland/Reykjavik/reykjavik-guide-lead-image-48-hours-xlarge.jpg?imwidth=640", Description = "Iceland's nature is easily the highlight of the entire country. The island features glittering glacier lagoons, bubbling hot springs, and powerful waterfalls – illuminated each season by either the Northern Lights or the Midnight Sun. With its countless natural wonders, it's easy to see why Iceland has become one of the top travel destinations in the world. Below we have listed some of our favorite must-see destinations and must-do experiences that should be on every visitor's bucket list!" },
                                                       new TravelPlace { TravelPlaceID = 4, Name = "Canada - Nature", Country = "Canada", ImageUrl = "https://cdn.ceoworld.biz/wp-content/uploads/2022/04/Benefits-of-Holding-a-Canadia-Passport.jpg", Description = "The beauty of Canada from east to west is amazing and wonderfully scenic. Although the world is slowly going back to normal, there are however still some flight travels being restricted due to the COVID-19 pandemic. Don’t worry, there is always a good time for some of the best road trips in Canada. If you already live in Canada, you know that the country is worth exploring and full of fantastic nature destinations that attract millions of tourists and adventurers from all around the world. If you're coming from outside the country, then you want to make sure to get an international driver's license for Canada so that you can drive from coast to coast and visit every destination on your way. Now let’s check out some of the top nature travel destinations you must visit in Canada!" },
                                                       new TravelPlace { TravelPlaceID = 5, Name = "Norway - aurora borealis", Country = "Norway", ImageUrl = "https://cdn.kimkim.com/files/a/content_articles/featured_photos/9e76018b4dbc115cd4f8a51f0a49a9948a28cb74/big-2d3b3fc973f25a6a9252308e46b35546.jpg", Description = "Between late September and late March, Northern Norway is dark from early afternoon until late morning, and the northern lights frequently soar across the sky. Our bold claim is that this part of Norway, with its multiple islands, deep fjords and steep mountains, is among the most beautiful and interesting places to see the northern lights.As hundreds of thousands of people live in this huge geographical area, the region of Northern Norway has everything from cities with a lively night scene and great museums to small fishing villages and vast, tranquil spaces without light pollution.This means that in addition to hunting for the northern lights, you can go winter fishing, hiking, skiing, and dog sledding, experience the Sami culture, or join a whale or wildlife safari. Afterwards, you can relax in top-notch hotels and eat incredible local food. Or maybe you’ve joined a northern lights safari and get to eat your meal in a traditional lavvo?" },
                                                       new TravelPlace { TravelPlaceID = 6, Name = "India Jungles", Country = "India", ImageUrl = "https://i.pinimg.com/736x/c2/b8/85/c2b88548dd9f646948c27caa3131ea6e.jpg", Description = "India’s natural beauty can rival that of any other country in the world. But while the country’s beaches and mountains are already thoroughly explored, its jungles have come into sharp focus in recent years. With terms such as jungle trekking and forest bathing becoming tourism buzzwords, India’s jungles, national parks and forest reserves are now drawing more visitors than ever. So if jungle trekking is on your mind, here are some of the best places that deserve your attention." },
                                                       new TravelPlace { TravelPlaceID = 7, Name = "Australia Jungles", Country = "Australia", ImageUrl = "https://travel.mqcdn.com/mapquest/travel/wp-content/uploads/2020/06/GettyImages-676934538-e1592461667985-835x480.jpg", Description = "From the 180-million-year-old Daintree Rainforest in the north of Queensland to the cool, misty temperate rainforests of Tasmania, Australia’s rainforests can be found right across the country. Encompassing UNESCO World Heritage areas and hundreds of national parks and reserves, these rainforests are home to an extraordinary variety of plants and animals, and are packed with spectacular waterfalls, idyllic swimming holes, breathtaking hiking trails, and much more. They might be wild, but exploring them is easy." },
                                                       new TravelPlace { TravelPlaceID = 8, Name = "Central Ausralia", Country = "Australia", ImageUrl = "https://www.traveller.com.au/content/dam/images/1/0/7/5/k/n/image.related.articleLeadwide.620x349.zsbg7.png/1425452937659.jpg", Description = "Central Australia lies not only in the heart of Australia; it lies in the hearts of Australians. This region holds not only one of the most culturally significant icons of Aboriginal and Australian culture, Uluru/Ayers Rock; it holds onto the true Outback spirit that made this country great. Whether youre a born-and-bred Australian or visitor from abroad, touring The Centre gives you an appreciation of the vast and unspoiled wonders of Australias interior. Nature overwhelms you in The Centre. The skyscrapers are made out of rock, not steel, and one of the best shows in town is the million-star display at night. The large population of unique animals, birds and reptiles proves that this arid climate is more than hospitable. Wallabies, dingoes, emus, tiny geckos and huge eagles are just some of the long-established locals youll see around The Centre, as well as camels, well-adjusted immigrants to the region." },
                                                       new TravelPlace { TravelPlaceID = 9, Name = "Cape of good hope", Country = "South Africa", ImageUrl = "https://media.cntraveler.com/photos/5b742b0cde8e29470d34f562/16:9/w_2560,c_limit/Cape-of-Good-Hope_GettyImages-962634118.jpg", Description = "The Cape of Good Hope Nature Reserve forms part of the Cape Peninsula Park and is managed by the South African National Parks. The Nature Reserve is recognized globally for its extraordinary land formation, rich and diverse fauna and unique flora. Nowhere else in the world does an area of such spectacular beauty and such rich biodiversity exist almost within a metropolitan area - the thriving and cosmopolitan City of Cape Town." },
                                                       new TravelPlace { TravelPlaceID = 10, Name = "Rabat-Cultures of ancient times", Country = "Morocco", ImageUrl = "https://eeradicalization.com/wp-content/uploads/2020/03/ccimage-shutterstock_1075717346.jpg", Description = "Want to discover Rabat? There are a thousand and one ways to do so. A coastal city, its shoreline stretches along nearly 60 kilometres of land with a succession of rocky creeks and fine sandy beaches and its hinterland offers an ecological diversity ideal for hiking.Rabat is the administrative capital of Morocco, it is located on the Atlantic coast and on the left or south bank of the mouth of the Bouregreg, opposite the town of Salé. These two cities are for this reason referred to as twin cities." },
                                                       new TravelPlace { TravelPlaceID = 11, Name = "Rio De Janeiro statue", Country = "Brazil", ImageUrl = "http://thehumanist.com/wp-content/uploads/2015/03/statue.jpg", Description = "Rio de Janeiro is a bustling and modern beachfront city, with something for tourists to see and do on and off the sand 12 months out of the year. Weather wise, December through March (Brazil's summer months) and September through November (spring in Brazil) means temperatures in the 70s to 90s and little rain. With Carnival comes crowds in February or March, but that's half the fun. It's no surprise New Year's Eve is another epically popular time to party in Rio." },
                                                       new TravelPlace { TravelPlaceID = 12, Name = "Cairo piramides", Country = "Egypt", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSLN31eVZKvcBDST2b-ehzDBBqI2X38aN_bRQTIRnY_dOVw7_ycyKLxTCBLywFRnJ4VzTs&usqp=CAU", Description = "Giza's Great Pyramid (also called the Pyramid of Cheops) is not only this ancient site's most famous monument but one of the most well-known monuments in the world.It was built by the Pharaoh Khufu (commonly called by its Greek transliteration of Cheops) and was known to the ancient Egyptians as Ekhet Khufu (Horizon of Khufu).According to Herodotus,10 000 men worked on its construction for three months every year.This mammoth structure's cubic content is staggering. Excluding the rock foundation and the interior chambers, the Great Pyramid is 2.3 million cubic meters. The base measurement is 227.5 meters, and the vertical height is 137.2 meters." },
                                                       new TravelPlace { TravelPlaceID = 13, Name = "Beijing culture", Country = "China", ImageUrl = "http://chinaflowers.net/blog/wp-content/uploads/2011/11/beijing_1.jpg", Description = "No one should skip Beijing even if only visiting one city/region in China. Beijing is a window into the authentic core of China, especially recommended for China first timers. As one of the world's great ancient capitals, and the capital of the world's upcoming superpower, Beijing is the most important and interesting city in China to travel, both for tourism and understanding China." },
                                                       new TravelPlace { TravelPlaceID = 14, Name = "Beauty of Bankok", Country = "Thailand", ImageUrl = "https://www.planetware.com/wpimages/2019/08/thailand-in-pictures-most-beautiful-places-bangkok-riverfront.jpg", Description = "For major tourist attractions in Bangkok, most of them are Historical sites or religious sites such as temples in Bangkok. There is beautiful architecture, wall painting and also important in History, such as Wat Phra Sri Rattanasamaram (Phra Kaew), Wat Phra Chetuphon Wimon Mangalaram (wat pho), wat arun Ratchawararam, Wat Sra Ket, and Phra Bor Banphot (Golden mountain), Wat Ratchanadda, Wat Traimit, Wat Benchamabophit, Wat Bowonniwet Vihara Suthasan, Wat Thep Wararam etc. " },
                                                       new TravelPlace { TravelPlaceID = 15, Name = "Safari South Africa", Country = "South Africa", ImageUrl = "https://ssl.tzoo-img.com/images/blog/2019/2/8/ssimg_210.jpg?width=412&spr=3", Description = "Few destinations rival South Africa when it comes to offering a wide range of attractions combined with easy and convenient regional travel. Home to the Big 5 and breath-taking natural beauty, a South Africa safari experience is ideal for families, honeymooners and adventure seekers of all ages. Game reserves are teeming with lion, elephant, buffalo, rhino, rare cheetah, and all the plains game favourites like zebra, giraffe and gazelle. For the ultimate Big 5 safari in South Africa, nothing beats the Kruger National Park – widely considered the best place in Africa to see leopard, the most elusive of all big cats. Accommodation options range from 5-star to star-lit, and include family lodges, honeymoon hideaways, and grand tented camps." },
                                                       new TravelPlace { TravelPlaceID = 16, Name = "Safari Botswana", Country = "Botswana", ImageUrl = "https://www.andbeyond.com/wp-content/uploads/sites/5/Herd-of-Elephants-walking-while-guests-cross-channel-on-a-Safari-Game-Drive-in-Botswana.jpg", Description = "Discover the wildlife roaming through one of Africa’s last great wildernesses on a Botswana safari. Desert, marshlands, rivers and the enormous Okavango Delta make this one of the world’s best places for game drives, bush walks and dugout canoe trips, with an array of animals to spot, including the Big Five. Time spent with local guides and bushmen adds to the experience, while low visitor numbers ensure Botswana safaris deliver sensational sights without the crowds." },
                                                       new TravelPlace { TravelPlaceID = 17, Name = "Cote d'Azur", Country = "France", ImageUrl = "https://static.tildacdn.com/tild6333-3963-4232-b139-343838313334/ote-d-azur-cruise-tr.jpeg", Description = "Your chosen destination will depend on your preferences: beaches, towns, access to villages, lively resorts with all facilities, quiet coastal footpaths...most visitors will not expect to explore the entire Cote d'Azur in one trip or have the same requirements from a holiday. Below we guide you to the part of the Cote d'Azur most suitable for your needs, and you can then use the map and the reviews of individual places in the same area to help you decide where to go.If you have no idea where to start exploring, the most visited section of the coast with such famous resorts as Nice, Antibes, Saint-Tropez and Cannes as well as impressive hill villages and areas of great natural beauty is around Nice. Stay on the seafront in Nice and use the train to explore nearby towns and resorts and you will certainly have a good introduction to the Cote d'Azur: see riviera train." },
                                                       new TravelPlace { TravelPlaceID = 18, Name = "Corida Spain", Country = "Spain", ImageUrl = "https://m.psecn.photoshelter.com/img-get/I0000KM3Tgz.EL9c/s/900/600/bullfighting-corrida-spain-40.jpg", Description = "Quite simply, bullfighting is a fight between a bull and a human. This person is known as a bullfighter or a matador. They are attempting to immobilise, subdue or indeed kill the bull – and there are usually rules and regulations for the fighting as well as various cultural expectations. Bullfighting in Spain is, typically, known as Spanish-style bullfighting. This style is practiced outside of the country, in places like Portugal, Mexico, Colombia, Peru, the south of France and more." },
                                                       new TravelPlace { TravelPlaceID = 19, Name = "Terakota warriors", Country = "China", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRg9Bh1GEsvpvMoAKQZMtxLI8v16ormJMHb8z6usd-oj0PPXq5BLCZkKq2qT_YTavgNfd4&usqp=CAU", Description = "‘We’ve broken a Buddha,’ cried the farmers who stumbled across a pottery torso and head as they were digging a well near Xian, northern China. The year was 1974, and little did they know what they’d unearthed: a life-size army of 8,000 warriors and horses built to accompany China’s first emperor, Qin Shi Huang, in the afterlife. To date, only a fraction have been unearthed." },
                                                       new TravelPlace { TravelPlaceID = 20, Name = "Australia coalas", Country = "Australia", ImageUrl = "https://media.istockphoto.com/photos/little-girl-hugs-koala-picture-id626145812?k=20&m=626145812&s=612x612&w=0&h=X11Nn3LhtqlVj_fU0YvnWY_NrcrKF--P34k_nZNHzZA=", Description = "The cute and cuddly koala is one of Australia's most well-known (and well-loved) animals. You may know them for their fuzzy ears and large noses, but there's much more to these sleepy marsupials." },
                                                       new TravelPlace { TravelPlaceID = 21, Name = "Belgrade", Country = "Serbia", ImageUrl = "https://images.squarespace-cdn.com/content/v1/59dab4fd8fd4d21d6a6219b3/1508457059277-DQ6HIDC9VDJCVAY7NR4A/belgrade-serbia.jpg?format=2500w", Description = "While Belgrade’s rich history makes itself reminded throughout the city, most notably in the old Belgrade Fortress, Belgrade features an abundance of cultural attractions and a wide range of events that draw visitors from across Europe.As one of Europe’s oldest cities, located at the crossroads of the East and West, the capital of Serbia is an incredibly rich mosaic of different cultures, influences and styles with a mysterious and exotic atmosphere.European but with oriental influences, Belgrade is a great weekend break, with tons of interesting sights and attractions, splendid architecture, a fast-paced nightlife, great and affordable shopping, as well as a thriving cultural scene." });


            modelBuilder.Entity<Arrangement>().HasData(new Arrangement { ArrangementID = 1, TravelCompanyID = 2, TravelPlaceID = 4, DateStart = new DateTime(2022, 9, 19, 12, 0, 0), DateEnd = new DateTime(2022, 9, 21, 12, 0, 0), Price = 123.22, SeatsInArrangement = 10, OnlyAirplaneTicket = false },
                                                       new Arrangement { ArrangementID = 2, TravelCompanyID = 5, TravelPlaceID = 3, DateStart = new DateTime(2022, 9, 21, 17, 0, 0), DateEnd = new DateTime(2022, 9, 24, 12, 0, 0), Price = 117.99, SeatsInArrangement = 10, OnlyAirplaneTicket = false },
                                                       new Arrangement { ArrangementID = 3, TravelCompanyID = 1, TravelPlaceID = 5, DateStart = new DateTime(2022, 9, 24, 17, 0, 0), DateEnd = new DateTime(2022, 9, 27, 12, 0, 0), Price = 126.12, SeatsInArrangement = 10, OnlyAirplaneTicket = false },
                                                       new Arrangement { ArrangementID = 4, TravelCompanyID = 6, TravelPlaceID = 21, DateStart = new DateTime(2022, 9, 27, 12, 0, 0), DateEnd = null, Price = 72.32, SeatsInArrangement = 10, OnlyAirplaneTicket = true }) ;

            modelBuilder.Entity<Arrangement>().HasData(new Arrangement { ArrangementID = 5, TravelCompanyID = 3, TravelPlaceID = 4, DateStart = new DateTime(2022, 9, 19, 12, 0, 0), DateEnd = new DateTime(2022, 9, 21, 12, 0, 0), Price = 223.22, SeatsInArrangement = 10, OnlyAirplaneTicket = false },
                                                      new Arrangement { ArrangementID = 6, TravelCompanyID = 2, TravelPlaceID = 3, DateStart = new DateTime(2022, 9, 21, 17, 0, 0), DateEnd = new DateTime(2022, 9, 24, 12, 0, 0), Price = 217.99, SeatsInArrangement = 10, OnlyAirplaneTicket = false },
                                                      new Arrangement { ArrangementID = 7, TravelCompanyID = 4, TravelPlaceID = 5, DateStart = new DateTime(2022, 9, 24, 17, 0, 0), DateEnd = new DateTime(2022, 9, 27, 12, 0, 0), Price = 226.12, SeatsInArrangement = 10, OnlyAirplaneTicket = false },
                                                      new Arrangement { ArrangementID = 8, TravelCompanyID = 3, TravelPlaceID = 21, DateStart = new DateTime(2022, 9, 27, 12, 0, 0), DateEnd = null, Price =272.32, SeatsInArrangement = 10, OnlyAirplaneTicket = true });

            modelBuilder.Entity<Arrangement>().HasData(new Arrangement { ArrangementID = 9, TravelCompanyID = 1, TravelPlaceID = 1, DateStart = new DateTime(2022, 9, 19, 12, 0, 0), DateEnd = new DateTime(2022, 9, 21, 12, 0, 0), Price = 1212.12, SeatsInArrangement = 10, OnlyAirplaneTicket = false },
                                                      new Arrangement { ArrangementID = 10, TravelCompanyID = 2, TravelPlaceID = 2, DateStart = new DateTime(2022, 9, 21, 17, 0, 0), DateEnd = new DateTime(2022, 9, 24, 12, 0, 0), Price = 142.51, SeatsInArrangement = 10, OnlyAirplaneTicket = false },
                                                      new Arrangement { ArrangementID = 11, TravelCompanyID = 3, TravelPlaceID = 6, DateStart = new DateTime(2022, 9, 24, 17, 0, 0), DateEnd = new DateTime(2022, 9, 27, 12, 0, 0), Price = 436.32, SeatsInArrangement = 10, OnlyAirplaneTicket = false },
                                                      new Arrangement { ArrangementID = 12, TravelCompanyID = 4, TravelPlaceID = 7, DateStart = new DateTime(2022, 9, 27, 12, 0, 0), DateEnd = null, Price = 45.72, SeatsInArrangement = 10, OnlyAirplaneTicket = true });

            modelBuilder.Entity<Arrangement>().HasData(new Arrangement { ArrangementID = 13, TravelCompanyID = 5, TravelPlaceID = 8, DateStart = new DateTime(2022, 9, 19, 12, 0, 0), DateEnd = new DateTime(2022, 9, 21, 12, 0, 0), Price = 834.34, SeatsInArrangement = 10, OnlyAirplaneTicket = false },
                                                       new Arrangement { ArrangementID = 14, TravelCompanyID = 6, TravelPlaceID = 9, DateStart = new DateTime(2022, 9, 21, 17, 0, 0), DateEnd = new DateTime(2022, 9, 24, 12, 0, 0), Price = 125.34, SeatsInArrangement = 10, OnlyAirplaneTicket = false },
                                                       new Arrangement { ArrangementID = 15, TravelCompanyID = 7, TravelPlaceID = 10, DateStart = new DateTime(2022, 9, 24, 17, 0, 0), DateEnd = new DateTime(2022, 9, 27, 12, 0, 0), Price = 345.23, SeatsInArrangement = 10, OnlyAirplaneTicket = false },
                                                       new Arrangement { ArrangementID = 16, TravelCompanyID = 6, TravelPlaceID = 11, DateStart = new DateTime(2022, 9, 27, 12, 0, 0), DateEnd = null, Price = 373.34, SeatsInArrangement = 10, OnlyAirplaneTicket = true });

            modelBuilder.Entity<Arrangement>().HasData(new Arrangement { ArrangementID = 17, TravelCompanyID = 5, TravelPlaceID = 12, DateStart = new DateTime(2022, 9, 19, 12, 0, 0), DateEnd = new DateTime(2022, 9, 21, 12, 0, 0), Price = 612.24, SeatsInArrangement = 10, OnlyAirplaneTicket = false },
                                                       new Arrangement { ArrangementID = 18, TravelCompanyID = 4, TravelPlaceID = 13, DateStart = new DateTime(2022, 9, 21, 17, 0, 0), DateEnd = new DateTime(2022, 9, 24, 12, 0, 0), Price = 247.99, SeatsInArrangement = 10, OnlyAirplaneTicket = false },
                                                       new Arrangement { ArrangementID = 19, TravelCompanyID = 3, TravelPlaceID = 14, DateStart = new DateTime(2022, 9, 24, 17, 0, 0), DateEnd = new DateTime(2022, 9, 27, 12, 0, 0), Price = 326.12, SeatsInArrangement = 10, OnlyAirplaneTicket = false },
                                                       new Arrangement { ArrangementID = 20, TravelCompanyID = 2, TravelPlaceID = 15, DateStart = new DateTime(2022, 9, 27, 12, 0, 0), DateEnd = null, Price = 261.32, SeatsInArrangement = 10, OnlyAirplaneTicket = true });

            modelBuilder.Entity<Arrangement>().HasData(new Arrangement { ArrangementID = 21, TravelCompanyID = 1, TravelPlaceID = 16, DateStart = new DateTime(2022, 9, 19, 12, 0, 0), DateEnd = new DateTime(2022, 9, 21, 12, 0, 0), Price = 223.22, SeatsInArrangement = 10, OnlyAirplaneTicket = false },
                                                      new Arrangement { ArrangementID = 22, TravelCompanyID = 2, TravelPlaceID = 17, DateStart = new DateTime(2022, 9, 21, 17, 0, 0), DateEnd = new DateTime(2022, 9, 24, 12, 0, 0), Price = 617.99, SeatsInArrangement = 10, OnlyAirplaneTicket = false },
                                                      new Arrangement { ArrangementID = 23, TravelCompanyID = 3, TravelPlaceID = 18, DateStart = new DateTime(2022, 9, 24, 17, 0, 0), DateEnd = new DateTime(2022, 9, 27, 12, 0, 0), Price = 526.12, SeatsInArrangement = 10, OnlyAirplaneTicket = false },
                                                      new Arrangement { ArrangementID = 24, TravelCompanyID = 4, TravelPlaceID = 19, DateStart = new DateTime(2022, 9, 27, 12, 0, 0), DateEnd = null, Price = 213.32, SeatsInArrangement = 10, OnlyAirplaneTicket = true });

            modelBuilder.Entity<Arrangement>().HasData(new Arrangement { ArrangementID = 25, TravelCompanyID = 5, TravelPlaceID = 20, DateStart = new DateTime(2022, 9, 19, 12, 0, 0), DateEnd = new DateTime(2022, 9, 21, 12, 0, 0), Price = 523.22, SeatsInArrangement = 10, OnlyAirplaneTicket = false },
                                                      new Arrangement { ArrangementID = 26, TravelCompanyID = 6, TravelPlaceID = 21, DateStart = new DateTime(2022, 9, 21, 17, 0, 0), DateEnd = new DateTime(2022, 9, 24, 12, 0, 0), Price = 227.99, SeatsInArrangement = 10, OnlyAirplaneTicket = false },
                                                      new Arrangement { ArrangementID = 27, TravelCompanyID = 7, TravelPlaceID = 15, DateStart = new DateTime(2022, 9, 24, 17, 0, 0), DateEnd = new DateTime(2022, 9, 27, 12, 0, 0), Price = 426.12, SeatsInArrangement = 10, OnlyAirplaneTicket = false },
                                                      new Arrangement { ArrangementID = 28, TravelCompanyID = 1, TravelPlaceID = 14, DateStart = new DateTime(2022, 9, 27, 12, 0, 0), DateEnd = null, Price = 672.32, SeatsInArrangement = 10, OnlyAirplaneTicket = true });
            
            modelBuilder.Entity<Arrangement>().HasData(new Arrangement { ArrangementID = 29, TravelCompanyID = 1, TravelPlaceID = 17, DateStart = new DateTime(2022, 9, 19, 12, 0, 0), DateEnd = new DateTime(2022, 9, 21, 12, 0, 0), Price = 213.22, SeatsInArrangement = 10, OnlyAirplaneTicket = false },
                                                     new Arrangement { ArrangementID = 30, TravelCompanyID = 3, TravelPlaceID = 17, DateStart = new DateTime(2022, 9, 21, 17, 0, 0), DateEnd = new DateTime(2022, 9, 24, 12, 0, 0), Price = 237.99, SeatsInArrangement = 10, OnlyAirplaneTicket = false },
                                                     new Arrangement { ArrangementID = 31, TravelCompanyID = 4, TravelPlaceID = 17, DateStart = new DateTime(2022, 9, 24, 17, 0, 0), DateEnd = new DateTime(2022, 9, 27, 12, 0, 0), Price = 426.12, SeatsInArrangement = 10, OnlyAirplaneTicket = false },
                                                     new Arrangement { ArrangementID = 32, TravelCompanyID = 5, TravelPlaceID = 17, DateStart = new DateTime(2022, 9, 27, 12, 0, 0), DateEnd = null, Price = 312.21, SeatsInArrangement = 10, OnlyAirplaneTicket = true });

            modelBuilder.Entity<Arrangement>().HasData(new Arrangement { ArrangementID = 33, TravelCompanyID = 6, TravelPlaceID = 17, DateStart = new DateTime(2022, 9, 19, 12, 0, 0), DateEnd = new DateTime(2022, 9, 21, 12, 0, 0), Price = 243.22, SeatsInArrangement = 10, OnlyAirplaneTicket = false },
                                         new Arrangement { ArrangementID = 34, TravelCompanyID = 7, TravelPlaceID = 17, DateStart = new DateTime(2022, 9, 21, 17, 0, 0), DateEnd = new DateTime(2022, 9, 24, 12, 0, 0), Price = 327.99, SeatsInArrangement = 10, OnlyAirplaneTicket = false });
                                      
        }
    }
}
