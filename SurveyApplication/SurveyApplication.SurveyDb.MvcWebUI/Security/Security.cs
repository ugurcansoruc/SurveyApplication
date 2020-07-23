using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.DependencyInjection;

namespace SurveyApplication.SurveyDb.MvcWebUI.Security
{
    public class Security:ICipherService
    {
        private readonly IDataProtectionProvider _dataProtectionProvider;

        private const string Key = "cut-the-night-with-the-light";
        public Security(IDataProtectionProvider dataProtectionProvider)
        {
            _dataProtectionProvider = dataProtectionProvider;
        }

        public string Encrypt(string cipherText)
        {
            var protector = _dataProtectionProvider.CreateProtector(Key);
            return protector.Protect(cipherText);
        }

        public string Decrypt(string cipherText)
        {
            var protector = _dataProtectionProvider.CreateProtector(Key);
            return protector.Unprotect(cipherText);
        }

        public static Security CreatLocker()
        {
            var SCollection = new ServiceCollection();
            SCollection.AddDataProtection();
            var LockerKey = SCollection.BuildServiceProvider();
            var locker = ActivatorUtilities.CreateInstance<Security>(LockerKey);
            return locker;
        }


    }
}
