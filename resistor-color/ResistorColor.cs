using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        //throw new NotImplementedException("You need to implement this function.");
        int counter = 0;
        foreach(string comp in Colors()){
            if(comp == color){
                return counter;
            }else{
                counter++;
            }
        }
        return counter;
    }

    public static string[] Colors()
    {
        return new string[10]{"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
    }
}