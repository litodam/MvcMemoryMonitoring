namespace MvcMemoryMonitoring.App_Start
{
    using System;
    using System.Configuration;

    public class MonitoringConfig
    {
        public static void Register()
        {
            bool appDomainMonitoringEnabled;
            bool.TryParse(ConfigurationManager.AppSettings["AppDomainMonitoringEnabled"], out appDomainMonitoringEnabled);
            
            if (appDomainMonitoringEnabled)
            {
                AppDomain.MonitoringIsEnabled = true;
            }
        }
    }
}