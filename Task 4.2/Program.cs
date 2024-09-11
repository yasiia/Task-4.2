using static Task_4._2.Program;

namespace Task_4._2
{
    internal class Program
    {
        public class User
        {
            public string name;
            public string email;
            public string nickname;
            public List<Post> posts;
            public User(string name, string email, string nickname)
            {
                this.name = name;
                this.email = email;
                this.nickname = nickname;
                this.posts = new List<Post>();
            }
            public void AddPost(string date, string text) 
            {
                Post post = new Post(date, text);
                posts.Add(post);
                Console.WriteLine("You created a new post");
                Console.WriteLine(posts);
            }
            public void RemovePost(string date, string text)
            {
                if (posts.Count > 0)
                {
                    posts.RemoveAt(posts.Count-1);
                }
                Console.WriteLine("You deleted a post");
                
            }
            public void ShowPosts() 
            {
                foreach (Post post in posts) 
                {
                    Console.WriteLine($"Post:{post.date}:{post.text}.Likes:{post.likes}. Comments:{post.comments}");
                
                }
            }

        }
        public class Post
        {
            public string date;
            public string text;
            public int likes;
            public List<string> comments;
            public Post(string date, string text)
            {
                this.date = date;
                this.text = text;
                this.likes = 0;
                this.comments = new List<string>();
            }
        }
        static void Like(Post posts)
        {
            posts.likes++;
            Console.WriteLine("You liked this post");

        }
        static void Commets(Post posts)
        {
            Console.WriteLine("Enter your comment:");
            string comment = Console.ReadLine();
            posts.comments.Add(comment);
            Console.WriteLine("You added a comment.");

        }
       
        static void Main(string[] args)
        {
            User[] users = new User[]
            {
                new User("user1", "user1.email.com","@usernick1"),
                new User("user2", "user2.email.com","@usernick2"),
                new User("user3", "user3.email.com","@usernick3"),
                new User("user4", "user4.email.com","@usernick4"),
                new User("user5", "user5.email.com","@usernick5"),
                new User("user6", "user6.email.com","@usernick6")
            };
            users[0].AddPost("12.02.2024", "First post");
            users[0].AddPost("18.02.2024", "Second post");
            users[0].AddPost("20.03.2024", "Third post");
            users[1].AddPost("06.11.2023", "Hello");
            users[1].AddPost("22.06.2024", "Second post");
            users[2].AddPost("12.02.2020", "First post");
            users[2].AddPost("05.08.2022", "Second post");
            users[2].AddPost("01.03.2023", "Third post");
            users[2].AddPost("05.09.2024", "Fourth post");
            users[2].AddPost("10.09.2024", "Fifth post");
            users[3].AddPost("11.06.2019", "First post");
            users[3].AddPost("10.12.2021", "Hello!");
            users[3].AddPost("11.02.2022", "Third post");
            users[3].AddPost("10.12.2023", "Fourth post");
            users[3].AddPost("05.09.2024", "Fifth post");
            users[4].AddPost("23.02.2018", "First post");
            users[4].AddPost("26.04.2019", "Hello!");
            users[4].AddPost("05.09.2020", "third post");
            users[5].AddPost("17.10.2019", "It's my cat");
            users[5].AddPost("20.02.2021", "Second post");
            users[5].AddPost("25.08.2022", "Third post");
            users[5].AddPost("12.02.2024", "Fouth post");

            Like(users[0].posts[0]);
            Like(users[0].posts[0]);
            Like(users[1].posts[1]);
            Like(users[1].posts[1]);
            Like(users[2].posts[0]);
            Like(users[2].posts[0]);
            Like(users[2].posts[0]);
            Like(users[2].posts[2]);
            Like(users[3].posts[0]);
            Like(users[3].posts[0]);
            Like(users[3].posts[1]);
            Like(users[3].posts[2]);
            Like(users[3].posts[2]);
            Like(users[3].posts[2]);
            Like(users[4].posts[0]);
            Like(users[4].posts[0]);
            Like(users[4].posts[1]);
            Like(users[4].posts[2]);
            Like(users[4].posts[1]);
            Like(users[4].posts[2]);
            Like(users[5].posts[0]);
            Like(users[5].posts[0]);
            Like(users[5].posts[1]);
            Like(users[5].posts[2]);

            Commets(users[2].posts[1]);
            Commets(users[2].posts[0]);


            users[2].ShowPosts();




        }
    }
}
