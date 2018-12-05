namespace AS2ProjectTeam03.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Portfolio")]
    public partial class Portfolio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Portfolio()
        {
            Transactions = new HashSet<Transaction>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int portfolioId { get; set; }

        [Required]
        [StringLength(20)]
        public string portfolioName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
