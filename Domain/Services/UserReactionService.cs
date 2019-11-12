using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Domain.Services
{
    public class UserReaction
    {
        public string UserId { get; set; }

        public bool Liked { get; set; }

        public string[] WhoLiked { get; set; }

        public string[] WhoDisliked { get; set; }
    }

    public class UserReactionDomainService
    {
        public UserReaction GetUserReaction(string userId, bool liked, string[] whoLiked, string[] whoDisliked)
        {
            var userReaction = new UserReaction() { UserId = userId, Liked = liked };

            var userIds = new string[] { userId };
            if (liked)
            {
                userReaction.WhoDisliked = whoDisliked.Except(userIds).ToArray();

                if (whoLiked.Contains(userId))
                    userReaction.WhoLiked = whoLiked.Except(userIds).ToArray();
                else
                    userReaction.WhoLiked = whoLiked.Concat(userIds).ToArray();
            }
            else
            {
                userReaction.WhoLiked = whoLiked.Except(userIds).ToArray();

                if (whoDisliked.Contains(userId))
                    userReaction.WhoDisliked = whoDisliked.Except(userIds).ToArray();
                else
                    userReaction.WhoDisliked = whoDisliked.Concat(userIds).ToArray();
            }

            return userReaction;
        }
    }
}
