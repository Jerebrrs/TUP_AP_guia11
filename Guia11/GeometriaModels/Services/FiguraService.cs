using GeometriaModels.DALs;
using GeometriaModels.Models;

namespace GeometriaModels.Services
{
    public class FiguraService
    {
       IBaseDAL _figuraDAL;

        public FiguraService(IBaseDAL fDal)
        {
            _figuraDAL = fDal;
        }

        public List<FiguraModel> GetAll()
        {
            return _figuraDAL.GetAll();
        }

        public FiguraModel GetById(int id)
        {
            return _figuraDAL.GetById(id);
        }

        public FiguraModel AddFigura(FiguraModel nueva)
        {
            return _figuraDAL.Add(nueva);
        }


    }
}
