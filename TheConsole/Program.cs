using AspNetTopics.Models;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using TheConsole;

var url = "http://localhost:5241/api/villa/users";
var urlAdd = "http://localhost:5241/api/villa/Add-user";
var urlExample1 = "http://localhost:5241/api/villaget-villa/";
var deleteUrl = "http://localhost:5241/api/villa";
JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
using(var client = new HttpClient()) // we are using statement because HttpClient class is inheriting from IDisposal
{

    #region Get Method
    //using var response = await client.GetAsync(url); // get all about the response of status code, body, header and others.
    //response.EnsureSuccessStatusCode();
    //var responseBody = await client.GetStringAsync(url); // get only the body.

    //if (response.IsSuccessStatusCode)
    //{
    //    var responseString = await response.Content.ReadAsStringAsync();

    //    var deserializedResponse = JsonSerializer.Deserialize<List<LocalUser>>(responseString, jsonSerializerOptions
    //        );
    //    foreach (var i in deserializedResponse)
    //    {
    //        Console.WriteLine(i.UserName + "--" + i.Email + "--" + i.Id);
    //    }

    //}

    // for using a specific result for each statuscode using switch
    //switch (response.StatusCode)
    //{
    //    case System.Net.HttpStatusCode.Continue:
    //        break;
    //    case System.Net.HttpStatusCode.SwitchingProtocols:
    //        break;
    //    case System.Net.HttpStatusCode.Processing:
    //        break;
    //    case System.Net.HttpStatusCode.EarlyHints:
    //        break;
    //    case System.Net.HttpStatusCode.OK:
    //        break;
    //    case System.Net.HttpStatusCode.Created:
    //        break;
    //    case System.Net.HttpStatusCode.Accepted:
    //        break;
    //    case System.Net.HttpStatusCode.NonAuthoritativeInformation:
    //        break;
    //    case System.Net.HttpStatusCode.NoContent:
    //        break;
    //    case System.Net.HttpStatusCode.ResetContent:
    //        break;
    //    case System.Net.HttpStatusCode.PartialContent:
    //        break;
    //    case System.Net.HttpStatusCode.MultiStatus:
    //        break;
    //    case System.Net.HttpStatusCode.AlreadyReported:
    //        break;
    //    case System.Net.HttpStatusCode.IMUsed:
    //        break;
    //    case System.Net.HttpStatusCode.Ambiguous:
    //        break;
    //    case System.Net.HttpStatusCode.Moved:
    //        break;
    //    case System.Net.HttpStatusCode.Found:
    //        break;
    //    case System.Net.HttpStatusCode.RedirectMethod:
    //        break;
    //    case System.Net.HttpStatusCode.NotModified:
    //        break;
    //    case System.Net.HttpStatusCode.UseProxy:
    //        break;
    //    case System.Net.HttpStatusCode.Unused:
    //        break;
    //    case System.Net.HttpStatusCode.RedirectKeepVerb:
    //        break;
    //    case System.Net.HttpStatusCode.PermanentRedirect:
    //        break;
    //    case System.Net.HttpStatusCode.BadRequest:
    //        break;
    //    case System.Net.HttpStatusCode.Unauthorized:
    //        break;
    //    case System.Net.HttpStatusCode.PaymentRequired:
    //        break;
    //    case System.Net.HttpStatusCode.Forbidden:
    //        break;
    //    case System.Net.HttpStatusCode.NotFound:
    //        break;
    //    case System.Net.HttpStatusCode.MethodNotAllowed:
    //        break;
    //    case System.Net.HttpStatusCode.NotAcceptable:
    //        break;
    //    case System.Net.HttpStatusCode.ProxyAuthenticationRequired:
    //        break;
    //    case System.Net.HttpStatusCode.RequestTimeout:
    //        break;
    //    case System.Net.HttpStatusCode.Conflict:
    //        break;
    //    case System.Net.HttpStatusCode.Gone:
    //        break;
    //    case System.Net.HttpStatusCode.LengthRequired:
    //        break;
    //    case System.Net.HttpStatusCode.PreconditionFailed:
    //        break;
    //    case System.Net.HttpStatusCode.RequestEntityTooLarge:
    //        break;
    //    case System.Net.HttpStatusCode.RequestUriTooLong:
    //        break;
    //    case System.Net.HttpStatusCode.UnsupportedMediaType:
    //        break;
    //    case System.Net.HttpStatusCode.RequestedRangeNotSatisfiable:
    //        break;
    //    case System.Net.HttpStatusCode.ExpectationFailed:
    //        break;
    //    case System.Net.HttpStatusCode.MisdirectedRequest:
    //        break;
    //    case System.Net.HttpStatusCode.UnprocessableEntity:
    //        break;
    //    case System.Net.HttpStatusCode.Locked:
    //        break;
    //    case System.Net.HttpStatusCode.FailedDependency:
    //        break;
    //    case System.Net.HttpStatusCode.UpgradeRequired:
    //        break;
    //    case System.Net.HttpStatusCode.PreconditionRequired:
    //        break;
    //    case System.Net.HttpStatusCode.TooManyRequests:
    //        break;
    //    case System.Net.HttpStatusCode.RequestHeaderFieldsTooLarge:
    //        break;
    //    case System.Net.HttpStatusCode.UnavailableForLegalReasons:
    //        break;
    //    case System.Net.HttpStatusCode.InternalServerError:
    //        break;
    //    case System.Net.HttpStatusCode.NotImplemented:
    //        break;
    //    case System.Net.HttpStatusCode.BadGateway:
    //        break;
    //    case System.Net.HttpStatusCode.ServiceUnavailable:
    //        break;
    //    case System.Net.HttpStatusCode.GatewayTimeout:
    //        break;
    //    case System.Net.HttpStatusCode.HttpVersionNotSupported:
    //        break;
    //    case System.Net.HttpStatusCode.VariantAlsoNegotiates:
    //        break;
    //    case System.Net.HttpStatusCode.InsufficientStorage:
    //        break;
    //    case System.Net.HttpStatusCode.LoopDetected:
    //        break;
    //    case System.Net.HttpStatusCode.NotExtended:
    //        break;
    //    case System.Net.HttpStatusCode.NetworkAuthenticationRequired:
    //        break;
    //    default:
    //        break;
    //}
    #endregion

    #region Post Method

    // Example 1
    //var user = new LocalUser() { Email = "Fabi@gmail.com", Password = "Nepo", Role = "User", UserName = "Fabi" };
    //var postResponse = await client.PostAsJsonAsync(urlAdd, user);

    //if (response.IsSuccessStatusCode)
    //{
    //    var id = await postResponse.Content.ReadAsStringAsync();
    //    Console.WriteLine("id is " + id);
    //}

    // Example 2
    //var newUser = new LocalUser() { Email = "TigeanPetrosian@gmail.com", Password = "Magnus@21", Role = "Admin", UserName = "Magnus" };
    //var newUserSerialized = JsonSerializer.Serialize(newUser);
    //var stringContent = new StringContent(newUserSerialized, Encoding.UTF8, "application/json");
    //var Postresponse2 = await client.PostAsync(urlAdd, stringContent);

    //var people = JsonSerializer.Deserialize<List<LocalUser>>(await client.GetStringAsync(url), jsonSerializerOptions);

    //foreach(var i in people)
    //{
    //    Console.WriteLine(i.Email);
    //}


    // Example 3 (validation)

    //var newPerson = new LocalUser();
    //var newPersonResponse = await client.PostAsJsonAsync(urlAdd, newPerson);
    //if (!newPersonResponse.IsSuccessStatusCode)
    //{
    //    var body = await newPersonResponse.Content.ReadAsStringAsync();
    //    var Errors = ErrorValidation.ExtractErrorFromWebAPIResponse(body);
    //    foreach(var error in Errors)
    //    {
    //        Console.WriteLine($"{error.Key}--");

    //        foreach(var errorValue in error.Value)
    //        {
    //            Console.WriteLine($"\t{errorValue}");
    //        }
    //    }
    //}
    #endregion

    #region Sending Values Through Http Headers
    //using(var requestMessage = new HttpRequestMessage(HttpMethod.Get, urlExample1))
    //{
    //    requestMessage.Headers.Add("Name", "2");
    //    var requestExmaple1 = await client.SendAsync(requestMessage);
    //    var response = await requestExmaple1.Content.ReadAsStringAsync();
    //    var responseExample1Deserialized = JsonSerializer.Deserialize<List<Villa>>(await requestExmaple1.Content.ReadAsStringAsync()
    //        , jsonSerializerOptions);

    //    Console.WriteLine($"the Name of the Local user is {responseExample1Deserialized.Count}");
    //}

    #endregion

    #region Delete Method
   
   
    while (true)
    {
        var users = await client.GetAsync(url);
        var userResponse = await users.Content.ReadAsStringAsync();

        var userDeserializer = JsonSerializer.Deserialize<List<LocalUser>>(userResponse, jsonSerializerOptions);

        foreach (var user in userDeserializer)
        {
            Console.WriteLine(user.UserName+" ---- "+user.Id);
        }
        Console.WriteLine("get the number to be deleted");
        int id = int.Parse(Console.ReadLine());
        await client.DeleteAsync($"{deleteUrl}/{id}");
        var people = await client.GetFromJsonAsync<List<LocalUser>>(deleteUrl);
    }
  
    #endregion
}