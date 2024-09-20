using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class UserError
    {
       
        public abstract string UEMessage();
    }


    class NumericInputError : UserError
    {
        // Override för UEMessage() som returnerar ett specifikt felmeddelande
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }


    class TextInputError : UserError
    {
        // Override för UEMessage() som returnerar ett specifikt felmeddelande
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }

    // egna klasser med egna definitioner på UEMessage()

    class SpecialCharacterError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use special characters in a field that only accepts alphanumeric values. This fired an error!";
        }
    }

    class EmptyFieldError : UserError
    {
        public override string UEMessage()
        {
            return "You left a required field empty. This fired an error!";
        }
    }

    class OutOfRangeError : UserError
    {
        public override string UEMessage()
        {
            return "You entered a value outside the acceptable range. This fired an error!";
        }
    }
}