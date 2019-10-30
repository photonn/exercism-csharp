using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static Dictionary<char, int> Count(string sequence){
        try{
            Dictionary<char, int> nucleotides = new Dictionary<char, int>();
            char[] indNucleotids = sequence.ToCharArray();
            nucleotides.Add('A',0);
            nucleotides.Add('C',0);
            nucleotides.Add('G',0);
            nucleotides.Add('T',0);
            foreach(char nucleotide in indNucleotids){
                nucleotides[nucleotide] =  nucleotides[nucleotide] + 1;
            }
            return nucleotides;
        }
        catch{
            throw new ArgumentException();
        }
    }
}