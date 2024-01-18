namespace Identity.Common.DataTransfer
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Contains information about the user.
    /// </summary>
    [DataContract]
    public class User
    {
        /// <summary>
        /// Gets or sets the unique identifier of this user.
        /// </summary>
        [DataMember]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        [DataMember]
        public string? Username { get; set; }


        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        [DataMember]
        public string? Password { get; set; }
    }
}
