using System;

namespace HeistPartTwo
{
  public class Muscle : IRobber
  {
    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public int PercentageCut { get; set; }

    public void PerformSkill(Bank bank)
    {
      Console.WriteLine($"Security Guard Score: {bank.SecurityGuardScore}");
      Console.WriteLine($"Muscle Skill Level: {SkillLevel}");
      Console.WriteLine($"{Name} is taking care of the guards. Decreased security guard score by {SkillLevel}");
      if (bank.SecurityGuardScore - SkillLevel <= 0)
      {
        Console.WriteLine($"{Name} has taken care of the guards!");
      }
      else
      {
        Console.WriteLine($"{Name} has failed to take care of all of the guards...");
      }
    }
  }
}