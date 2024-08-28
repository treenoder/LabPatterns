namespace Task2
{
    public class Human : IWithFullName
    {
        private readonly string _firstName;
        private readonly string _lastName;
        
        public Human(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        
        public string FullName => $"{_firstName} {_lastName}";
    }
}