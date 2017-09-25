﻿using System;

namespace GuessNumberLib
{
    public class GuessNumber
    {
        private int numberToGuess = 42;
        private int _triesMade;
        private int _lastGuess;

        public string Feedback
        {
            get
            {
                if(_triesMade == 0)
                {
                    return "Guess a number between 1 and 100.";
                }
                else if(_lastGuess < numberToGuess)
                {
                    return "Guess higher.";
                }
                else if(_lastGuess >  numberToGuess)
                {
                    return "Guess lower.";
                }
                else
                {
                    return $"You made it in {_triesMade} tries.";
                }
                
            }
        }

        public string Tries
        {
            get
            {
                _triesMade++;
                return _triesMade.ToString();
            }
        }

        public bool GameOver
        {
            get
            {
                return _lastGuess == numberToGuess;
            }
        }

        public void Guess(int guessedNumber)
        {
            _triesMade++;
            _lastGuess = guessedNumber;
        }
    }
}
