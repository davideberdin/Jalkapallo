using System;
using System.Diagnostics;
using System.IO;
using Microsoft.WindowsAzure.Diagnostics;
using Microsoft.WindowsAzure.ServiceRuntime;

namespace JalkapalloWebRole
{
	public class AzureLocalStorageTraceListener : XmlWriterTraceListener
	{
		public AzureLocalStorageTraceListener()
			: base(Path.Combine(AzureLocalStorageTraceListener.GetLogDirectory().Path, "JalkapalloWebRole.svclog"))
		{
		}

		public static DirectoryConfiguration GetLogDirectory()
		{
			DirectoryConfiguration directory = new DirectoryConfiguration();
			directory.Container = "wad-tracefiles";
			directory.DirectoryQuotaInMB = 10;
			directory.Path = RoleEnvironment.GetLocalResource("JalkapalloWebRole.svclog").RootPath;
			return directory;
		}
	}
}
