using LearnGeneric.Blogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnGeneric.Abstracts
{
	// dùng chung interface
	public interface IGenericService<TEntity, TUpdateVM>  // model, updateviewmodel
	{
		void Add(TEntity blog);
		void Update(TUpdateVM model);
		void Delete(int id);
		List<TEntity> Search(string key);
	}
}
