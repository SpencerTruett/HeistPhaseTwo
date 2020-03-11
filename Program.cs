using System;
using System.Collections.Generic;

namespace HeistPartTwo
{
  class Program
  {
    static void Main(string[] args)
    {
      var Rolodex = new List<IRobber>();

      Hacker DaveTheHacker = new Hacker()
      {
        Name = "Dave the Hacker",
        SkillLevel = 45,
        PercentageCut = 15
      };
      Rolodex.Add(DaveTheHacker);

      Hacker SteveTheHacker = new Hacker()
      {
        Name = "Steve the Hacker",
        SkillLevel = 60,
        PercentageCut = 30
      };
      Rolodex.Add(SteveTheHacker);

      Muscle JimTheMuscle = new Muscle()
      {
        Name = "Jim the Muscle",
        SkillLevel = 40,
        PercentageCut = 10
      };
      Rolodex.Add(JimTheMuscle);

      Muscle JerryTheMuscle = new Muscle()
      {
        Name = "Jerry the Muscle",
        SkillLevel = 55,
        PercentageCut = 12
      };
      Rolodex.Add(JerryTheMuscle);

      LockSpecialist RachelTheLockSpecialist = new LockSpecialist()
      {
        Name = "Rachel the Lock Specialist",
        SkillLevel = 65,
        PercentageCut = 35
      };
      Rolodex.Add(RachelTheLockSpecialist);

      LockSpecialist DougTheLockSpecialist = new LockSpecialist()
      {
        Name = "Doug the Lock Specialist",
        SkillLevel = 30,
        PercentageCut = 10
      };
      Rolodex.Add(DougTheLockSpecialist);

      while (true)
      {
        Console.WriteLine($"There are currently {Rolodex.Count} crew members in the Rolodex.");
        Console.WriteLine("Would you like to add a new member? (Yes/No)");
        string YesNo = Console.ReadLine();

        if (YesNo.ToLower() == "yes")
        {
          Console.WriteLine("Please enter a crew member's name");
          string crewMemberName = Console.ReadLine();
          if (crewMemberName != "")
          {
            Console.WriteLine("Please Select a Specialty: ");
            Console.WriteLine("\t \u2022 Hacker (Disables alarms)");
            Console.WriteLine("\t \u2022 Muscle (Disarms guards)");
            Console.WriteLine("\t \u2022 Lock Specialist (cracks vault)");
            string crewSpecialty = Console.ReadLine();
            if (crewSpecialty != "")
            {
              Console.WriteLine("What is the Crew Member's Skill Level (1-100): ");
              string crewMemberSkill = Console.ReadLine();
              if (crewMemberSkill != "")
              {
                try
                {
                  int crewMemberSkillNumber = int.Parse(crewMemberSkill);
                  if (crewMemberSkillNumber >= 0 && crewMemberSkillNumber <= 100)
                  {
                    Console.WriteLine("What is the crew member's required cut (number only)?");
                    string crewMemberCut = Console.ReadLine();
                    if (crewMemberCut != "")
                    {
                      try
                      {
                        int crewMemberCutNumber = int.Parse(crewMemberCut);
                        if (crewMemberCutNumber >= 0 && crewMemberCutNumber <= 100)
                        {
                          if (crewSpecialty.ToLower() == "hacker" || crewSpecialty == "hacker (disables alarms)")
                          {
                            Hacker hacker = new Hacker()
                            {
                              Name = $"{crewMemberName}",
                              SkillLevel = crewMemberSkillNumber,
                              PercentageCut = crewMemberCutNumber
                            };

                            Rolodex.Add(hacker);
                          }
                          else if (crewSpecialty.ToLower() == "muscle" || crewSpecialty.ToLower() == "muscle (Disarms guards)")
                          {
                            Muscle muscle = new Muscle()
                            {
                              Name = $"{crewMemberName}",
                              SkillLevel = crewMemberSkillNumber,
                              PercentageCut = crewMemberCutNumber
                            };

                            Rolodex.Add(muscle);
                          }
                          else if (crewSpecialty.ToLower() == "lock specialist" || crewSpecialty.ToLower() == "lock specialist (cracks vault)" || crewSpecialty.ToLower() == "lockspecialist" || crewSpecialty.ToLower() == "lockspecialist (cracks vault)")
                          {
                            LockSpecialist lockSpecialist = new LockSpecialist()
                            {
                              Name = $"{crewMemberName}",
                              SkillLevel = crewMemberSkillNumber,
                              PercentageCut = crewMemberCutNumber
                            };

                            Rolodex.Add(lockSpecialist);
                          }
                        }
                        else
                        {
                          Console.WriteLine("Please enter a number 1-100!");
                        }
                      }
                      catch
                      {
                        Console.WriteLine("Please enter a valid number!");
                      }
                    }
                    else
                    {
                      Console.WriteLine("Please enter the crew member's required cut (number only)?");
                    }
                  }
                  else
                  {
                    Console.WriteLine("Please enter a number 1-100!");
                  }
                }
                catch
                {
                  Console.WriteLine("Please enter a valid number!");
                }
              }
              else
              {
                Console.WriteLine("Please Enter the Crew Member's Skill Level (1-100): ");
              }
            }
            else
            {
              Console.WriteLine("Please select the Crew Member's Skill Level (1-100): ");
              Console.WriteLine("\t \u2022 Hacker (Disables alarms)");
              Console.WriteLine("\t \u2022 Muscle (Disarms guards)");
              Console.WriteLine("\t \u2022 Lock Specialist (cracks vault)");
            }
          }
          else
          {
            Console.Clear();
            Console.WriteLine("Please enter a crew member's name");
          }
        }
        if (YesNo.ToLower() == "no")
        {
          Console.WriteLine("Goodbye");
          break;
        }
        else
        {
          Console.WriteLine("Please enter Yes or No to continue...");
        }
      }
    }
  }
}