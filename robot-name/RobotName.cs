using System;
using System.Collections.Generic;

public class Robot
{
    private static List<string> names = new List<string>();
    private string name;
    public string Name
    {
        get
        {
            return name;
        }
        private set{
            char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Random random = new Random(); 
            name = chars[random.Next(0, chars.Length-1)].ToString().ToUpper();
            name = name + chars[random.Next(0, chars.Length-1)].ToString().ToUpper();
            name = name + random.Next(0,999).ToString("000");
        }
    }

    public Robot()
    {
        Reset();
    }
    public void Reset()
    {
        do{
            Name = "";
        }while(names.Contains(Name));
        names.Add(Name);    
    }
}