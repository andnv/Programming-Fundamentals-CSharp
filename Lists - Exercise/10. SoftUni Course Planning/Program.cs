namespace _10._SoftUni_Course_Planning
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine()
                         .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                         .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "course start")
            {
                string[] cmdArgs = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];

                if (command == "Add")
                {
                    string lessonTitle = cmdArgs[1];

                    if (schedule.Contains(lessonTitle))
                    {
                        continue;
                    }
                    else
                    {
                        schedule.Add(lessonTitle);
                    }
                }
                else if (command == "Insert")
                {
                    string lessonTitle = cmdArgs[1];
                    int index = int.Parse(cmdArgs[2]);

                    if (schedule.Contains(lessonTitle))
                    {
                        continue;
                    }
                    else
                    {
                        schedule.Insert(index, lessonTitle);
                    }
                }
                else if (command == "Remove")
                {
                    string lessonTitle = cmdArgs[1];

                    if (schedule.Contains(lessonTitle))
                    {
                        schedule.Remove(lessonTitle);
                    }
                    else if (schedule.Contains(lessonTitle + "-Exercise"))
                    {
                        schedule.Remove(lessonTitle + "-Exercise");
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Swap")
                {
                    string firstLessonTitle = cmdArgs[1];
                    string secondLessonTitle = cmdArgs[2];
                    int index1 = schedule.IndexOf(firstLessonTitle);
                    int index2 = schedule.IndexOf(secondLessonTitle);

                    if (schedule.Contains(firstLessonTitle) && schedule.Contains(secondLessonTitle))
                    {
                        string swapLesson = schedule.ElementAt(index1);
                        schedule[index1] = schedule[index2];
                        schedule[index2] = swapLesson;

                    }
                    else
                    {
                        continue;
                    }

                    if (schedule.Contains(firstLessonTitle + "-Exercise") && schedule.Contains(schedule[index1]))
                    {
                        index1 = schedule.IndexOf(firstLessonTitle);
                        schedule.Remove(firstLessonTitle + "-Exercise");
                        schedule.Insert(index1 + 1, firstLessonTitle + "-Exercise");
                    }
                    else if (schedule.Contains(secondLessonTitle + "-Exercise") && schedule.Contains(schedule[index2]))
                    {
                        index2 = schedule.IndexOf(secondLessonTitle);
                        schedule.Remove(secondLessonTitle + "-Exercise");
                        schedule.Insert(index2 + 1, secondLessonTitle + "-Exercise");
                    }
                }
                else if (command == "Exercise")
                {
                    string lessonTitle = cmdArgs[1];

                    if (schedule.Contains(lessonTitle) && !schedule.Contains(lessonTitle + "-Exercise"))
                    {
                        int index = schedule.IndexOf(lessonTitle);
                        schedule.Insert(index + 1, lessonTitle + "-Exercise");
                    }
                    else if (!schedule.Contains(lessonTitle))
                    {
                        schedule.Add(lessonTitle);
                        schedule.Add(lessonTitle + "-Exercise");
                    }
                }
            }

            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }
    }
}
