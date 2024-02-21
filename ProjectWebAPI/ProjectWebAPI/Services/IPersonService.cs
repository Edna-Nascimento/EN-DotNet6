using ProjectWebAPI.Model;

namespace ProjectWebAPI.Services
{
    public interface IPersonService
    {
        Person Create(Person person);

        Person Update(Person person);

        Person Delete(long Id);

        Person FinfById(long Id);

        List<Person> FindAll();
    }
}
