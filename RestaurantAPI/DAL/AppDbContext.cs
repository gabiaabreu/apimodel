using Microsoft.EntityFrameworkCore;
using RestaurantAPI.Domain.Entity;

namespace RestaurantAPI.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDish> OrderDishes { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Orders");

                entity.HasKey(e => e.Id).HasName("PK_ORDER");

                entity.Property(e => e.Id)
                    .HasColumnName("Id")
                    .HasColumnType("int")
                    .IsRequired()
                    .HasComment("Chave primária (identificador) de cada registro da tabela");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("OrderDate")
                    .HasColumnType("datetime")
                    .IsRequired();

                entity.Property(e => e.TotalPrice)
                    .HasColumnName("TotalPrice")
                    .HasColumnType("decimal(18, 2)")
                    .IsRequired();

                entity.Property(e => e.OrderStatus)
                    .HasColumnName("Status")
                    .HasColumnType("int")
                    .IsRequired();

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientId")
                    .HasColumnType("int")
                    .IsRequired();

                entity.Property(e => e.RestaurantId)
                    .HasColumnName("RestaurantId")
                    .HasColumnType("int")
                    .IsRequired();

                // Configuração de relacionamento com Clients
                entity.HasOne(o => o.Client)
                    .WithMany(c => c.Orders)
                    .HasForeignKey(o => o.ClientId)
                    .HasConstraintName("FK_ORDER_REFERENCE_CLIENT");

                // Configuração de relacionamento com Restaurants
                entity.HasOne(o => o.Restaurant)
                    .WithMany(r => r.Orders)
                    .HasForeignKey(o => o.RestaurantId)
                    .HasConstraintName("FK_ORDER_REFERENCE_RESTAURANT");
            });

            modelBuilder.Entity<OrderDish>(entity =>
            {
                entity.ToTable("OrderDishes");

                entity.HasKey(e => e.Id).HasName("PK_OrderDishes");

                entity.Property(e => e.Id)
                    .HasColumnName("Id")
                    .HasColumnType("int")
                    .IsRequired()
                    .HasComment("Chave primária (identificador) de cada registro da tabela");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderId")
                    .HasColumnType("int")
                    .IsRequired();

                entity.Property(e => e.DishId)
                    .HasColumnName("DishId")
                    .HasColumnType("int")
                    .IsRequired();

                entity.Property(e => e.Quantity)
                    .HasColumnName("Quantity")
                    .HasColumnType("int")
                    .IsRequired();

                // Configuração de relacionamento com Order
                entity.HasOne(od => od.Order)
                    .WithMany(o => o.OrderDishes)
                    .HasForeignKey(od => od.OrderId)
                    .HasConstraintName("FK_ORDERDISH_REFERENCE_ORDER");

                // Configuração de relacionamento com Dish
                entity.HasOne(od => od.Dish)
                    .WithMany(d => d.OrderDishes)
                    .HasForeignKey(od => od.DishId)
                    .HasConstraintName("FK_ORDERDISH_REFERENCE_DISH");
            });

            modelBuilder.Entity<Dish>(entity =>
            {
                entity.ToTable("Dishes");

                entity.HasKey(e => e.Id).HasName("PK_Dishes");

                entity.Property(e => e.Id)
                    .HasColumnName("Id")
                    .HasColumnType("int")
                    .IsRequired()
                    .HasComment("Chave primária (identificador) de cada registro da tabela");

                entity.Property(e => e.DishName)
                    .HasColumnName("Name")
                    .HasMaxLength(255)
                    .IsRequired();

                entity.Property(e => e.Description)
                    .HasColumnName("Description")
                    .HasMaxLength(400)
                    .IsRequired();

                entity.Property(e => e.Price)
                    .HasColumnName("Price")
                    .HasColumnType("decimal(18, 2)")
                    .IsRequired();

                // Propriedade de navegação para os OrderDishes associados a esse prato
                entity.HasMany(d => d.OrderDishes)
                    .WithOne(od => od.Dish)
                    .HasForeignKey(od => od.DishId)
                    .HasConstraintName("FK_DISH_REFERENCE_ORDERDISH");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("Clients");

                entity.HasKey(e => e.Id).HasName("PK_Clients");

                entity.Property(e => e.Id)
                    .HasColumnName("Id")
                    .HasColumnType("int")
                    .IsRequired()
                    .HasComment("Chave primária (identificador) de cada registro da tabela");

                entity.Property(e => e.ClientName)
                    .HasColumnName("Name")
                    .HasMaxLength(255)
                    .IsRequired();

                entity.Property(e => e.Email)
                    .HasColumnName("Email")
                    .HasMaxLength(255)
                    .IsRequired();

                entity.Property(e => e.ClientAddress)
                    .HasColumnName("Address")
                    .HasMaxLength(255)
                    .IsRequired();

                entity.Property(e => e.City)
                    .HasColumnName("City")
                    .HasMaxLength(80)
                    .IsRequired();

                entity.Property(e => e.Uf)
                    .HasColumnName("Uf")
                    .HasMaxLength(2)
                    .IsRequired();

                entity.Property(e => e.Cpf)
                    .HasColumnName("Cpf")
                    .HasMaxLength(11)
                    .IsRequired();

                entity.Property(e => e.ClientStatus)
                    .HasColumnName("Status")
                    .HasColumnType("int")
                    .IsRequired();

                // Propriedade de navegação para os Orders associados a esse cliente
                entity.HasMany(c => c.Orders)
                    .WithOne(o => o.Client)
                    .HasForeignKey(o => o.ClientId)
                    .HasConstraintName("FK_CLIENT_REFERENCE_ORDER");
            });

            modelBuilder.Entity<Restaurant>(entity =>
            {
                entity.ToTable("Restaurants");

                entity.HasKey(e => e.Id).HasName("PK_Restaurants");

                entity.Property(e => e.Id)
                    .HasColumnName("Id")
                    .HasColumnType("int")
                    .IsRequired()
                    .HasComment("Chave primária (identificador) de cada registro da tabela");

                entity.Property(e => e.RestaurantName)
                    .HasColumnName("Name")
                    .HasMaxLength(255)
                    .IsRequired();

                entity.Property(e => e.RestaurantAddress)
                    .HasColumnName("Address")
                    .IsRequired();

                entity.Property(e => e.ContactName)
                    .HasColumnName("ContactName")
                    .IsRequired();

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("PhoneNumber")
                    .HasMaxLength(11)
                    .IsRequired();

                entity.Property(e => e.Cnpj)
                    .HasColumnName("Cnpj")
                    .HasMaxLength(14)
                    .IsRequired();

                entity.Property(e => e.City)
                    .HasColumnName("City")
                    .HasMaxLength(80)
                    .IsRequired();

                entity.Property(e => e.Uf)
                    .HasColumnName("Uf")
                    .HasMaxLength(2)
                    .IsRequired();

                // Propriedade de navegação para os Orders associados a esse restaurante
                entity.HasMany(r => r.Orders)
                    .WithOne(o => o.Restaurant)
                    .HasForeignKey(o => o.RestaurantId)
                    .HasConstraintName("FK_RESTAURANT_REFERENCE_ORDER");
            });
        }
    }
}
