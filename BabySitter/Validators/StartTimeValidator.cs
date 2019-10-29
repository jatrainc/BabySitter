using System;
using BabySitter.Constants;
using BabySitter.Exceptions;
namespace BabySitter.Validators
{
    public class StartTimeValidator
    {
        public static bool ValidateStartTime(TimeSpan startTime)
        {
            return TimeSpanConstants.ValidHours.Contains(startTime);
        }
    }
}
