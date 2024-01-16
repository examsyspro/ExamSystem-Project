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

        public async Task<bool> Request_NewPost(object obj, string apiStr, EnumModel enumModel)
        {
            try
            {
                string jsonData = string.Empty;
                //3.1) Convert credentials Object to JSON

                switch (enumModel)
                {
                    case EnumModel.Exam:
                        jsonData = JsonSerializer.Serialize<Exam>((Exam)obj);
                        break;
                    case EnumModel.Question:
                        jsonData = JsonSerializer.Serialize<Question>((Question)obj);
                        break;
                    case EnumModel.OptionAns:
                        jsonData = JsonSerializer.Serialize<OptionAns>((OptionAns)obj);
                        break;
                    default:
                        break;
                }

                using StringContent dataContent = new StringContent(jsonData, Encoding.UTF8, @"application/json");


                using HttpResponseMessage response =
                    await httpClient.PostAsync(apiStr, dataContent);

                response.EnsureSuccessStatusCode();//201

                //3.3 Get Json Data From Server Result
                isOkResponse =
              await response.Content.ReadFromJsonAsync<bool>();

                return isOkResponse;
            }
            catch (Exception ex)
            {
                return isOkResponse;
            }
        }


        public async Task<object> Request_GetById(string strId, string apiStr, EnumModel enumModel)
        {
            try
            {

                using HttpResponseMessage response = await httpClient.GetAsync($"{apiStr}/{strId}");

                response.EnsureSuccessStatusCode(); // 201

                // Get Json Data From Server Result
                var obj = new object();
                switch (enumModel)
                {
                    case EnumModel.Exam:
                        obj = await response.Content.ReadFromJsonAsync<Exam>();

                        break;
                    case EnumModel.Question:
                        obj = await response.Content.ReadFromJsonAsync<Question>();
                        break;
                    case EnumModel.OptionAns:
                        obj = await response.Content.ReadFromJsonAsync<OptionAns>();
                        break;
                    case EnumModel.User:
                        obj = await response.Content.ReadFromJsonAsync<User>();
                        break;
                    default:
                        obj = await response.Content.ReadFromJsonAsync<object>();
                        break;
                }


                return obj;
            }
            catch (Exception)
            {
                return new object(); // Return false in case of an exception.
            }
        }



        public async Task<List<object>> Request_GetAll(string apiStr, EnumModel enumModel)
        {
            try
            {
                // Get response
                using HttpResponseMessage response = await httpClient.GetAsync($"{apiStr}/getall");

                response.EnsureSuccessStatusCode(); // 201



                // Get Json Data From Server Result
                //List<object> objList = new List<object>();
                var objList = new object();
                switch (enumModel)
                {
                    case EnumModel.Exam:
                        objList = await response.Content.ReadFromJsonAsync<List<Exam>>();
                        break;
                    case EnumModel.Question:
                        objList = await response.Content.ReadFromJsonAsync<List<Question>>();

                        break;
                    case EnumModel.OptionAns:
                        objList = await response.Content.ReadFromJsonAsync<List<OptionAns>>();

                        break;
                    case EnumModel.User:
                        objList = await response.Content.ReadFromJsonAsync<List<User>>();

                        break;
                    default:
                        objList = await response.Content.ReadFromJsonAsync<object>();
                        break;
                }




                return objList;
            }
            catch (Exception ex)
            {
                return objList; // Return false in case of an exception.
            }
        }


    }
    public enum EnumModel
    {
        Exam,
        Question,
        OptionAns,
        User
    }
}
