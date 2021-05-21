namespace DesktopBookmaker.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.MoneyManagement")]
    public partial class MoneyManagement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int IdUser { get; set; }

        public int IdOperator { get; set; }

        public bool TakeOrAdd { get; set; }

        public decimal Sum { get; set; }

        public DateTimeOffset Date { get; set; }

        public string Details { get; set; }

        public virtual Operators Operators { get; set; }

        public virtual Users Users { get; set; }
    }
}
