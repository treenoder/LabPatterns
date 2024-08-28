namespace Task2
{
    public class DogFullNameAdapter : IWithFullName
    {
        private readonly Dog _dog;
        
        public DogFullNameAdapter(Dog dog)
        {
            _dog = dog;
        }
        
        public string FullName => $"{_dog.Name} the Dog";
    }
}