// This file was auto-generated based on version 4.0.0 of the canonical data.

using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{

    List<int> lista;

    public HighScores(List<int> list)
    {
        this.Lista=list;
    }

    public List<int> Scores() => this.Lista;

    public int Latest() => Lista.Last();

    public int PersonalBest() => Lista.Max();

    public List<int> PersonalTopThree() => Lista.OrderByDescending(i => i).Take(3).ToList();
}