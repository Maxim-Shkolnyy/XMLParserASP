using System.Linq.Expressions;
using xmlParserASP.Models;
using xmlParserASP.Presistant;

namespace xmlParserASP.Repository
{
    public class AttrRepo
    {    
        private readonly MyDBContext _db;

        public AttrRepo(MyDBContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public MyAttribute Add(MyAttribute entity)
        {
            _db.MyAttributes.Add(entity);
            _db.SaveChanges();
            return entity;
        }

        public bool DeleteById(int id)
        {
            var attr = _db.MyAttributes.FirstOrDefault(x => x.AttrId == id);

            //if (attr?.Id == null || _db.Groups.Count(x => x.CourseId == id) > 0)
            //    return false;

            _db.MyAttributes.Remove(attr);
            _db.SaveChanges();
            return true;
        }


        public MyAttribute FindById(int id)
        {
            return _db.MyAttributes.FirstOrDefault(x => x.AttrId == id);
        }

        public IEnumerable<MyAttribute> GetAll()
        {
            return _db.MyAttributes;
        }

        public IEnumerable<MyAttribute> GetFiltered(Expression<Func<MyAttribute, bool>> filter)
        {
            return _db.MyAttributes.Where(filter);
        }

        public IEnumerable<MyAttribute> GetPaged(int take, int skip)
        {
            return _db.MyAttributes.OrderBy(x => x.AttrId).Skip(skip).Take(take);
        }

        public MyAttribute Update(MyAttribute entity)
        {
            MyAttribute course = _db.MyAttributes.FirstOrDefault(x => x.AttrId == entity.AttrId);

            if (course != null)
            {
                course.AttrId = entity.AttrId;
                course.Attr_Name = entity.Attr_Name;
                course.ParentAttrId = entity.ParentAttrId;
                course.SuppAttrNameEqualsOurAttr = entity.SuppAttrNameEqualsOurAttr;
                course.SuppAttrIdEqualsOurAttr = entity.SuppAttrIdEqualsOurAttr;
                _db.SaveChanges();
            }
            return course;
        }

        public int Count()
        {
            return _db.MyAttributes.Count();
        }

        public int Count(Expression<Func<MyAttribute, bool>> filter)
        {
            return _db.MyAttributes.Count(filter);
        }

        public IEnumerable<MyAttribute> GetFilteredAndPaged(Expression<Func<MyAttribute, bool>> filter, int take, int skip)
        {
            return _db.MyAttributes.OrderBy(x => x.AttrId).Where(filter).Skip(skip).Take(take);
        }
    }
}

