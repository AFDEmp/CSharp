using System.Linq;

namespace structuring_01 {
    public class UserRepository {

        private User currentUser;

        private static UserRepository _instance = null;
        public static UserRepository Instance {
            get {
                if (_instance == null) {
                    _instance = new UserRepository();
                }
                return _instance;
            }    
        }

        private UserRepository() { }

        public bool Login(string username, string password) {
            using(var db = new DbContext()) {
                currentUser = db.Users.Where(x => x.Username == username && x.Password == password).SingleOrDefault();
                return IsLoggedIn();
            }
        }

        public User GetCurrentUser() {
            return currentUser;
        }

        public bool IsLoggedIn() {
            if (currentUser != null) {
                return true;
            }
            else {
                return false;
            }
        }

        public void Logout() {
            currentUser = null;
        }
    }
}