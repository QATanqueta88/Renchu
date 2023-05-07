using PARCIAL_1.Models;
namespace PARCIAL_1.ViewModels;


public class ActorViewModel{

    public List<Actor> Actors { get; set; } = new List<Actor>();

    public string? NameFilter {get ; set; }
}