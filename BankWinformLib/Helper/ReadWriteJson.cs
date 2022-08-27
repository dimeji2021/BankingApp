﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BankAppCore.Helper
{
    public class ReadWriteJson : IReadWriteJson
    {
        private readonly string db = Path.Combine(Environment.CurrentDirectory, "db");
        public async Task<bool> WriteJson<T>(T model, string jsonFile)
        {

            try
            {
                string json = JsonConvert.SerializeObject(model) + Environment.NewLine;
                await File.AppendAllTextAsync(db + jsonFile, json);
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<List<T>> ReadJson<T>(string jsonFile)
        {
            var readText = await File.ReadAllTextAsync(db + jsonFile);

            var objects = new List<T>();

            var serializer = new JsonSerializer();

            using (var stringReader = new StringReader(readText))
            using (var jsonReader = new JsonTextReader(stringReader))
            {
                jsonReader.SupportMultipleContent = true;

                while (jsonReader.Read())
                {
                    T json = serializer.Deserialize<T>(jsonReader);

                    objects.Add(json);
                }
            }

            return await Task.FromResult(objects);
        }
        public async Task<bool> UpdateJson<T>(List<T> model, string jsonFile)
        {
            string json = string.Empty;
            foreach (var item in model)
            {
                json += JsonConvert.SerializeObject(item) + Environment.NewLine;
            }
            try
            {
                await File.WriteAllTextAsync(db + jsonFile, json);
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
