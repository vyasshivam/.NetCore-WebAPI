using System.ComponentModel.DataAnnotations;

namespace EFCoreWebDemo
{ 
    public class ListDetails
    {
        [Key]
        public int DetailID { get; set; }
        public string  Description { get; set; }
        public string Checked { get; set; }
    }
}