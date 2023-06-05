public class Dog : Animal
{
    private string _sound = "woof";

    public Dog()
    {

    }


    public void Speak()
    {
        System.Console.WriteLine($"{_sound}, {_sound}")
    }


}