﻿Post post=new Post();
post.Title="hello";
post.Description="sdfgjertyuio";
post.Comment("fghjkl;");
post.Comment("fghjkldsakjdaskda");
post.Comment("fghjkldbnmsdkbsuq");
post.Comment("fghjklweqeewq");
post.Comment("fghwqeqe;");
post.Comment("ferterfw;");
post.Like();
post.Like();
post.Like();
post.Like();
post.Like();
post.PrintComment();
System.Console.WriteLine($"like {post.like}");