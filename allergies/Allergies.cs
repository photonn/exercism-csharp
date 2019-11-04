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
    private List<Allergen> actualAllergens = new List<Allergen>();
    public Allergies(int mask)
    {
        int rest = mask;
        actualAllergens.Add(Allergen.Pollen);
        do{
            foreach(KeyValuePair<int,Allergen> kvp in ValuedAlergens){
                if (kvp.Key <= rest){
                    rest = rest-kvp.Key;
                    actualAllergens.Add(kvp.Value);   
                }
            }
        }while(rest>0);
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        if (actualAllergens.Contains(allergen)){
            return true;
        }else{
            return false;
        }
    }

    public Allergen[] List()
    {
        return actualAllergens.ToArray();
    }

}