using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using LogInClientApp.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace LogInClientApp.Data
{
    public class ApiRequest
    {

        public async Task ValidateCredentials(AppClientCredentials credentials)
        {
            var url = "https://loginapi20201022064042.azurewebsites.net/api/client/credentials";
            var credentialsJson = JsonSerializer.Serialize(credentials);

            using (var response = await ApiHttp.Client.PostAsync(url,
                new StringContent(credentialsJson, Encoding.UTF8, "application/json")))
            {
                if (response.IsSuccessStatusCode)
                {
                    string token = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(token, "logged in succesfully");
                }
                else
                {
                    MessageBox.Show("Wrong Nick or PassCode", "error");
                }
            }
        }

        public async Task CreateAppClientAccount(AppClient appClient)
        {
            var url = "https://loginapi20201022064042.azurewebsites.net/api/client/";
            var appClientJson = JsonSerializer.Serialize(appClient);

            using (var response = await ApiHttp.Client.PostAsync(url,
                new StringContent(appClientJson, Encoding.UTF8, "application/json")))
            {
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Account Created Successfully", "Success");
                }
                else
                {
                    MessageBox.Show("Nick or Email Address is taken", "error");
                }
            }

        }
    }

}
