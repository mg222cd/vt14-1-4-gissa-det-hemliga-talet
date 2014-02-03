using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.ObjectModel;

namespace _1DV406S1L04.App_Code
{
    public class SecretNumber
    {
        // Konstant för max nummer gissningar:
        public const int MaxNumberOfGuesses = 7;

        // Fält fom lagrar hemligt nummer samt tidigare gissningar.
        private int _number; 
        private List<int> _previousGuess = new List<int>();

        // Konstruktor:
        public SecretNumber()
        {
            Initialize();
            _previousGuess = new List<int>();
        }

        //Egenskaper
        public bool CanMakeGuess
        {
            get
            {
                if (Outcome == Outcome.NoMoreGuesses)
                {
                    return false;
                }
                else if (Outcome == Outcome.Correct)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public int Count
        {
            get { return _previousGuess.Count(); }
        }
        public Outcome Outcome
        {
            get;
            private set;
        }
        public int? Number
        {
            get 
            {
                if (CanMakeGuess != true)
                {
                    return _number;
                }
                else
                {
                    return null;
                }
            }
            private set 
            {
                int? _number = value as int?;
            }
        }
        public ReadOnlyCollection<int> PreviousGuess
        {
            get
            {
                ReadOnlyCollection<int> prevGuess = new ReadOnlyCollection<int>(_previousGuess);
                return prevGuess;
            }
        }

        // Metod för att slumpa tal:
        public void Initialize()
        {
            Random random = new Random();
            _number = random.Next(1, 101);
            _previousGuess.Clear();
           Outcome = Outcome.Indefinite;
        }

        // Metod för att hantera gissningar:
    }
}