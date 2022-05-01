using Clock.Domain.Entities;
using Clock.Infra.EntityConfig;
using Microsoft.EntityFrameworkCore;

namespace Clock.Infra.Context
{
    public class ClockContext : DbContext
    {
        public ClockContext(DbContextOptions<ClockContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Employer> Employer { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<PersonEmployer> PersonEmployer { get; set; }
        public DbSet<Hours> Hours { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Frequency> Frequency { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //PERSON TABLE
            modelBuilder.Entity<Person>().HasOne(p => p.City).WithMany(c => c.People).HasForeignKey(p => p.CityFk).OnDelete(DeleteBehavior.Restrict);
            //EMPLOYER TABLE
            modelBuilder.Entity<Employer>().Property(e => e.IdEmployer).ValueGeneratedOnAdd();
            modelBuilder.Entity<Employer>().HasOne(e => e.City).WithMany(a => a.Employers).HasForeignKey(e => e.CityFk).OnDelete(DeleteBehavior.Restrict);
            //CITY TABLE
            modelBuilder.Entity<City>().HasOne(c => c.State).WithMany(s => s.Cities).HasForeignKey(c => c.StateFk).OnDelete(DeleteBehavior.Restrict);
            //PERSONEMPLOYER TABLE MANY TO MANY
            modelBuilder.Entity<PersonEmployer>().HasOne(pe => pe.Person).WithMany(p => p.PersonEmployer).HasForeignKey(pe => pe.IdPerson);
            modelBuilder.Entity<PersonEmployer>().HasOne(pe => pe.Employer).WithMany(p => p.PersonEmployer).HasForeignKey(pe => pe.IdEmployer);
            //HOURS TABLE
            modelBuilder.Entity<Hours>().HasOne(h => h.Employer).WithMany(e => e.Hours).HasForeignKey(h => h.EmployerFk).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Hours>().HasOne(h => h.Person).WithMany(e => e.Hours).HasForeignKey(h => h.PersonFk).OnDelete(DeleteBehavior.Restrict);
            //CLIENT TABLE
            modelBuilder.Entity<Client>().Property(e => e.IdClient).ValueGeneratedOnAdd();
            modelBuilder.Entity<Client>().HasOne(e => e.City).WithMany(a => a.Clients).HasForeignKey(e => e.CityFk).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Client>().HasOne(e => e.Frequency).WithMany(a => a.Clients).HasForeignKey(e => e.FrequencyFK).OnDelete(DeleteBehavior.Restrict);
            


            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            modelBuilder.ApplyConfiguration(new EmployerConfiguration());
            modelBuilder.ApplyConfiguration(new StateConfiguration());
            modelBuilder.ApplyConfiguration(new CityConfiguration());
            modelBuilder.ApplyConfiguration(new PersonEmployerConfiguration());
            modelBuilder.ApplyConfiguration(new HoursConfiguration());
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new FrequencyConfiguration());

            //SEED DATA
            //STATE
            modelBuilder.Entity<State>().HasData(
                new State(1, "South Australia", "SA"),
                new State(2, "New South Wales", "NSW"),
                new State(3, "Queensland", "QLD"),
                new State(4, "Northern Territory", "NT"),
                new State(5, "Victoria", "VIC"),
                new State(6, "Tasmania", "TAS"),
                new State(7, "Australia Capital Territory", "ACT"),
                new State(8, "Western Australia", "WA"),
                new State(9999, "Not Informed", "N/A")
            );

            //CITY
            modelBuilder.Entity<City>().HasData(
                new City(1, "Adelaide", 1),
                new City(2, "Perth", 8),
                new City(3, "Mandurah", 8),
                new City(4, "Bunbury", 8),
                new City(5, "Geraldton", 8),
                new City(6, "Kalgoorlie-Boulder", 8),
                new City(7, "Sydney", 2),
                new City(8, "Newcastle", 2),
                new City(9, "Wollongong", 2),
                new City(10, "Wagga Wagga", 2),
                new City(11, "Coffs Harbour", 2),
                new City(12, "Tamworth", 2),
                new City(13, "Port Macquarie", 2),
                new City(14, "Orange", 2),
                new City(15, "Dubbo", 2),
                new City(16, "Nowra-Bomaderry", 2),
                new City(17, "Bathurst", 2),
                new City(18, "Lismore", 2),
                new City(19, "Albury-Wodonga", 2),
                new City(20, "Brisbane", 3),
                new City(21, "Sunshine Coast", 3),
                new City(22, "Townsville", 3),
                new City(23, "Cairns", 3),
                new City(24, "Toowoomba", 3),
                new City(25, "Mackay", 3),
                new City(26, "Rockhampton", 3),
                new City(27, "Bundaberg", 3),
                new City(30, "Hervey Bay", 3),
                new City(31, "Gladstone	", 3),
                new City(32, "Gold Coast-Tweed Heads", 3),
                new City(33, "Hobart", 6),
                new City(34, "Launceston", 6),
                new City(35, "Burnie-Devonport", 6),
                new City(36, "Camberra-Queanbeyan", 7),
                new City(37, "Darwin", 4),
                new City(38, "Melbourne", 5),
                new City(39, "Geelong", 5),
                new City(40, "Ballarat", 5),
                new City(41, "Bendigo", 5),
                new City(42, "La Trobe Valley", 5),
                new City(43, "Mildura", 5),
                new City(44, "Shepparton", 5),
                new City(45, "Warrnambool", 5),
                new City(9999, "Not Informed", 9999)
            );

            //Frequency
            modelBuilder.Entity<Frequency>().HasData(
                new Frequency(1, "Weekly"),
                new Frequency(2, "Fortnightly"),
                new Frequency(3, "Monthly"),
                new Frequency(4, "One Off"),
                new Frequency(5, "Exit Clean"),
                new Frequency(9999, "Not Informed")
            );

        }
    }
}
