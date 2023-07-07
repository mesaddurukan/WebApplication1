using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class departmanlar
    {
       [Key] 
        public int id { get; set; }
        public string departmanad { get; set; }

        public List<personel> Personels { get; set; }
    }
}
