namespace MettingApp.Models{
    public static class Repository{
        private static List<UserInfo> _users = new();

        static Repository(){
            _users.Add(new UserInfo(){ID = 1,Name="Batuhan Gürbüz", Email = "abc@gmail.com", Phone="1111111", WillAttend=true});

            _users.Add(new UserInfo(){ID = 2,Name="Ahmet Çağlayan", Email = "def@gmail.com", Phone="2222222", WillAttend=false});

            _users.Add(new UserInfo(){ID = 3,Name="Büşra Temuçin", Email = "ghi@gmail.com", Phone="3333333", WillAttend=true});
        }

        public static List<UserInfo> Users{
            get{
                return _users;
            }
        }

        public static void CreateUser(UserInfo user){
            user.ID = Users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id){
            return _users.FirstOrDefault(user => user.ID == id);
        }
    }
}