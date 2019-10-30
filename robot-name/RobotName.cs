using System;

public class Robot
{
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
            string tempName = "";
            for(int position=0;position<=1;position++){
                tempName = tempName + chars[random.Next(0, chars.Length-1)].ToString().ToUpper();
            }
            tempName = tempName + random.Next(0,999).ToString();
            name = tempName;
        }
    }
    public Robot()
    {
        Reset();
    }
    public void Reset()
    {
        Name = "";
    }
}