namespace Week10;

public class Party
{
    private IEnumerable<Person> Partys= new List<Person>();
    
    public IEnumerable<Person> ShowAllPersons()
    {
        foreach (var item in Partys)
        {
            yield return item;
            
        }
        
    }
    public IEnumerable<Person> ShowAllActivePersons()
    {

        foreach (var item in Partys)
        {
            if (item.StatusPersona=="Active")
            {
                yield return item;
            }
        }
    }
    

    
}