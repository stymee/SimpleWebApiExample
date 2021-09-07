public class DogsReader
{

    private readonly IList<Dog> Dogs = new List<Dog>();

    public DogsReader()
    {
        Dogs.Add(new Dog() { Name = "Blitzen", Breed = "lab mix", Birthday = new DateTime(2015, 1, 1) });
        Dogs.Add(new Dog() { Name = "Scully", Breed = "pit mix", Birthday = new DateTime(2015, 1, 1) });
        Dogs.Add(new Dog() { Name = "Matilda", Breed = "frenchie", Birthday = new DateTime(2016, 1, 1) });
        Dogs.Add(new Dog() { Name = "Doug", Breed = "who knows", Birthday = new DateTime(2017, 1, 1) });
        Dogs.Add(new Dog() { Name = "Daisy", Breed = "pit mix", Birthday = new DateTime(2016, 1, 1) });
        Dogs.Add(new Dog() { Name = "Moses", Breed = "bulldog", Birthday = new DateTime(2017, 1, 1) });
        Dogs.Add(new Dog() { Name = "Dakota", Breed = "border collie", Birthday = new DateTime(2017, 1, 1) });
        Dogs.Add(new Dog() { Name = "Lucy", Breed = "pug", Birthday = new DateTime(2020, 1, 1) });
    }

    public IEnumerable<Dog> GetDogs(string? name, string? breed)
    {
        var ret = Dogs.AsEnumerable();
        if (!string.IsNullOrWhiteSpace(name))
        {
            ret = ret.Where(s => s.Name.ToLower().Contains(name.ToLower()));
        }
        if (!string.IsNullOrWhiteSpace(breed))
        {
            ret = ret.Where(s => s.Breed.ToLower().Contains(breed.ToLower()));
        }
        return ret;
    }

    public Dog? GetDogByName(string name = "")
    {
        return Dogs.FirstOrDefault(s => s.Name.ToLower().Contains(name.ToLower()));
    }


}
