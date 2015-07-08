using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Microsoft.Practices.EnterpriseLibrary.Logging;
//using Microsoft.Practices.EnterpriseLibrary.Data;

namespace SL
{
    public static class ExceptionLogging
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public static void LogWriter(string message)
        {
            LogEntry logentry = new LogEntry();
            logentry.Message = message;
            logentry.Title = "Program";
            logentry.TimeStamp = DateTime.Now;
            Logger.Write(logentry);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ex"></param>
        public static void HandleException(Exception ex)
        {
            ExceptionLogging.LogWriter(ex.Message);
            ExceptionPolicy.HandleException(ex, "Exception Policy");
        }
    }
}
