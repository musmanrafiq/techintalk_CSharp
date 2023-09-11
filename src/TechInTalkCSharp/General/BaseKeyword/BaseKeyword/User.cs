namespace BaseKeyword
{
    public class User
    {
        public User()
        {
            this.Name = "TechInTalk";
        }
        public virtual string Name { get; set; }

        public virtual string GetName() { return this.Name; }

    }

    public class Employee : User
    {
        public Employee()
        {

        }

        public override string GetName()
        {
            return base.GetName();
        }
        public override string Name
        {
            get
            {
                var parentName = base.Name;
                return parentName.ToUpper();
            }
        }
    }
}
