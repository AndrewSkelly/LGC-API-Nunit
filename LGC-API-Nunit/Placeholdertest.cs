using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using FluentAssertions;
using RestSharp;

// Used this for refference https://dev.to/m4rri4nne/nunit-and-c-tutorial-to-automate-your-api-tests-from-scratch-24nf
// Refference for using RestSharp https://restsharp.dev/docs/usage/request
// Convert raw JSON to string https://dadroit.com/json-to-string/

namespace LGC_API_Nunit
{
    public class Placeholdertest
    {

        [Test]
        public void GetPost()
        {
            // Create a new client object using RestClient
            var baseUrl = "https://jsonplaceholder.typicode.com/posts/1";
            RestClient client = new RestClient(baseUrl);

            // Create a request to the PlaceHolder API using Get method
            RestRequest restRequest = new RestRequest(baseUrl, Method.Get);
            // Here the response is handled
            RestResponse restResponse = client.Execute(restRequest);

            // Assert that the response will not be empty
            restResponse.Should().NotBeNull();

            // Assert that the body contains these 3 items
            restResponse.Content.Should().Contain("{\n  \"userId\": 1,\n  \"id\": 1,\n  \"title\": \"sunt aut facere repellat provident occaecati excepturi optio reprehenderit\",\n  \"body\": \"quia et suscipit\\nsuscipit recusandae consequuntur expedita et cum\\nreprehenderit molestiae ut ut quas totam\\nnostrum rerum est autem sunt rem eveniet architecto\"\n}");

            // Should also be a 200 status of OK
            restResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        }
        [Test]
        public void PostPost()
        {
            // Create a new client object using RestClient
            var baseUrl = "https://jsonplaceholder.typicode.com/posts";
            RestClient client = new RestClient(baseUrl);

            // Create new Object from my model
            var body = new PostsModel { Id = 101, Title = "New Car", Body = "Today I bought a new car!" };

            // Create a request to the PlaceHolder API using Get method
            RestRequest restRequest = new RestRequest(baseUrl, Method.Post);
            restRequest.AddBody(body, ContentType.Json); // I tagged on the body object
            // Here the response is handled
            RestResponse restResponse = client.Execute(restRequest);

            // Assert that the body contains the body we sent
            restResponse.Content.Should().Contain("{\n  \"id\": 101,\n  \"title\": \"New Car\",\n  \"body\": \"Today I bought a new car!\"\n}");

            // Should also be a 201 status of Created
            restResponse.StatusCode.Should().Be(HttpStatusCode.Created);
        }
        [Test]
        public void PutPost()
        {
            // Create a new client object using RestClient
            var baseUrl = "https://jsonplaceholder.typicode.com/posts/1";
            RestClient client = new RestClient(baseUrl);

            // Create new Object from my model
            var body = new PostsModel { Title = "Update on car", Body = "The car broke down!" };


            // Create a request to the PlaceHolder API using Get method
            RestRequest restRequest = new RestRequest(baseUrl, Method.Put);
            restRequest.AddBody(body, ContentType.Json); // I tagged on the body object
            // Here the response is handled
            RestResponse restResponse = client.Execute(restRequest);

            // Assert that the body contains the body we sent
            restResponse.Content.Should().Contain("{\n  \"id\": 1,\n  \"title\": \"Update on car\",\n  \"body\": \"The car broke down!\"\n}");

            // Assert that the response will not be empty
            restResponse.Should().NotBeNull();
            // restResponse.Should().Be();
            // Should also be a 200 status of OK
            restResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        }
        [Test]
        public void DeletePost()
        {
            // Create a new client object using RestClient
            var baseUrl = "https://jsonplaceholder.typicode.com/posts/1";
            RestClient client = new RestClient(baseUrl);

            // Create a request to the PlaceHolder API using Get method
            RestRequest restRequest = new RestRequest(baseUrl, Method.Delete);
            // Here the response is handled
            RestResponse restResponse = client.Execute(restRequest);

            Console.WriteLine(restResponse);

            // Assert that the response is Null or Empty
            restResponse.Content.Should().Be("{}");
            // Should also be a 200 status of OK
            restResponse.StatusCode.Should().Be(HttpStatusCode.OK);

        }
    }
}
