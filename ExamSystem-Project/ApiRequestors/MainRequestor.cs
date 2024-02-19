using ExamSystem_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExamSystem_Project.ApiRequestors
{
    public class MainRequestor
    {
        bool isOkResponse;
        List<object> objResponse;

        readonly HttpClient httpClient;


        public MainRequestor() : this("https://localhost:7076/")
        {
            isOkResponse = false;
        }
        public MainRequestor(string apiUrl)
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(apiUrl);
        }

        public async Task<bool> Request_NewPost<T>(T obj, string apiStr)
        {
            try
            {
                string jsonData = JsonSerializer.Serialize<T>(obj);

                using StringContent dataContent = new StringContent(jsonData, Encoding.UTF8, @"application/json");

                using HttpResponseMessage response = await httpClient.PostAsync(apiStr, dataContent);

                response.EnsureSuccessStatusCode(); // 201

                // Get Json Data From Server Result
                bool isOkResponse = await response.Content.ReadFromJsonAsync<bool>();

                return isOkResponse;
            }
            catch (Exception ex)
            {

                throw;
            }



            //bool resultExam = await Request_NewPost<Exam>(examObject, "yourApiEndpoint");
            //bool resultQuestion = await Request_NewPost<Question>(questionObject, "yourApiEndpoint");
            //bool resultOptionAns = await Request_NewPost<OptionAns>(optionAnsObject, "yourApiEndpoint");
           // bool resultUser = await Request_NewPost<User>(userObject, string apiStr);

        }


        public async Task<T> Request_GetById<T>(string strId, string apiStr)
        {
            try
            {
                using HttpResponseMessage response = await httpClient.GetAsync($"{apiStr}/{strId}");

                response.EnsureSuccessStatusCode(); // 201

                // Get Json Data From Server Result
                T obj = await response.Content.ReadFromJsonAsync<T>();

                return obj;
            }
            catch (Exception)
            {

                throw;
            }



            //Exam exam = await Request_GetById<Exam>("yourId", "yourApiEndpoint");
            //Question question = await Request_GetById<Question>("yourId", "yourApiEndpoint");
            //OptionAns optionAns = await Request_GetById<OptionAns>("yourId", "yourApiEndpoint");
            //User user = await Request_GetById<User>("yourId", "yourApiEndpoint");
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

        public async Task<List<T>> Request_GetAll<T>(string apiStr)
        {
            try
            {
                // Get response
                using HttpResponseMessage response = await httpClient.GetAsync(apiStr);

                response.EnsureSuccessStatusCode(); // 201



                // Get Json Data From Server Result
                List<T> objList = await response.Content.ReadFromJsonAsync<List<T>>();


                //List<Exam> exams = await Request_GetAll<Exam>("yourApiEndpoint");
                //List<Question> questions = await Request_GetAll<Question>("yourApiEndpoint");
                //List<OptionAns> optionAnswers = await Request_GetAll<OptionAns>("yourApiEndpoint");
                //List<User> users = await Request_GetAll<User>("yourApiEndpoint");


                return objList;
            }
            catch (Exception)
            {
                 throw; // Return false in case of an exception.
            }
        }



        public async Task<bool> Request_Put<T>( T obj, string apiStr)
        {
            try
            {
                string jsonData = JsonSerializer.Serialize<T>(obj);

                using StringContent dataContent = new StringContent(jsonData, Encoding.UTF8, @"application/json");

                using HttpResponseMessage response = await httpClient.PutAsync(apiStr, dataContent);

                response.EnsureSuccessStatusCode(); // 200 OK

                // Get Json Data From Server Result
                bool isOkResponse = await response.Content.ReadFromJsonAsync<bool>();

                return isOkResponse;
            }
            catch (Exception ex)
            {
                // Log exception details or throw a custom exception
                // Log.Error(ex, "An error occurred in Request_Put.");
                throw;
            }



            //Exam updatedExam = await Request_Put<Exam>(examObject, "yourId", "yourApiEndpoint");
            //Question updatedQuestion = await Request_Put<Question>(questionObject, "yourId", "yourApiEndpoint");
            //OptionAns updatedOptionAns = await Request_Put<OptionAns>(optionAnsObject, "yourId", "yourApiEndpoint");
            //User updatedUser = await Request_Put<User>(userObject, "yourId", "yourApiEndpoint");

        }


        public async Task<bool> Request_Delete(string strId, string apiStr)
        {
            try
            {
                using HttpResponseMessage response = await httpClient.DeleteAsync($"{apiStr}/{strId}");

                response.EnsureSuccessStatusCode(); // 200 OK

                // Get Json Data From Server Result
                bool isOkResponse = await response.Content.ReadFromJsonAsync<bool>();

                return isOkResponse;
            }
            catch (Exception ex)
            {
                // Log exception details or throw a custom exception
                // Log.Error(ex, "An error occurred in Request_Delete.");
                throw;
            }


            //bool resultDelete = await Request_Delete("yourId", "yourApiEndpoint");

        }

    }
}
