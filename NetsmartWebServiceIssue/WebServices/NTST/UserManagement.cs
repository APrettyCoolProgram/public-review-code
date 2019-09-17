// ====================================================================================================================
//    FILENAME: UserManagement.cs
//       BUILD: 20190909
//     PROJECT: Avatool (https://github.com/APrettyCoolProgram/Avatool)
//     AUTHORS: development@aprettycoolprogram.com
//   COPYRIGHT: Copyright 2019 A Pretty Cool Program
//     LICENSE: Apache License, Version 2.0
// ====================================================================================================================

/* Netsmart Avatar User Management Web Service.
 */
namespace Avatool
{
    public class UserManagement
    {
        public static string DoesUserExistInUat()
        {
            var sysCode = "LIVE";
            var user    = "SYSADM";
            var pass    = "THEPASSWORD";
            var ausr    = "THEUSER";

            var checkUserExist = new NTSTWebSvcUserManagementUAT.WebServicesSoapClient();
            var existResponse = checkUserExist.DoesUserExist(sysCode, user, pass, ausr);
            return existResponse.Message;
        }


    }
}