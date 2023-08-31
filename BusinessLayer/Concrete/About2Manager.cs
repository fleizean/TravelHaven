using System;
using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class About2Manager : IAbout2Service
    {
        IAbout2Dal _about2Dal;

        public About2Manager(IAbout2Dal aboutDal)
        {
            _about2Dal = aboutDal;
        }

        public void TAdd(About2 t)
        {
            _about2Dal.Insert(t);
        }

        public void TDelete(About2 t)
        {
            _about2Dal.Delete(t);
        }

        public About2 TGetByID(int id)
        {
            return _about2Dal.GetByID(id);
        }

        public List<About2> TGetList()
        {
            return _about2Dal.GetList();
        }

        public void TUpdate(About2 t)
        {
            _about2Dal.Update(t);
        }
    }
}

