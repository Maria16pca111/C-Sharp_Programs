//Method Overriding without using virtual and override modifiers
    class baseclass
    {
        public void show()
        {
            Console.WriteLine("Base class");
        }   
    }
    class derivedclass : baseclass
    {
        new public void show()
        {
            Console.WriteLine("Derived Class");
        }
    }
    //Method Overriding using virutal and overrride modifiers
    class baseclassVirtual
    {
        public virtual void show()
        {
            Console.WriteLine("The Virtual Base Class");
        }
    }
    class derivedclassvirtual : baseclassVirtual
    {
        public override void show()
        {
            Console.WriteLine("The Override derived clas");
        }
    }
