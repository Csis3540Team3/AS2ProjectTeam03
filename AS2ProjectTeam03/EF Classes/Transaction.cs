namespace AS2ProjectTeam03.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transaction")]
    public partial class Transaction
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int transactionId { get; set; }

        public int? transactionPorfolio { get; set; }

        public int? transactionCoin { get; set; }

        public virtual Coin Coin { get; set; }

        public virtual Portfolio Portfolio { get; set; }
    }
}
