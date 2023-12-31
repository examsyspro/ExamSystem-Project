using ExamSystem_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExamSystem_Project.ApiRequestors
{
    public class UserRequestor
    {
        bool isOkResponse;
        List<User> usersResponse;

        readonly HttpClient httpClient;
        public UserRequestor() : this("https://localhost:7076/")
        {
            isOkResponse = false;
            usersResponse = new List<User>();
        }
        public UserRequestor(string apiUrl)
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(apiUrl);
        }
        public async Task<User> Request_LoginAsync(User credentials)
        {
            try
            {
                //3.1) Convert credentials Object to JSON
                string jsonLoginData = JsonSerializer.Serialize<User>(credentials);
                using StringContent LoginContent = new StringContent(jsonLoginData, Encoding.UTF8, @"application/json");

                //3.2 Get response 
                using HttpResponseMessage response =
                    await httpClient.PostAsync("api/users/login", LoginContent);

                response.EnsureSuccessStatusCode();//201

                //3.3 Get Json Data From Server Result
                User userResponse =
                    await response.Content.ReadFromJsonAsync<User>();

                return userResponse;
            }
            catch (Exception ex)
            {
                return null;
            }

        }


        public async Task<bool> Request_RegisterAsync(User credentials)
        {
            try
            {
                //3.1) Convert credentials Object to JSON
                string jsonRegisterData = JsonSerializer.Serialize<User>(credentials);
                using StringContent RegisterContent = new StringContent(jsonRegisterData, Encoding.UTF8, @"application/json");

                //3.2 Get response 
                using HttpResponseMessage response =
                    await httpClient.PostAsync("api/users/register", RegisterContent);

                response.EnsureSuccessStatusCode();//201

                //3.3 Get Json Data From Server Result
                isOkResponse =
                   await response.Content.ReadFromJsonAsync<bool>();

                return isOkResponse;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public async Task<bool> Request_ExistingUser(string id)
        {
            try
            {



                // Get response
                using HttpResponseMessage response = await httpClient.GetAsync($"api/users/{id}");

                response.EnsureSuccessStatusCode(); // 201

                // Get Json Data From Server Result
                isOkResponse = await response.Content.ReadFromJsonAsync<bool>();

                return isOkResponse;
            }
            catch (Exception ex)
            {
                return false; // Return false in case of an exception.
            }
        }
        public async Task<List<User>> Request_GetAllUsers()
        {
            try
            {



                // Get response
                using HttpResponseMessage response = await httpClient.GetAsync($"api/users/getallusers");

                response.EnsureSuccessStatusCode(); // 201

                // Get Json Data From Server Result
                usersResponse = await response.Content.ReadFromJsonAsync<List<User>>();

                return usersResponse;
            }
            catch (Exception ex)
            {
                return usersResponse; // Return false in case of an exception.
            }
        }

    }
}
