namespace structuring_01 {
    public class Game {

        public void GetAchievements() {
            UserRepository repository = UserRepository.Instance;
            User currentUser = repository.GetCurrentUser();
        }
    }
}