using PARCIAL_1.Utils;
using System.ComponentModel.DataAnnotations;
namespace PARCIAL_1.Models;


public class Actor {

public int Id { get; set; }

[Required]
[Display(Name = "Nombre")]
public string Name { get; set; }


[Required]
[Display(Name = "Apellido")]
public string Surname{ get; set; }

[Required]
public int Edad { get; set; }

public string Mail { get; set; }

public ActorType Type { get; set; }

[Display(Name = "Experiencia")]
public bool Experience { get; set;} = false;

public virtual List<Pelicula> Peliculas {get; set;} = new();





}