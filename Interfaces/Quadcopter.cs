using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Quadcopter : IFlyingRobot, IChargeable
    {
        List<string> _components = new List<string> { "rotor1", "rotor2", "rotor3", "rotor4" };
        private bool _ischarge = false;
        public bool IsCharge
        {
            get => _ischarge; 
            set => _ischarge = value;
        }

        void IChargeable.Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
            IsCharge = true;
        }

        List<string> IRobot.GetComponents()
        {
            return _components;
        }

        string IRobot.GetInfo()
        {
            return $"Count rotors is : {_components.Count}";
        }

        string IChargeable.GetInfo()
        {
            return IsCharge ? "Fully charged" : "Discharged";
        }
    }
}
