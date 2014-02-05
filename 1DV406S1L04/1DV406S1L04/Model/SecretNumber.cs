using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace _1DV406S1L04.Model
{
    public class SecretNumber
    {
        // Konstant:
        public const int MaxNumberOfGuesses = 7;

        // Fält
        private int _number;
        private List<int> _previousGuess = new List<int>();

        // Konstruktor
        public SecretNumber()
        {
            Initialize();
            _previousGuess = new List<int>(MaxNumberOfGuesses);
        }

        // Egenskaper
        public Outcome Outcome
        {
            get;
            private set;
        }
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
            get { return _previousGuess.Count; }
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

        // Metoder:
        // slumpar fram och nollställer:
        public void Initialize()
        {
            Random random = new Random();
            _number = random.Next(1, 101);
            _previousGuess.Clear();
            Outcome = Outcome.Indefinite;
        }
        //Hanterar gissningar
        public Outcome MakeGuess(int guess)
        {
            //Validering
            if (guess > 0 && guess < 101)
            {
                //Kontroll om gissning är tillåten...
                if (CanMakeGuess == false)
                {
                    if (Outcome == Outcome.Correct)
                    {
                        return Outcome.Correct;
                    }
                    else
                    {
                        return Outcome.NoMoreGuesses;
                    }
                }
                else
                {
                    //...och inte redan gjord
                    if (_previousGuess.Contains(guess))
                    {
                        Outcome = Outcome.PreviousGuesses;
                    }
                    else
                    {
                        //gissningen är tillåten, börja med att lägga till gissningen:
                        //kontrollera resultatet:
                        if (guess == _number)
                        {
                            Outcome = Outcome.Correct;
                        }
                        else if (guess > _number)
                        {
                            Outcome = Outcome.High;
                        }
                        else if (guess < _number)
                        {
                            Outcome = Outcome.Low;
                        }
                        else
                        {
                            Outcome = Outcome.Indefinite;
                        }
                        //lägger till gissningen:
                        _previousGuess.Add(guess);
                        //kontrollerar om det var sista försöket:
                        if (Count == MaxNumberOfGuesses && guess != _number)
                        {
                            Outcome = Outcome.NoMoreGuesses;
                        }
                    }

                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("guess", "ska vara ett heltal mellan 1-100");
            }
            return Outcome;
        }



    }
}