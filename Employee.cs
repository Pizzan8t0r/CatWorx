namespace CatWorx.BadgeMaker
{
    class Employee
    {
        // public being the access modifier
       public string FirstName;
       public string LastName;
       public int Id;
       public string PhotoUrl;
       // update Employee to add a constructor that accepts a first name and sets the FirstName property
       public Employee(string firstName, string lastName) {
        FirstName = firstName;
        LastName = lastName;
       }
       public string GetFullName() {
        return FirstName + "" + LastName;
       }
    }
}