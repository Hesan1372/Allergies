using System;
using System.Collections.Generic;
using System.Linq;
public enum Allergen
{
    Eggs=1,
    Peanuts=2,
    Shellfish=4,
    Strawberries=8,
    Tomatoes=16,
    Chocolate=32,
    Pollen=64,
    Cats=128
}

public class Allergies
{
    public int _a { get;}
    public Allergies(int mask)
    {
        _a = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return (_a & (int)allergen) > 0;
    }

    public Allergen[] List()
    {
        List<Allergen> AList = new List<Allergen>();

        foreach (Allergen A  in Enum.GetValues(typeof(Allergen)))
	    {
            if (IsAllergicTo(A))
	        {
                AList.Add(A);
	        }
	    }
        return   AList.ToArray();
    }
}