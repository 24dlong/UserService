using HotChocolate.ApolloFederation.Resolvers;
using HotChocolate.ApolloFederation.Types;
using UserService.Data;

namespace UserService.Models
{
    public class User
    {
        [ID]
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        
        [ReferenceResolver]
        public static User ResolveReference(
            int id,
            IUserRepository userRepository
        )
        {
            return userRepository.GetUser(id);
        }
    }
}