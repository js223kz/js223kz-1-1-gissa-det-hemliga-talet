using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuessSecretNumber.Models
{
    public class SecretNumber
    {

        private List<GuessedNumber> _guessedNumbers;
        private GuessedNumber _lastGuessedNumber;
        private int? _number;
        public const int MaxNumberOfGuesses = 7;

        public SecretNumber()
        {
            //initiera List-objektet som håller ordning på gjorda gissningar
            Initialize();
        }

        public bool CanMakeGuess { get; }
        public int Count { get; }
        public IList<GuessedNumber> GuessedNumbers {
            get
            {
                return _guessedNumbers;
            }
        }
        public int? Number { get; private set; }

        public void Initialize()
        {
            //number ska slumpas till ett tal mellan 1-100
            // _guessedNumber ska tömmas
        }

        public Outcome MakeGuess(int guess)
        {
            throw new NotImplementedException();
            //anropas för att göra en gissning
            //beroende på gissningens resultat ska Outcome returneras
            //en gissning på ett tidigare gissat tal ska inte räknas
            //om guess inte är i intervallet 1-100
            //ska ett exception av typen ArgumentOutOfRange kastas

        }
    }
}