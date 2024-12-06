using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStudio.Movie
{
    public class ErrorHandler
    {
        public void HandleAccountantNotFound()
        {
            // Handle the error, e.g., logging, notification, or exception throwing
            throw new InvalidOperationException("Accountant not found in the staffing service.");
        }
    }
}
