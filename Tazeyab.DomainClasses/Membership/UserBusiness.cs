﻿using System;
using Mn.NewsCms.Common.BaseClass;
using System.Linq;
using Mn.NewsCms.Common;
using Mn.NewsCms.Common.Membership;

namespace Mn.NewsCms.DomainClasses
{
    public class UserBusiness : BaseBusiness<User, int>, IUserBusiness
    {
        private readonly IUnitOfWork _dbContext;

        public UserBusiness(IUnitOfWork dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        User IUserBusiness.Get(int userId)
        {
            return base.GetList().SingleOrDefault(u => u.Id == userId);
        }

        User IUserBusiness.Get(string userName)
        {
            userName = userName.ToLower();
            return base.GetList().SingleOrDefault(u => u.UserName.ToLower() == userName);
        }

        OperationStatus IUserBusiness.Update(User user)
        {
            return base.Update(user);
        }

        IQueryable<User> IUserBusiness.GetList()
        {
            return base.GetList();
        }

        public bool IsUserFlow(string EntityCode, string UserName, string Content)
        {
            throw new NotImplementedException();
            //EntityCode = EntityCode.ToLower();
            //if (EntityCode == "cat")
            //{
            //    var item = ServiceFactory.Get<ICategoryBusiness>().Get(Content).Users.Any(c => c.UserName == UserName);
            //    if (item)
            //        return true;
            //}
            //if (EntityCode == "tag")
            //{
            //    var item = ServiceFactory.Get<ITagBusiness>().Get(Content).Users.Any(c => c.UserName == UserName);
            //    if (item)
            //        return true;
            //}
            //if (EntityCode == "site")
            //{
            //    var item = ServiceFactory.Get<ISiteBusiness>().Get(Content).Users.Any(c => c.UserName == UserName);
            //    if (item)
            //        return true;
            //}
            return false;
        }

        public bool IsInRole(string userName, string roleName)
        {
            var role = _dbContext.Set<Role>().SingleOrDefault(r => r.Name == roleName);
            if (role != null)
            {
                return GetList().SingleOrDefault(u => u.UserName == userName).Roles.Any(r => r.RoleId == role.Id);
            }
            return false;
        }

        public IQueryable<Role> GetRoleList()
        {
            return _dbContext.Set<Role>().AsQueryable();
        }
    }
}
