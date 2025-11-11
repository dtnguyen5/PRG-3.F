namespace MyNamespace;

public class Light
{
    private bool State;
    private string Room;

    public Light(string room, bool state)
    {
        State = state;
        Room = room;
    }
    

    public void Toggle()
    {
        State = !State;
        if (State)
        {
            Console.WriteLine($"V {Room} svítí světlo");
        }
        else
        {
            Console.WriteLine($"V {Room} nesvítí světlo");   
        }
    }
}