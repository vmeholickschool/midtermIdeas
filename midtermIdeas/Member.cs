using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midtermIdeas
{
    abstract class Member
    { //Id and name needed
        public int Id { get; set; }
        public required string Name { get; set; }

        // Abstract method for checking in
        public abstract void CheckIn(Club club);
    }
}