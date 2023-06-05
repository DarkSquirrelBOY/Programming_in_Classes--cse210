public class Bird : Animal 
{

    private string _sound = "Tweet";


    public Bird()
    {
        SetLegs(2);
    }

    public void SetLegs(int legs)
    {

        if (legs > 2)
        {
            
        }

    }

    public void Speak()
    {
        System.Console.WriteLine($"{_sound}, {_sound}")
    }

}