﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace NiceIO.Tests
{
	[TestFixture]
	public class Combine
	{
		[Test]
		public void WithTrailingSlash()
		{
			Assert.AreEqual("mysubdir",new Path("mydir").Combine("mysubdir/").FileName);
		}

		[Test]
		public void WithRootedArgument()
		{
			Assert.Throws<ArgumentException>(()=>new Path("/somedir").Combine(new Path("/other")));
		}

		[Test]
		public void Simple()
		{
			Assert.AreEqual("/somedir/other/myfile", new Path("/somedir").Combine(new Path("other/myfile")).ToString());
		}
	}
}
