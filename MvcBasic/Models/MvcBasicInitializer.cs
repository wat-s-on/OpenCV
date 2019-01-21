using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcBasic.Models
{
    internal class MvcBasicInitializer : DropCreateDatabaseAlways<MvcBasicContext>
    {
        protected override void Seed(MvcBasicContext context)
        {
            var members = new List<Member>
            {
                new Member
                {
                    Name = "山田理央",
                    Email = "rio@wings.msn.to",
                    Birth = DateTime.Parse("1980-06-25"),
                    Married = false,
                    Memo = "ピアノが大好きです。",
                },
                new Member
                {
                    Name = "日尾直久",
                    Email = "naohiro@wings.msn.to",
                    Birth = DateTime.Parse("1975-07-19"),
                    Married = false,
                    Memo = "子供にやさしいお医者さんです。",
                },
            };
            members.ForEach(m => context.Members.Add(m));
            context.SaveChanges();
        }
    }
}