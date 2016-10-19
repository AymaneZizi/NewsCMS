﻿using Mn.Framework.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mn.NewsCms.Common
{
    public interface ICommentBiz
    {
        Comment Get(int id);
        IQueryable<Comment> GetList();
        IQueryable<Comment> GetList(int postId);
        OperationStatus CreateEdit(Comment comment);
        OperationStatus Delete(int id);
    }
}
