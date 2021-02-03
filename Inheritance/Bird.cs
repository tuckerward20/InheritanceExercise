using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            Legs = 2;
            WalksOn = 2;
        }
        public bool CanSwim { get; set; }
        public string BirdNoise { get; set; }
        public bool CanFly { get; set; }
        public bool IsNocturnal { get; set; }
    }
}
