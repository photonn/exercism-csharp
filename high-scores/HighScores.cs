// This file was auto-generated based on version 4.0.0 of the canonical data.

using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{

    private List<int> lista;

    public HighScores(List<int> list)
    {
        this.lista=list;
    }

    public List<int> Scores() => this.lista;

    public int Latest() => lista.Last();

    public int PersonalBest() => lista.Max();

    public List<int> PersonalTopThree() => lista.OrderByDescending(i => i).Take(3).ToList();
}