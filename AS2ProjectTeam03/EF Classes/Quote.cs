namespace AS2ProjectTeam03.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Quote")]
    public partial class Quote
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Quote()
        {
            Transactions = new HashSet<Transaction>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int quoteId { get; set; }

        public DateTime quoteDateTime { get; set; }

        public double? quoteVolume { get; set; }

        public double quotePrice { get; set; }

        public double? quote24Hr { get; set; }

        public int? quoteCoinId { get; set; }

        public virtual Coin Coin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
