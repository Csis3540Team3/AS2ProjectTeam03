namespace AS2ProjectTeam03.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Coin")]
    public partial class Coin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Coin()
        {
            Transactions = new HashSet<Transaction>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int coinId { get; set; }

        [Required]
        [StringLength(20)]
        public string coinName { get; set; }

        [Required]
        [StringLength(5)]
        public string coinSymbol { get; set; }

        [Required]
        [StringLength(3)]
        public string coinCurrency { get; set; }

        public double coinCurrencyValue { get; set; }

        public double coin24HourChange { get; set; }

        public double? coinMaxSupply { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
