using ProjectWebAPI.Model;

namespace ProjectWebAPI.Services.Implementations
{
    public class PersonServiceImplamentaftion : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public Person Delete(long Id)
        {
            throw new NotImplementedException();
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for( int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }

            return persons;
        }      

        public Person FinfById(long id)
        {
            return new Person {
                Id = IncrementAndGet(),
                FirstName = "Leandro",
                LastName = "Costa",
                Adress = "Rua 222",
                Gennder = "Miler"
            };

        }

        public Person Update(Person person)
        {
            return person;
        }
        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person LastName" + i,
                Adress = "Sun Adress" + i,
                Gennder = "Miler"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
