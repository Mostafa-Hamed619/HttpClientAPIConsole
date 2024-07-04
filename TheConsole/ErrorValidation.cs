using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TheConsole
{
     class ErrorValidation
    {
        public static Dictionary<string, List<string>> ExtractErrorFromWebAPIResponse(string body)
        {
            var response = new Dictionary<string, List<string>>();

            var JsonElement = JsonSerializer.Deserialize<JsonElement>(body);

            var errorElement = JsonElement.GetProperty("errors");

            foreach (var fieldWithErrors in errorElement.EnumerateObject())
            {
                var field = fieldWithErrors.Name;
                var errors = new List<string>();

                foreach (var errorKind in fieldWithErrors.Value.EnumerateArray())
                {
                    errors.Add(errorKind.ToString());
                }

                response.Add(field, errors);
            }
            return response;
        }
    }
}