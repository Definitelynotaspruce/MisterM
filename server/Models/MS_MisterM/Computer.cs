using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MisterM.Models.MsMisterM
{
    [Table("Computers", Schema = "dbo")]
    public partial class Computer
    {
        [Key] public string mac { get; set; }
        public string motherboard_name { get; set; }
        public string chassis_type { get; set; }
        public string serial_number { get; set; }
        public long total_storage { get; set; }
        public long total_used_storage { get; set; }
        public float total_ram { get; set; }
        public float used_ram { get; set; }
        public string cpu_model { get; set; }
        public float? cpu_temperature { get; set; }
        public float? cpu_max_temperature { get; set; }
        public float? cpu_load { get; set; }
        public float? cpu_average_clock_speed { get; set; }
    }
}