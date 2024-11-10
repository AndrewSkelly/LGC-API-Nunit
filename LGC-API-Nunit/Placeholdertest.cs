using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using FluentAssertions;
using RestSharp;

// Used this for refference https://dev.to/m4rri4nne/nunit-and-c-tutorial-to-automate-your-api-tests-from-scratch-24nf


namespace LGC_API_Nunit
{
    public class Placeholdertesr
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

            Console.WriteLine(restResponse);

            // Assert that the response will not be empty
            restResponse.Should().NotBeNull();
            // restResponse.Should().Be();
            // Should also be a 200 status of OK
            restResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        }
        [Test]
        public void PostPost()
        {
            // Create a new client object using RestClient
            var baseUrl = "https://jsonplaceholder.typicode.com/posts/1";
            RestClient client = new RestClient(baseUrl);

            // Create a request to the PlaceHolder API using Get method
            RestRequest restRequest = new RestRequest(baseUrl, Method.Get);
            // Here the response is handled
            RestResponse restResponse = client.Execute(restRequest);

            Console.WriteLine(restResponse);

            // Assert that the response will not be empty
            restResponse.Should().NotBeNull();
            // restResponse.Should().Be();
            // Should also be a 200 status of OK
            restResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        }
        [Test]
        public void PutPost()
        {
            // Create a new client object using RestClient
            var baseUrl = "https://jsonplaceholder.typicode.com/posts/1";
            RestClient client = new RestClient(baseUrl);

            // Create a request to the PlaceHolder API using Get method
            RestRequest restRequest = new RestRequest(baseUrl, Method.Get);
            // Here the response is handled
            RestResponse restResponse = client.Execute(restRequest);

            Console.WriteLine(restResponse);

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
            RestRequest restRequest = new RestRequest(baseUrl, Method.Get);
            // Here the response is handled
            RestResponse restResponse = client.Execute(restRequest);

            Console.WriteLine(restResponse);

            // Assert that the response will not be empty
            restResponse.Should().NotBeNull();
            // restResponse.Should().Be();
            // Should also be a 200 status of OK
            restResponse.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
