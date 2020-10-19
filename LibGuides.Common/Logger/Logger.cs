using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Web;

namespace LibGuides.Common.Logger
{
    public static class Logger
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly bool isDebugEnable = ConfigurationManager.AppSettings["DebugEnabled"] == null ? false : Convert.ToBoolean(ConfigurationManager.AppSettings["DebugLogEnable"]);

        #region - Info -
        /// <summary>
        /// Logs the info into the text file...
        /// </summary>
        /// <param name="statement">Information Statement</param>
        public static void Info(string statement)
        {

            log4net.Config.XmlConfigurator.Configure();
            Log.Info(statement);
        }
        #endregion

        #region - Debug -
        /// <summary>
        /// Logs the Debug into the text file...
        /// </summary>
        /// <param name="statement">Information Statement</param>
        public static void Debug(string statement)
        {
            if (!isDebugEnable)
            {
                return;
            }

            log4net.Config.XmlConfigurator.Configure();
            Log.Info(statement);
        }
        #endregion

        #region - Error -
        /// <summary>
        /// Logs the Debug into the text file...
        /// </summary>
        /// <param name="statement">Error Statement</param>
        public static void Error(string statement)
        {
            log4net.Config.XmlConfigurator.Configure();
            Log.Error(statement);
        }
        #endregion

        #region - Support Methods -
        /// <summary>
        /// Log on Start of method
        /// </summary>
        /// <param name="className">Class Name</param>
        /// <param name="methodName">Method Name</param>
        /// <param name="param">Input Param</param>
        public static void StartMethod(string className, string methodName, string param = "")
        {
            if (string.IsNullOrEmpty(param))
            {
                string statement = string.Format("[Start]: {0}-{1} ", className, methodName);
                Info(statement);
            }
            else
            {
                string statement = string.Format("[Start]: {0}-{1} with input params: {2}", className, methodName, param);
                Debug(statement);
            }
        }


        /// <summary>
        /// Log on End of method
        /// </summary>
        /// <param name="className">Class Name</param>
        /// <param name="methodName">Method Name</param>
        /// <param name="param">Return Param</param>
        public static void EndMethod(string className, string methodName, string param = "")
        {
            if (string.IsNullOrEmpty(param))
            {
                string statement = string.Format("[End]: {0}-{1} ", className, methodName);
                Info(statement);
            }
            else
            {
                string statement = string.Format("[End]: {0}-{1} with input params: {2}", className, methodName, param);
                Debug(statement);
            }
        }
        #endregion
    }

}
