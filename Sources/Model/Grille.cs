﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public int Id { get; set; }
    public class Grille
    {
        public int NbChaine { get; set; }
        public int NbZone { get; set; }
        public int MaxChaine { get; set; }
        public int MaxZone { get; set; }

        public ReadOnlyCollection<Case> Cases { get; private set; }
        private List<Case> cases = new();


        //public Grille(List<Case> cases)
        //{
        //    Cases = cases.AsReadOnly();
        //}

        public Grille()
        {
            Cases = new ReadOnlyCollection<Case>(cases);
            cases.AddRange((Enumerable.Repeat(new Case(), 19)));
        }

        public bool AddValueToCase(int value, int index)
        {
            if(index > 0 || index <= cases.Count)
            {
                cases[index - 1].Valeur = value;
                return true;
            }
            return false;
        }
    }
}
