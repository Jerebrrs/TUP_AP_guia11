using GeometriaModels.Models;

namespace GeometriaModels.DALs
{
    public class ListFigurasDal : IBaseDAL
    {

        List<FiguraModel> listFiguras = new List<FiguraModel>();

        public FiguraModel Add(FiguraModel figura)
        {
            if (figura != null)
            {
                listFiguras.Add(figura);
            }
            return figura;
        }

        public void Delete(int id)
        {
            var figura = GetById(id);
            if (figura != null)
            {
                listFiguras.Remove(figura);
            }
        }

        public List<FiguraModel> GetAll()
        {
            if (listFiguras.Count > 0)
            {
                return listFiguras;
            }
            return null;
        }

        public FiguraModel GetById(int? id)
        {
            var figura =  listFiguras.Where(f  => f.Id == id).FirstOrDefault();

            if( figura != null)
            {
                return figura;
            }
            return null;
        }

        public FiguraModel Save(FiguraModel entidad)
        {
            var f = GetById(entidad.Id);
            if (f == null) return null;
            if (f.GetType() != entidad.GetType()) return null;

         
            if (entidad is RectanguloModel r)
            {
                var fig = f as RectanguloModel;
                fig.Area = r.Area;
                fig.Largo = r.Largo;
                fig.Ancho = r.Ancho;
                return fig;
            }else if(entidad is CirculoModel c)
            {
               var fig = f as CirculoModel;
                fig.Radio = c.Radio;
                fig.Area = c.Area;
                return fig;
            }

            return null;

        }
    }
}
