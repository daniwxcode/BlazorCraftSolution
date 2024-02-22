using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Domain.Contracts
{
    public interface IEntity<T>
    {
        T Id { get; }
    }
    public interface IAuditable<T>: IEntity<T>
    {        
        public  DateTime CreatedOn { get; init; }
        public string CreatedBy { get; set; }
        public DateTime? LastUpdatedOn { get; set; }
        public string? LastUpdatedBy { get; set; }
        public bool IsDeleted { get; set; } 
        public DateTime? IsDeletedOn { get; set; }
        public string? IsDeletedBy { get; set; }
    }
    

  

}
