using System.Collections.Generic;

namespace Dps {
    public class User {
        public string Key { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
    }

    public interface IUserRepository {
        void Add(User user);
        IEnumerable<User> GetAll();
    }
}