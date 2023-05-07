namespace PARCIAL_1.Models;

public class Manager {

    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Mail { get; set; }
    public string Phone { get; set; }
    public virtual List<Actor> Actors {get; set;} = new();

}