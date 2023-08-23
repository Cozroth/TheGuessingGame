using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGuessGame.DTOs
{
    public class Guesses
    {
        private int _findThisNumber;
        private int _maxNumber;
        private int _amountOfGuesses;
        private int _highGuesses;
        private int _lowGuesses;

        public int FindThisNumber
        {
            get { return _findThisNumber; }
            set { _findThisNumber = value; }
        }
        public int MaxNumber
        {
            get { return _maxNumber; }
            set { _maxNumber = value; }
        }
        public int AmountOfGuesses
        {
            get { return _amountOfGuesses; }
            set { _amountOfGuesses = value; }
        }
        public int HighGuesses
        {
            get { return _highGuesses; }
            set { _highGuesses = value; }
        }
        public int LowGuesses
        {
            get { return _lowGuesses; }
            set { _lowGuesses = value; }
        }
    }
}
