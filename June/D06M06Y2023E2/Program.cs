using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class Program {
  public static async Task Main() {
    // Create a list of users
    List<User> users = new List<User>();

    // Make a request to the JSONPlaceholder API for user data
    HttpClient client = new HttpClient();
    HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/users");
    if (response.IsSuccessStatusCode) {
      string jsonString = await response.Content.ReadAsStringAsync();
      users = JsonSerializer.Deserialize<List<User>>(jsonString);
    }

    // Create a list of posts
    List<Post> posts = new List<Post>();

    // Make a request to the JSONPlaceholder API for post data
    response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts");
    if (response.IsSuccessStatusCode) {
      string jsonString = await response.Content.ReadAsStringAsync();
      posts = JsonSerializer.Deserialize<List<Post>>(jsonString);
    }

    // Create a dictionary to group posts by user
    Dictionary<int, List<Post>> userPosts = new Dictionary<int, List<Post>>();
    foreach (User user in users) {
      userPosts[user.Id] = new List<Post>();
    }
    foreach (Post post in posts) {
      userPosts[post.UserId].Add(post);
    }

    // Print out each user and their posts
    foreach (User user in users) {
      Console.WriteLine($"{user.Name}:");
      foreach (Post post in userPosts[user.Id]) {
        Console.WriteLine($"- {post.Title}");
      }
      Console.WriteLine();
    }
  }
}

public class User {
  public int Id { get; set; }
  public string Name { get; set; }
  public string Email { get; set; }
}

public class Post {
  public int UserId { get; set; }
  public int Id { get; set; }
  public string Title { get; set; }
  public string Body { get; set; }
}
