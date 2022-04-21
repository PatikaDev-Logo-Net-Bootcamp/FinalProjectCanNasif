using FinalProject.Debugging;

namespace FinalProject
{
    public class FinalProjectConsts
    {
        public const string LocalizationSourceName = "FinalProject";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "f11c339e509248c5914a4d3dba3ca047";
    }
}
