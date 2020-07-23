using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyApplication.SurveyDb.MvcWebUI.Security
{
    public interface ICipherService
    {
        string Encrypt(string cipherText);
        string Decrypt(string cipherText);

    }
}
