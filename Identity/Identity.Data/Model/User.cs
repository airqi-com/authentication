namespace Identity.Data.Model
{
    using UserDto = Identity.Common.DataTransfer.User;

    /// <summary>
    /// A class that represents the user entity.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets and sets the user identifier.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets and sets the username.
        /// </summary>
        public string? Username { get; set; }

        /// <summary>
        /// Gets and sets the password of the user.
        /// </summary>
        public string? Password { get; set; }

        /// <summary>
        /// Converts this to a <see cref="UserDto"/>.
        /// </summary>
        /// <returns>The DTO containing the user.</returns>
        public UserDto ToDto()
        {
            return new UserDto
            {
               Id = Id,
               Username = Username,
               Password = Password,
            };
        }
    }
}
