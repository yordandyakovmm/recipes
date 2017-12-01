using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Recipes.DAL;
using Recipes.Models;

namespace Recipes.Hellpers
{
    public class UserHeppler
    {
        public static VMUser SyncUserToDatabase(VMUser user)
        {
            user.PictureUrl = user.PictureUrl ?? "";
            user.FirstName = user.FirstName ?? "";
            user.LastName = user.LastName ?? "";
            user.Email = user.Email ?? "";
            user.Role = user.Role ?? "";

            using (RecipeDBContext context = new RecipeDBContext())
            {
                var userDB = context.Users.Where(u => u.UserId == user.UserId).SingleOrDefault();
                if (userDB != null)
                {
                    user.Role = userDB.Role;
                    return user;
                }
                user.Role = "";
                var newUserBD = new Users()
                {
                    UserId = user.UserId,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    PictureUrl = user.PictureUrl,
                    CreateDate = DateTime.Now,
                    Role = user.Role
                };

                context.Users.Add(newUserBD);
                context.SaveChanges();
                return user;
            }
        }
        
    }
}