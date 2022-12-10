using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarthProject
{
    public class Validator
    {
        //checking blank fields

        public string IsNotBlank(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg += name + " cannot be blank.\n";
            }
            return msg;
        }

        //checking for int
        public string IsInt32(string value, string name)
        {
            string msg = "";
            if (!Int32.TryParse(value, out _))
            {
                msg += name + " must be a valid integer value.\n";
            }
            return msg;
        }

        //checking for in range.
        public string IsWithinRange(string value, string name, decimal min,
        decimal max)
        {
            string msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if (number < min || number > max)
                {
                    msg += name + " must be between " + min + " and " + max + ".\n";
                }
            }
            return msg;
        }
    }
}
