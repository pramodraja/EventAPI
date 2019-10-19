using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventAPI.Models
{
    public class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public string Notes { get; set; }

    }
}
