using LearnGeneric.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnGeneric.Blogs
{
	public class BlogService : IGenericService<Blog, UpdateBlogViewModel> // kế thừa từ interface dùng chung
	{
		public void Add(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public List<Blog> Search(string key)
		{
			throw new NotImplementedException();
		}

		public void Update(UpdateBlogViewModel model)
		{
			throw new NotImplementedException();
		}
	}
}
