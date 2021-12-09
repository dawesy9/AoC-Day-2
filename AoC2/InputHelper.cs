using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using AoC2.Enums;
using AoC2.Models;

namespace AoC2
{
    public static class InputHelper
    {
        public static List<Instruction> GetInput(string fileName)
        {
            var inputFilePath = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\{fileName}";
            var inputs = File.ReadAllLines(inputFilePath);
            return inputs.Select(x =>
            {
                var inputParts = x.Trim().Split(' ');
                return ParseInstruction(inputParts[0], inputParts[1]);
            }).ToList();
        }

        private static Instruction ParseInstruction(string directionString, string magnitudeString)
        {
            var magnitude = int.Parse(magnitudeString);

            return directionString.ToLowerInvariant() switch
            {
                "forward" => new Instruction(Direction.Horizontal, magnitude),
                "down" => new Instruction(Direction.Vertical, magnitude),
                "up" => new Instruction(Direction.Vertical, (magnitude * -1)),
                _ => throw new Exception("Malformed instruction")
            };
        }
    }
}