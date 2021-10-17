/*
    Mythotic API - Users Model Class

    This class defines what fields/data an user would have.

    Required Fields:
    -   Id
    -   Name
    -   Email
    -   Permissions Level
        -   0 = No access (or Unverified)
        -   1 = Normal User
        -   2 = Power/VIP User
        -   3 = Staff/Moderator
        -   4 = Administrator
        -   5 = God Mode (Owner, only 1 person should have this)
    -   Password

    Optional Fields (Socials):
    -   Website
    -   Facebook
    -   Twitter
    -   Reddit
    -   Steam
    -   Discord
    -   Bio

    API Related Fields
    -   API Enabled (yes/no)
    -   API Key
    -   API Secret (not viewable)

    API Secret will NOT be shown in public view but it will be kept and encrypted
 */

namespace MythoticAPI.Models
{
    public class User
    {
        // Required Fields
        public long Id {  get; set; }
        public string Name {  get; set; }
        public string Email {  get; set; }
        public string Password {  get; set; }
        public int PermissionsLevel {  get; set; }

        // Optional Fields
        #nullable enable
        public string? Website {  get; set; }
        public string? Facebook {  get; set; }
        public string? Twitter {  get; set; }
        public string? Reddit {  get; set; }
        public string? Steam {  get; set; }
        public string? Discord {  get; set; }
        public string? Bio {  get; set; }


        // API Fields
        public bool APIEnabled {  get; set; }
        public string? APIKey {  get; set; }
        public string? APISecret {  get; set; }
        
    }
}
