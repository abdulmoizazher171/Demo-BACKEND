using System.ComponentModel.DataAnnotations;

namespace ERP_BACKEND.constracts;

public class AppActivity
{

public int Id { get; set; }


        public DateTime LogDate { get; set; }

        [Required]
        [StringLength(50)]
        public string EventName { get; set; }

        [StringLength(255)]
        public string PagePath { get; set; }

        [StringLength(2048)]
        public string SearchQuery { get; set; }

        [StringLength(255)]
        public string PageTitle { get; set; }

        [StringLength(1024)]
        public string UserAgent { get; set; }
}