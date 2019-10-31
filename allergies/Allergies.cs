using System;
using System.Collections.Generic;
using System.Diagnostics;

public enum Allergen
{
    Eggs,
    Peanuts,
    Shellfish,
    Strawberries,
    Tomatoes,
    Chocolate,
    Pollen,
    Cats
}

public class Allergies
{
    private Dictionary<int,Allergen> ValuedAlergens = new Dictionary<int, Allergen> 
    { 
        {1,Allergen.Eggs},
        {2,Allergen.Peanuts},
        {4,Allergen.Shellfish},
        {8,Allergen.Strawberries},
        {16,Allergen.Tomatoes},
        {32,Allergen.Chocolate},
        {64,Allergen.Pollen},
        {128,Allergen.Cats}
    };
    public Allergies(int mask)
    {

    }

    public bool IsAllergicTo(Allergen allergen)
    {
        //throw new NotImplementedException("You need to implement this function.");
        return true;
    }

    public Allergen[] List()
    {
        //throw new NotImplementedException("You need to implement this function.");
        return new Allergen[] {Allergen.Eggs};
    }

}