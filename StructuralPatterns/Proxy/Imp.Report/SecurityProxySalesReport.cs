using Base.Interfaces;
using System;
using System.IO;
using System.Net;

namespace Imp.Report
{
    public class SecurityProxySalesReport : IReport
    {
        /// <summary>
        /// Is the user validated
        /// </summary>
        public bool UserAuthorized { get; private set; }
        /// <summary>
        /// Internal Sales report
        /// </summary>
        private IReport report;
        /// <summary>
        /// message
        /// </summary>
        private string notAuthorizedMessage;
        /// <summary>
        /// Name of Product
        /// </summary>
        public string ProductName { get { return report.ProductName; } }
        /// <summary>
        /// Average Weekly Sales Revenue
        /// </summary>
        public string AverageWeeklySalesRevenue { get { return UserAuthorized ? report.AverageWeeklySalesRevenue : notAuthorizedMessage; } }
        /// <summary>
        /// Profit Year to Date
        /// </summary>
        public string ProfitYTD { get { return UserAuthorized ? report.ProfitYTD : notAuthorizedMessage; } }
        /// <summary>
        /// Percentage of Opportunities converted to Sales
        /// </summary>
        public string PercentageOppToSales { get { return report.PercentageOppToSales; } }
        /// <summary>
        /// 
        /// </summary>
        public string UserName { get; private set; }

        /// <summary>
        /// Ctor with user name and password
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="pswd"></param>
        public SecurityProxySalesReport(string userName, string pswd)
        {
            UserName = userName;
            notAuthorizedMessage = "NOT AUTHORIZED";
            UserAuthorized = AuthorizeUser(userName, pswd);
            report = new SalesReport();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="pswd"></param>
        /// <returns></returns>
        private bool AuthorizeUser(string userName, string pswd)
        {
            string securelyStoredPassword = GetEncryptedPassword(UserName);
            string currentPswd = EncryptThisPswd(pswd);

            bool pswdValidated =  string.Compare(securelyStoredPassword, currentPswd) == 0;

            bool authorized = false;
            if (pswdValidated)
            {
                CredentialCache myCache = new CredentialCache();
                myCache.Add(new Uri("http://www.myorg.com/"), "Basic",
                    new NetworkCredential(UserName, securelyStoredPassword));

                authorized = IsUserAuthorized(securelyStoredPassword);
            }

            return authorized;
        }
        /// <summary>
        /// Fetch the encrpted password from server
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        private string GetEncryptedPassword(string userName)
        {
            // Fetch the encrypted/ encoded password stored on server and return
            return userName;
        }
        /// <summary>
        /// Helper function
        /// </summary>
        /// <param name="pswd"></param>
        /// <returns></returns>
        private string EncryptThisPswd(string pswd)
        {
            return pswd;
        }
        /// <summary>
        /// Check if user has the authorization to view the report
        /// </summary>
        /// <param name="securePswd"></param>
        /// <returns></returns>
        private bool IsUserAuthorized(string securePswd)
        {
            try
            {
                // Create a request for the URL. 		
                WebRequest request = WebRequest.Create("http://www.myorg.com/GetAuth.html");
                // If required by the server, set the credentials.
                request.Credentials = CredentialCache.DefaultCredentials;
                // Get the response.
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                // Get the stream containing content returned by the server.
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Cleanup the streams and the response.
                reader.Close();
                dataStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                // Handle any exceptions
            }
            // Lets assume User authorization detail is a JSON and we fetch the 
            // Authorization level from the JSON
            bool authorized = true;

            return authorized;
        }
    }
}
