namespace DesktopBookmaker.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.Admins")]
    public partial class Admins
    {
        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
