using System;
    public class Person
    {

        
        public void Humor() { Console.WriteLine(" Show humor"); }
        public void Love() { Console.WriteLine(" Show love");}
        public void Courage() { Console.WriteLine(" Show courage");}
        public void Calm() { Console.WriteLine(" Show calm");}
       
    }

public interface IFamily
{
	void anger();
}

    public class FamilyContext:IFamily
    {
        public void Connect(Person familyMember)
        {
            //familyMember.Professional();//hide
           // familyMember.Disgust();//hide
			Console.WriteLine("Behavior with family ");
		familyMember.Humor(); 
        familyMember.Love(); 
       familyMember.Courage();
        familyMember.Calm();
           
        }
		public void anger(){Console.WriteLine(" Show Anger");}
    }





public interface IFriend
{
	void disgust();
}
    public class FriendContext : IFriend
    {
		
        public void Connect(Person friend)
        {
            //friend.Professional();//hide
		Console.WriteLine("Behavior with friends");
		friend.Humor(); 
        friend.Love(); 
       friend.Courage();
        friend.Calm();
			
        }
		public void disgust(){Console.WriteLine(" Show disgust");}
    }
	


    public class SocialContext
    {
        public void Connect(Person citizen)
        {
            //citizen.Anger();//hide
            //citizen.Disgust();//hide
			Console.WriteLine("Behavior in society");
		citizen.Humor(); 
        citizen.Love(); 
       citizen.Courage();
        citizen.Calm();
        }
    }



public interface IOffice
{
	void Proffesional();
}
    public class OfficeContext:IOffice
    {
        public void Connect(Person employee)
        {
            //employee.Anger();//hide
		Console.WriteLine("Behavior in office");	
		employee.Humor(); 
        employee.Love(); 
       employee.Courage();
        employee.Calm();
        }
		public void Proffesional(){Console.WriteLine(" Show professionalism");}
	}
	



    public class Program
    {
        public static void Main()
        {
            Person _person = new Person();
            
            FamilyContext familyContext = new FamilyContext();
            familyContext.Connect(_person);

            FriendContext friendContext = new FriendContext();
            friendContext.Connect(_person);

            OfficeContext officeContext = new OfficeContext();
            officeContext.Connect(_person);

            SocialContext socialContext = new SocialContext();
            socialContext.Connect(_person);
        }
    }
