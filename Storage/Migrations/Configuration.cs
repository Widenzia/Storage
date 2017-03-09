namespace Storage.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Storage.DataAccessLayer.StorageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Storage.DataAccessLayer.StorageContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Products.AddOrUpdate(
                p => p.Id,
                new Product { Name = "HEMNES Bed frame", Price = 175, Category = "Beds", Shelf = "G22", Count = 14, Description = "Made of solid wood, which is a hardwearing and warm natural material" },
                new Product { Name = "BUSUNGE Extendable bed", Price = 130, Category = "Beds", Shelf = "G14", Count = 10, Description = "It can be pulled out as your child grows" },
                new Product { Name = "BRIMNES Day-bed", Price = 279, Category = "Beds", Shelf = "G20", Count = 10, Description = "Seating, bed for one, bed for two and two big drawers for storage" },
                new Product { Name = "BEKKESTUA Divan bed", Price = 1178, Category = "Beds", Shelf = "G12", Count = 8, Description = "Hesseng medium tromsdalen natural colour" },
                new Product { Name = "SOCKERKAKA Baking mould", Price = 5, Category = "Cookware", Shelf = "D13", Count = 256, Description = "The silicone makes the pastry release easily from the moulds" },
                new Product { Name = "OUMBÄRLIG Saucepan with lid", Price = 8, Category = "Cookware", Shelf = "D15", Count = 22, Description = "Gives an even and energy-efficient heat" },
                new Product { Name = "FRÄJEN Washcloth", Price = 1, Category = "Textiles", Shelf = "C12", Count = 300, Description = "A terry towel in medium thickness" },
                new Product { Name = "RASKMÖLLE Rug, flatwoven", Price = 120, Category = "Textiles", Shelf = "C14", Count = 49, Description = "Handwoven by skilled craftspeople, each one is unique" },
                new Product { Name = "RÖDARV Cushion", Price = 20, Category = "Textiles", Shelf = "C2", Count = 30, Description = "Embroidery adds texture and lustre to the cushion" },
                new Product { Name = "ARHOLMA 2-seat sofa", Price = 295, Category = "Gardening", Shelf = "H10", Count = 5, Description = "You can easily direct the light to different places" },
                new Product { Name = "VITEMÖLLA Triple ceiling spotlight", Price = 40, Category = "Lighting", Shelf = "F12", Count = 66, Description = "You can easily direct the light to different places" },
                new Product { Name = "ALÄNG Floor lamp", Price = 45, Category = "Lighting", Shelf = "F14", Count = 67, Description = "The height is adjustable to suit your lighting needs" },
                new Product { Name = "VARV Clamp spotlight", Price = 29, Category = "Lighting", Shelf = "F28", Count = 10, Description = "Easy to attach to the headboard for reading light" },
                new Product { Name = "ÅRSTID Wall lamp", Price = 16, Category = "Lighting", Shelf = "F30", Count = 200, Description = "Creates a soft, cosy atmosphere in your home" },
                new Product { Name = "SJÄLSLIGT Decoration set of 3", Price = 15, Category = "Decoration", Shelf = "E2", Count = 0, Description = "Cactuses, made from ceramic" },
                new Product { Name = "COMBINERBAR box", Price = 15, Category = "Decoration", Shelf = "E18", Count = 20, Description = "Decoration glass box, set of 2" },
                new Product { Name = "KRABB Mirror", Price = 8, Category = "Decoration", Shelf = "E10", Count = 38, Description = "You can hang the mirrors in many different ways" },
                new Product { Name = "BORRBY Lantern", Price = 7, Category = "Decoration", Shelf = "E10", Count = 0, Description = "Suitable for both indoor and outdoor use" },
                new Product { Name = "DUKTIG Play kitchen", Price = 59, Category = "Toys", Shelf = "B20", Count = 20, Description = "In this complete kitchen they can cook" },
                new Product { Name = "DUKTIG 5-piece toy cookware set", Price = 6, Category = "Toys", Shelf = "B12", Count = 100, Description = "Mini cookware for play" },
                new Product { Name = "HEMMAHOS Soft Toy", Price = 12, Category = "Toys", Shelf = "B11", Count = 50, Description = "This large toothbrush makes it easier to remember to brush your teeth" },
                new Product { Name = "MÅLA Easel", Price = 16, Category = "Toys", Shelf = "B7", Count = 43, Description = "Easel with whiteboard on one side and a blackboard on the other" },
                new Product { Name = "DUKTIG Plate", Price = 6, Category = "Toys", Shelf = "B18", Count = 18, Description = "Mini dinner plates for play" }
                );
        }
    }
}
