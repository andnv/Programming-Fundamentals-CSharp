using System.Collections.Generic;

namespace _04._Snowwhite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> dwarfsData 
                = new Dictionary<string, Dictionary<string, int>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] dwarfsArgs = input.Split(" <:> ");

                string dwarfName = dwarfsArgs[0];
                string dwarfHatColor = dwarfsArgs[1];
                int dwarfPhysics = int.Parse(dwarfsArgs[2]);

                if (!dwarfsData.ContainsKey(dwarfHatColor))
                {
                    dwarfsData[dwarfHatColor] = new Dictionary<string, int>();
                    dwarfsData[dwarfHatColor].Add(dwarfName, dwarfPhysics);
                }
                else
                {
                    if (dwarfsData[dwarfHatColor].ContainsKey(dwarfName))
                    {
                        if (dwarfsData[dwarfHatColor][dwarfName] < dwarfPhysics)
                        {
                            dwarfsData[dwarfHatColor][dwarfName] = dwarfPhysics;
                        }
                    }
                    else
                    {
                        dwarfsData[dwarfHatColor].Add(dwarfName, dwarfPhysics);
                    }
                }
            }

            Dictionary<string, int>  sortedDwarfs = new Dictionary<string, int>();

            foreach (var dwarf in dwarfsData
                .OrderByDescending(x => x.Value.Count()))
            {
                string dwarfHatColor = dwarf.Key;
                var dwarfNamesAndPhysics = dwarf.Value;

                foreach (var dw in dwarfNamesAndPhysics)
                {
                    string dwarfName = dw.Key;
                    int dwarfPhysics = dw.Value;

                    sortedDwarfs.Add($"({dwarfHatColor}) {dwarfName} <-> ", dwarfPhysics);
                }
            }

            foreach (var dwarf in sortedDwarfs
                .OrderByDescending(x => x.Value))
            {
                string dwarfName = dwarf.Key;
                int dwarfPhysics = dwarf.Value;

                Console.WriteLine($"{dwarfName}{dwarfPhysics}");
            }
        }
    }
}