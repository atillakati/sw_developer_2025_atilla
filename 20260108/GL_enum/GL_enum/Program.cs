namespace GL_enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PowerState state = PowerState.Off;

            state = PowerState.Standby;

            Console.WriteLine("State: " + state);

            if (state > PowerState.Off)
            {
                Console.WriteLine("Rechner läuft!");
            }
        }
    }
}
