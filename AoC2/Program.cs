// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using AoC2.Enums;
using AoC2.Models;

namespace AoC2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var instructions = InputHelper.GetInput(args[0]);
            RunPuzzle1(instructions);
            RunPuzzle2(instructions);
        }

        private static void RunPuzzle1(List<Instruction> instructions)
        {
            var horizontalPosition = instructions.Where(x => x.Direction == Direction.Horizontal).Sum(x => x.Magnitude);
            var verticalPos = instructions.Where(x => x.Direction == Direction.Vertical).Sum(x => x.Magnitude);
            Console.WriteLine($"Horizontal position: {horizontalPosition}");
            Console.WriteLine($"Vertical position: {verticalPos}");
            Console.Write($"Horizontal position X vertical position = {horizontalPosition * verticalPos}\n\n");
        }

        private static void RunPuzzle2(List<Instruction> instructions)
        {
            var verticalPos = 0;
            var horizontalPos = 0;
            var aim = 0;
            instructions.ForEach(instruction =>
            {
                if (instruction.Direction == Direction.Vertical)
                    aim += instruction.Magnitude;
                if (instruction.Direction == Direction.Horizontal)
                {
                    verticalPos += aim * instruction.Magnitude;
                    horizontalPos += instruction.Magnitude;
                }
            });
            
            Console.WriteLine($"Horizontal position: {horizontalPos}");
            Console.WriteLine($"Vertical position: {verticalPos}");
            Console.Write($"Horizontal position X vertical position = {horizontalPos * verticalPos}");
            
        }
    }   
}