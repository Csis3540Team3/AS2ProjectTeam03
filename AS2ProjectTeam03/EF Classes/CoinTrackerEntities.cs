namespace AS2ProjectTeam03.EF_Classes
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CoinTrackerEntities : DbContext
    {
        public CoinTrackerEntities()
            : base("name=CoinTrackerEntities")
        {
        }

        public virtual DbSet<Coin> Coins { get; set; }
        public virtual DbSet<Portfolio> Portfolios { get; set; }
        public virtual DbSet<Quote> Quotes { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coin>()
                .Property(e => e.coinName)
                .IsUnicode(false);

            modelBuilder.Entity<Coin>()
                .Property(e => e.coinSymbol)
                .IsUnicode(false);

            modelBuilder.Entity<Coin>()
                .HasMany(e => e.Quotes)
                .WithOptional(e => e.Coin)
                .HasForeignKey(e => e.quoteCoinId);

            modelBuilder.Entity<Coin>()
                .HasMany(e => e.Transactions)
                .WithOptional(e => e.Coin)
                .HasForeignKey(e => e.transactionCoinId);

            modelBuilder.Entity<Portfolio>()
                .Property(e => e.portfolioName)
                .IsUnicode(false);

            modelBuilder.Entity<Portfolio>()
                .HasMany(e => e.Transactions)
                .WithOptional(e => e.Portfolio)
                .HasForeignKey(e => e.transactionPorfolioId);

            modelBuilder.Entity<Quote>()
                .HasMany(e => e.Transactions)
                .WithOptional(e => e.Quote)
                .HasForeignKey(e => e.transactionQuoteId);
        }
    }
}
