using GeometriaModels.DALs;

namespace GeometriaModels.Services
{
    public class FiguraService
    {
       private IBaseDAL figurasDal;


        public FiguraService(IBaseDAL fDal)
        {
            this.figurasDal = fDal;
        }

    }
}
