using System;

namespace HeistPartTwo
{
  public class Hacker : IRobber
  {
    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public int PercentageCut { get; set; }

    public void PerformSkill(Bank bank)
    {
      Console.WriteLine($"Alarm Score: {bank.AlarmScore}");
      Console.WriteLine($"Hacker Skill Level: {SkillLevel}");
      Console.WriteLine($"{Name} is hacking the alarm. Decreased alarm score by {SkillLevel}");
      if (bank.AlarmScore - SkillLevel <= 0)
      {
        Console.WriteLine($"{Name} has hacked the alarm!");
      }
      else
      {
        Console.WriteLine($"{Name} has failed to hack the alarm...");
      }
    }
  }
}