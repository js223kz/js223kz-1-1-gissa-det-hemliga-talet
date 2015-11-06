using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuessSecretNumber.Models
{
    public class Outcome
    {
        public enum Result
        {
            Indefinate,
            Low,
            High,
            Right,
            NoMoreGuesses,
            OldGuess
        }
    }
}