using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace EFCoreWebDemo
{ 
    public class ListName
    {
        [Key]
        public int ListId { get; set; }
        public string Title { get; set; }
        public ICollection<ListDetails> ListDetail { get; set; } = new List<ListDetails>();
    }
}