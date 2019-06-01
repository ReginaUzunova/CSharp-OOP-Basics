using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class PollMembers
    {
        private List<Person> members;

        public PollMembers()
        {
            this.Members = new List<Person>();
        }

        public List<Person> Members
        {
            get {return this.members; }
            set {this.members = value; }
        }

        public void AddMember(Person member)
        {
            if (member == null)
            {
                throw new Exception();
            }
            else if (member.Age > 30)
            {
                this.members.Add(member);
            }
        }
    }
}
