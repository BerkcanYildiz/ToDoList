using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace todolist
{
    public class ToDoListItem
    {
      
        public Guid Id { get; set; }
        public string GorevMetni { get; set; }
        public bool Tamamlandi { get; set; }
       

        public override string ToString()
        {
            
            return GorevMetni;
        }
    }
}
