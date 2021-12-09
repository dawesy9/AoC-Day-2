using AoC2.Enums;

namespace AoC2.Models
{
    public class Instruction
    {
        public Direction Direction { get; }
        public int Magnitude { get; }

        public Instruction(Direction direction, int magnitude)
        {
            Direction = direction;
            Magnitude = magnitude;
        }
    }
}