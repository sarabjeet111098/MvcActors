using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActorsApp.Models;

namespace ActorsApp.Services
{
    public class InMemomryActorsService
    {
        private readonly List<Actor> actors= new List<Actor>()
        {
            new Actor(){Id =1 , StageName = "Chulbul" , FirstName = "Chulbul" , LastName = "Pandey", Age = 31 , Image = "https://m.media-amazon.com/images/I/81lLB8bcENL._SL1500_.jpg"  , Description="UP Cop" , BestMovie = "Dabangg"},
            new Actor(){Id =2 , StageName = "Radhey" , FirstName = "Radhey" , LastName = "Mohan", Age = 25 , Image = "https://th.bing.com/th/id/OIP.LtL2PR6rAnucnng0Qk0CgQHaEH?w=264&h=186&c=7&r=0&o=5&dpr=1.5&pid=1.7"  , Description="College Student and Hopeless Romantic" , BestMovie = "Tere Naam"},
            new Actor(){Id =3 , StageName = "Love Guru" , FirstName = "Prem" , LastName = "Na", Age = 28 , Image = "https://i.pinimg.com/originals/9e/c1/fa/9ec1fa81c734e274da84d3434bccbb8d.jpg"  , Description="Love Teacher" , BestMovie = "Partner"},
            new Actor(){Id =4 , StageName = "Tiger" , FirstName = "Avinash" , LastName = "Singh", Age = 30 , Image = "https://th.bing.com/th/id/R.263d9b167073fa576dc3bf9ad34ee6ad?rik=FF6DFs%2fwQ%2fiw9Q&riu=http%3a%2f%2fbollyworm.com%2fwp-content%2fuploads%2f2017%2f10%2fTiger-Zinda-Hai-1-1-1024x775.jpg&ehk=kiC2Q%2fmvBPARuRTqX8bF6LDDwj5MIaQGu4ecpzzyON0%3d&risl=&pid=ImgRaw&r=0"  , Description="Indian Raw Spy" , BestMovie = "Tiger Zinda Hai"},
            new Actor(){Id =5 , StageName = "Radhey" , FirstName = "Rajveer" , LastName = "Shekhawat", Age = 29 , Image = "https://upload.wikimedia.org/wikipedia/en/thumb/2/26/Wanted7.jpg/220px-Wanted7.jpg"  , Description="Under Cover IPS" , BestMovie = "Wanted"},
            new Actor(){Id =6 , StageName = "Sultan" , FirstName = "Sultan" , LastName = "Khan", Age = 34 , Image = "https://images.indianexpress.com/2016/07/salman-khan-sultan-759.jpg?w=389"  , Description="Wrestler" , BestMovie = "Sultan"}
        };
       public List<Actor> GetAllActors(){
            return actors;
        }
        
    }
}