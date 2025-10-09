
namespace GeometriaModels.Models;

public abstract class FiguraModel
{
    public int? Id { get; set; }
    public double? Area { get; set; }

    protected FiguraModel()
    {
    }

}
