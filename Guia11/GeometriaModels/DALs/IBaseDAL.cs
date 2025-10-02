

using GeometriaModels.Models;

namespace GeometriaModels.DALs
{
    public interface IBaseDAL
    {
        List<FiguraModels> GetAll();
        FiguraModels GetById(int? id);
        FiguraModels Add(FiguraModels figura);
        FiguraModels Save(FiguraModels entidad);
        void Delete(int id);
    }
}
