using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3Polymorfism
{
    abstract class UserError
    {
        public abstract string UEMessage();
    }

    class NumericInputError : UserError
    {
        public override string UEMessage() => "You tried to use a numeric input in a text only field. This fired an error!";
    }

    class TextInputError : UserError
    {
        public override string UEMessage() => "You tried to use a text input in a numericonly field. This fired an error!";
    }
    
    class TooShortPasswordError : UserError
    {
        public override string UEMessage() => "You tried a too short password. This fired an error!";
    }

    class TooLongPasswordError : UserError
    {
        public override string UEMessage() => "You tried a too long password. This fired an error!";
    }

    class SpecialCharacterError : UserError
    {
        public override string UEMessage() => "You didn't have a special character in yout password. This fired an error!";
    }
}
