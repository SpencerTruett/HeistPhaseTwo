using System;

namespace HeistPartTwo
{
  public class LockSpecialist : IRobber
  {
    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public int PercentageCut { get; set; }

    public void PerformSkill(Bank bank)
    {
      Console.WriteLine($"Vault Score: {bank.VaultScore}");
      Console.WriteLine($"Lock Specialist Skill Level: {SkillLevel}");
      Console.WriteLine($"{Name} is cracking the vault. Decreased vault score by {SkillLevel}");
      if (bank.VaultScore - SkillLevel <= 0)
      {
        Console.WriteLine($"{Name} has cracked the vault!");
      }
      else
      {
        Console.WriteLine($"{Name} has failed to open the vault...");
      }
    }
  }
}