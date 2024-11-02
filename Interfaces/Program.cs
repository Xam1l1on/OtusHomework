namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRobot simpleRobot = new Quadcopter();
            Console.WriteLine(simpleRobot.GetRobotType());
            Console.WriteLine(simpleRobot.GetInfo());
            Console.WriteLine(simpleRobot.GetComponents());
            IFlyingRobot flyRobot = new Quadcopter();
            Console.WriteLine(flyRobot.GetRobotType());
            Console.WriteLine(flyRobot.GetInfo());
            Console.WriteLine(flyRobot.GetComponents());

            IChargeable chargeable = new Quadcopter();
            Console.WriteLine(chargeable.GetInfo());
            chargeable.Charge();
            Console.WriteLine(chargeable.GetInfo());
            Quadcopter quadcopter = new Quadcopter();
        }
    }
}
