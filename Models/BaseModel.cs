using System.Data;
using WebApplication1minor.Models;

namespace WebApplication1minor.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDataTime { get; set;}


    }
}