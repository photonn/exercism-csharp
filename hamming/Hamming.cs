using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
       if  (firstStrand.Length != secondStrand.Length){
           throw new ArgumentException("Strands are not equal");
       } 
       int hamming = 0;
       int pos=0 ;
       char[] splittedFirst = firstStrand.ToCharArray();
       char[] splittedSecond = secondStrand.ToCharArray();
       while(pos<splittedFirst.Length){
           if (splittedFirst[pos] != splittedSecond[pos]){
               hamming++;
           }
           pos++;
       }
        return hamming;
    }
}