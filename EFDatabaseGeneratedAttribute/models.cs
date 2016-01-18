using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDatabaseGeneratedAttribute
{

    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  
        public int SrNo { get; set; }

    }



    public class Employee1
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]  
        public int Employee1ID { get; set; }
        public string Name { get; set; }

    }


    public class Employee2
    {
        
        public int Employee2ID { get; set; }
        public string Name { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? Amount { get; set; }
    }

}
